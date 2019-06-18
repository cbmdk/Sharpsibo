using System;
using System.IO;
using System.Net;
using System.Net.WebSockets;
using Newtonsoft.Json;
using Sharpsibo.Models;

namespace Sharpsibo
{
    public class Sharpsibo
    {
        private readonly string hostUrl = "home.sensibo.com";
        private readonly string basePath = "/api/v2/";
        readonly string _key;

        public Sharpsibo(string apiKey)
        {
            _key = apiKey;
        }

        public Pods GetPods()
        {
            var request = (HttpWebRequest) WebRequest.Create($"https://{hostUrl}{basePath}users/me/pods?fields=*&apiKey={_key}");
            request.Method = "GET";
            request.ContentType = "application/json";

            using (var response = (HttpWebResponse) request.GetResponse())
            {
                var responseValue = string.Empty;

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var failed = $"Request failed. Received HTTP {response.StatusCode}";
                    throw new ApplicationException(failed);
                }

                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (var reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                        }
                    }
                }

                var pods = JsonConvert.DeserializeObject<Pods>(responseValue);
                return pods;
            }
        }

        public History GetReadings(int days, string podId)
        {
            var request = (HttpWebRequest) WebRequest.Create($"https://{hostUrl}{basePath}pods/{podId}/historicalMeasurements?apiKey={_key}&days={days}");
            request.Method = "GET";
            request.ContentType = "application/json";
            using (var response = (HttpWebResponse) request.GetResponse())
            {
                var result = string.Empty;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var failed = $"Request failed. Received HTTP {response.StatusCode}";
                    throw new ApplicationException(failed);
                }

                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (var reader = new StreamReader(responseStream))
                        {
                            result = reader.ReadToEnd();
                        }
                    }
                }

                var history = JsonConvert.DeserializeObject<History>(result);
                return history;

            }

        }

        public History GetAcStates(string podId)
        {
            var request = (HttpWebRequest) WebRequest.Create($"https://{hostUrl}{basePath}pods/{podId}/acStates?apiKey={_key}");
            request.Method = "GET";
            request.ContentType = "application/json";
            using (var response = (HttpWebResponse) request.GetResponse())
            {
                var result = string.Empty;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var failed = $"Request failed. Received HTTP {response.StatusCode}";
                    throw new ApplicationException(failed);
                }

                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (var reader = new StreamReader(responseStream))
                        {
                            result = reader.ReadToEnd();
                        }
                    }
                }

                var history = JsonConvert.DeserializeObject<History>(result);
                return history;

            }
        }
    }
}
