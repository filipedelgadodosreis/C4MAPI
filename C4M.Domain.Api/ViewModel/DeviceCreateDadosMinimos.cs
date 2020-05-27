using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace C4M.Api.ViewModel
{
    public class DeviceCreateDadosMinimos
    {
        public List<InstrumentDadosMinimos> Devices { get; set; } = new List<InstrumentDadosMinimos>();
    }

    public class InstrumentDadosMinimos
    {
        public int activeApplicationId { get; set; }
        public string activeApplicationVersionName { get; set; }
        public int activeApplicationVersionNameAsNumber { get; set; }
        public string alias { get; set; }
        public object androidForWorkPolicySettings { get; set; }
        public object applicationInventory { get; set; }
        public object[] applicationSettings { get; set; }
        public object applicationUsageStatisticsMonitorSettings { get; set; }
        public Batterymonitorsettingsdm batteryMonitorSettings { get; set; }
        public object[] blacklist { get; set; }
        public DateTime creationDate { get; set; }
        public object dataUsage { get; set; }
        public object dataUsageMonitorSettings { get; set; }
        public Deviceinformationdm deviceInformation { get; set; }
        public object emailSettings { get; set; }
        public bool enabled { get; set; }
        public object group { get; set; }
        public int groupId { get; set; }
        public string hardwareId { get; set; }

        [JsonProperty("id")]
        public int DeviceId { get; set; }

        public Lastbatterydatadm lastBatteryData { get; set; }
        public DateTime lastCommunication { get; set; }
        public DateTime lastGroupChangeDate { get; set; }
        public object lastLocation { get; set; }
        public object lastMemoryData { get; set; }
        public object lgPolicySettings { get; set; }
        public object locationHistoryMonitorSettings { get; set; }
        public object locationMonitorSettings { get; set; }
        public object lockPassword { get; set; }
        public object memoryMonitorSettings { get; set; }
        public object passwordPolicySettings { get; set; }
        public int platform { get; set; }
        public object[] remoteAssistances { get; set; }
        public object samsungPolicySettings { get; set; }
        public object vpnSettings { get; set; }
    }

    [DataContract(Name = "Batterymonitorsettings")]
    public class Batterymonitorsettingsdm
    {
        public bool enabled { get; set; }
        public int monitoringInterval { get; set; }
        public int storageTime { get; set; }
        public int synchronizationInterval { get; set; }
    }

    [DataContract(Name = "Deviceinformation")]
    public class Deviceinformationdm
    {
        public string carrier { get; set; }
        public string[] clientCapabilities { get; set; }
        public Devicedatedm deviceDate { get; set; }
        public string imei { get; set; }
        public string imei2 { get; set; }
        public int locationMode { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string serialNumber { get; set; }
        public object[] simCards { get; set; }
        public string version { get; set; }
        public string wifiMacAddress { get; set; }
        public DateTime receivedDate { get; set; }
    }

    [DataContract(Name = "Devicedate")]
    public class Devicedatedm
    {
        public DateTime date { get; set; }
        public string timeZoneId { get; set; }
        public int utcOffset { get; set; }
    }

    [DataContract(Name = "Lastbatterydata")]
    public class Lastbatterydatadm
    {
        public Devicedate1dm deviceDate { get; set; }
        public int level { get; set; }
        public DateTime receivedDate { get; set; }
    }

    [DataContract(Name = "Devicedate1")]
    public class Devicedate1dm
    {
        public DateTime date { get; set; }
        public string timeZoneId { get; set; }
        public int utcOffset { get; set; }
    }
}
