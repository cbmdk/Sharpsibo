namespace Sharpsibo.Models
{
    public class Pod
    {
        public string id { get; set; }
        public Room room { get; set; }
        public string isGeofenceOnExitEnabled { get; set; }
        public string macAddress { get; set; }
        public string configGroup { get; set; }
        public string serial { get; set; }
        public Measurements measurements { get; set; }
        public AcState acstate { get; set; }
        public Location location { get; set; }
        public ConnectionStatus connectionStatus { get; set; }
        public SensorCalibration sensorCalibration { get; set; }
        public string currentlyAvailableFirmwareVersion { get; set; }
        public bool isOwner { get; set; }
        public bool isGeofenceOnEnterEnabledForThisUser { get; set; }
        public bool isClimateReactGeofenceOnExitEnabled { get; set; }
        public string firmwareVersion { get; set; }
        public string productModel { get; set; }

    }
}
