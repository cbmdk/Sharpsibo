namespace Sharpsibo.Models
{
    public class AcState
    {
        public bool on { get; set; }
        public int targetTemperature { get; set; }
        public string temperatureUnit { get; set; }
        public string mode { get; set; }
        public string fanLevel { get; set; }
    }
}