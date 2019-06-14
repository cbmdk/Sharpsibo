using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Sharpsibo.Models;

namespace Sharpsibo
{
    public class Sharpsibo
    {
        private const string hostUrl = "home.sensibo.com";
        private const string basePath = "/api/v2/";
        private const string schemes = "https";
        readonly string _key;

        public Sharpsibo(string apiKey)
        {
            _key = apiKey;
        }

        public Pods GetPods()
        {
            var request = (HttpWebRequest) WebRequest.Create($"{schemes}://{hostUrl}{basePath}users/me/pods?fields=*&apiKey={_key}");
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
    }
}
