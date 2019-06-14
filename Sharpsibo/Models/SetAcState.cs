namespace Sharpsibo.Models
{
    public class SetAcState
    {
        public bool on { get; set; }
        public int targetTemperature { get; set; }
        public string mode { get; set; }
        public string fanLevel { get; set; }
    }
}