using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace C4M.BackgroundTasks.Models
{
    public class DeviceCreate
    {
        public List<Instrument> Devices { get; set; } = new List<Instrument>();
    }

    public class Instrument
    {
        public int activeApplicationId { get; set; }
        public string activeApplicationVersionName { get; set; }
        public int activeApplicationVersionNameAsNumber { get; set; }
        public string alias { get; set; }
        public object androidForWorkPolicySettings { get; set; }
        public Applicationinventory applicationInventory { get; set; }
        public object[] applicationSettings { get; set; }
        public object applicationUsageStatisticsMonitorSettings { get; set; }
        public Batterymonitorsettings batteryMonitorSettings { get; set; }
        public Blacklist[] blacklist { get; set; }
        public DateTime? creationDate { get; set; }
        public Datausage dataUsage { get; set; }
        public Datausagemonitorsettings dataUsageMonitorSettings { get; set; }
        public Deviceinformation deviceInformation { get; set; }
        public object emailSettings { get; set; }
        public bool enabled { get; set; }
        public Group group { get; set; }
        public int groupId { get; set; }
        public string hardwareId { get; set; }

        [JsonProperty("id")]
        public int DeviceId { get; set; }

        public Lastbatterydata lastBatteryData { get; set; }
        public DateTime? lastCommunication { get; set; }
        public DateTime? lastGroupChangeDate { get; set; }
        public Lastlocation lastLocation { get; set; }
        public Lastmemorydata lastMemoryData { get; set; }
        public object lgPolicySettings { get; set; }
        public Locationhistorymonitorsettings locationHistoryMonitorSettings { get; set; }
        public Locationmonitorsettings locationMonitorSettings { get; set; }
        public string lockPassword { get; set; }
        public Memorymonitorsettings memoryMonitorSettings { get; set; }
        public object passwordPolicySettings { get; set; }
        public int platform { get; set; }
        public object[] remoteAssistances { get; set; }
        public object samsungPolicySettings { get; set; }
        public object vpnSettings { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime DtLeitura { get; set; }
    }

    public class Applicationinventory
    {
        public Applicationpackage[] applicationPackages { get; set; }
        public Devicedate deviceDate { get; set; }
        public DateTime? receivedDate { get; set; }
    }

    public class Devicedate
    {
        public DateTime? date { get; set; }
        public string timeZoneId { get; set; }
        public int utcOffset { get; set; }
    }

    public class Applicationpackage
    {
        public string friendlyName { get; set; }
        public DateTime? installationTime { get; set; }
        public bool isSystemApplication { get; set; }
        public DateTime? lastUpdateTime { get; set; }
        public string packageName { get; set; }
        public string packageVersion { get; set; }
        public int packageVersionCode { get; set; }
    }

    public class Batterymonitorsettings
    {
        public bool enabled { get; set; }
        public int monitoringInterval { get; set; }
        public int storageTime { get; set; }
        public int synchronizationInterval { get; set; }
    }

    public class Datausage
    {
        public DateTime? cycleStart { get; set; }
        public Devicedate1 deviceDate { get; set; }
        public Int64 receivedBytes { get; set; }
        public Int64 sentBytes { get; set; }
        public DateTime? receivedDate { get; set; }
    }

    public class Devicedate1
    {
        public DateTime? date { get; set; }
        public string timeZoneId { get; set; }
        public int utcOffset { get; set; }
    }

    public class Datausagemonitorsettings
    {
        public int beginOfCycle { get; set; }
        public bool enabled { get; set; }
        public int monitoringInterval { get; set; }
        public int storageTime { get; set; }
        public int synchronizationInterval { get; set; }
    }

    public class Deviceinformation
    {
        public string carrier { get; set; }
        public string[] clientCapabilities { get; set; }
        public Devicedate2 deviceDate { get; set; }
        public string imei { get; set; }
        public string imei2 { get; set; }
        public int locationMode { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string serialNumber { get; set; }
        public object[] simCards { get; set; }
        public string version { get; set; }
        public string wifiMacAddress { get; set; }
        public DateTime? receivedDate { get; set; }
    }

    public class Devicedate2
    {
        public DateTime? date { get; set; }
        public string timeZoneId { get; set; }
        public int utcOffset { get; set; }
    }

    public class Group
    {
        public string enrollCode { get; set; }
        public string fullName { get; set; }

        [JsonProperty("id")]
        public int GroupId { get; set; }

        public string name { get; set; }
        public string parentFullName { get; set; }
        public int? parentGroupId { get; set; }
    }

    public class Lastbatterydata
    {
        public Devicedate3 deviceDate { get; set; }
        public int level { get; set; }
        public DateTime? receivedDate { get; set; }
    }

    public class Devicedate3
    {
        public DateTime? date { get; set; }
        public string timeZoneId { get; set; }
        public int utcOffset { get; set; }
    }

    public class Lastlocation
    {
        public DateTime? lastCommunicationDate { get; set; }
        public DateTime? receivedDate { get; set; }

 
        public float accuracy { get; set; }
        public float altitude { get; set; }
        public float bearing { get; set; }
        public Coordinate coordinate { get; set; }
        public Devicedate4 deviceDate { get; set; }
        public float speed { get; set; }
    }

    public class Coordinate
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
    }

    public class Devicedate4
    {
        public DateTime? date { get; set; }
        public string timeZoneId { get; set; }
        public int utcOffset { get; set; }
    }

    public class Lastmemorydata
    {
        public long availableExternalStorage { get; set; }
        public long availableInternalStorage { get; set; }
        public int availableRamMemory { get; set; }
        public Devicedate5 deviceDate { get; set; }
        public long totalExternalStorage { get; set; }
        public long totalInternalStorage { get; set; }
        public int totalRamMemory { get; set; }
        public DateTime? receivedDate { get; set; }
    }

    public class Devicedate5
    {
        public DateTime? date { get; set; }
        public string timeZoneId { get; set; }
        public int utcOffset { get; set; }
    }

    public class Locationhistorymonitorsettings
    {
        public int monitoringQuality { get; set; }
        public bool enabled { get; set; }
        public int monitoringInterval { get; set; }
        public int storageTime { get; set; }
        public int synchronizationInterval { get; set; }
    }

    public class Locationmonitorsettings
    {
        public bool enabled { get; set; }
        public int monitoringInterval { get; set; }
        public int storageTime { get; set; }
        public int synchronizationInterval { get; set; }
    }

    public class Memorymonitorsettings
    {
        public bool enabled { get; set; }
        public int monitoringInterval { get; set; }
        public int storageTime { get; set; }
        public int synchronizationInterval { get; set; }
    }

    public class Blacklist
    {
        public string alias { get; set; }

        [JsonProperty("id")]
        public int BlacklistId { get; set; }
        public string packageName { get; set; }
    }
}
