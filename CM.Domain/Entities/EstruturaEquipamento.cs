using C4M.Domain.Attributes;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace C4M.Domain.Entities
{
    public class EstruturaEquipamento
    {
        public List<C4MEquipamentosMongo> Equipamentos { get; set; } = new List<C4MEquipamentosMongo>();
    }

    [BsonCollection("Equipamentos")]
    public class C4MEquipamentosMongo : Document
    {
        public int IdEmpresa { get; set; }

        public DateTime DtLeitura { get; set; }

        [BsonIgnoreIfNull]
        public int? activeApplicationId { get; set; }
        [BsonIgnoreIfNull]
        public string activeApplicationVersionName { get; set; }
        [BsonIgnoreIfNull]
        public int? activeApplicationVersionNameAsNumber { get; set; }
        [BsonIgnoreIfNull]
        public string alias { get; set; }
        [BsonIgnoreIfNull]
        public object androidForWorkPolicySettings { get; set; }
        [BsonIgnoreIfNull]
        public ApplicationinventoryAll applicationInventory { get; set; }
        [BsonIgnoreIfNull]
        public List<ApplicationsettingAll> applicationSettings { get; set; }
        [BsonIgnoreIfNull]
        public ApplicationusagestatisticsmonitorsettingsAll applicationUsageStatisticsMonitorSettings { get; set; }
        [BsonIgnoreIfNull]
        public BatterymonitorsettingsAll batteryMonitorSettings { get; set; }
        [BsonIgnoreIfNull]
        public List<BlacklistAll> blacklist { get; set; }
        [BsonIgnoreIfNull]
        public DateTime? creationDate { get; set; }
        [BsonIgnoreIfNull]
        public DatausageAll dataUsage { get; set; }
        [BsonIgnoreIfNull]
        public DatausagemonitorsettingsAll dataUsageMonitorSettings { get; set; }
        [BsonIgnoreIfNull]
        public DeviceinformationAll deviceInformation { get; set; }
        [BsonIgnoreIfNull]
        public object emailSettings { get; set; }
        [BsonIgnoreIfNull]
        public bool enabled { get; set; }
        [BsonIgnoreIfNull]
        public GroupAll group { get; set; }
        [BsonIgnoreIfNull]
        public int? groupId { get; set; }
        [BsonIgnoreIfNull]
        public string hardwareId { get; set; }

        [BsonIgnoreIfNull]
        [JsonProperty("id")]
        public int? DeviceId { get; set; }

        [BsonIgnoreIfNull]
        public LastbatterydataAll lastBatteryData { get; set; }
        [BsonIgnoreIfNull]
        public DateTime? lastCommunication { get; set; }
        [BsonIgnoreIfNull]
        public DateTime? lastGroupChangeDate { get; set; }
        [BsonIgnoreIfNull]
        public LastlocationAll lastLocation { get; set; }
        [BsonIgnoreIfNull]
        public LastmemorydataAll lastMemoryData { get; set; }
        [BsonIgnoreIfNull]
        public object lgPolicySettings { get; set; }
        [BsonIgnoreIfNull]
        public LocationhistorymonitorsettingsAll locationHistoryMonitorSettings { get; set; }
        [BsonIgnoreIfNull]
        public LocationmonitorsettingsAll locationMonitorSettings { get; set; }
        [BsonIgnoreIfNull]
        public string? lockPassword { get; set; }
        [BsonIgnoreIfNull]
        public MemorymonitorsettingsAll memoryMonitorSettings { get; set; }
        [BsonIgnoreIfNull]
        public object passwordPolicySettings { get; set; }
        [BsonIgnoreIfNull]
        public int? platform { get; set; }
        [BsonIgnoreIfNull]
        public List<object> remoteAssistances { get; set; }
        [BsonIgnoreIfNull]
        public SamsungpolicysettingsAll samsungPolicySettings { get; set; }
        [BsonIgnoreIfNull]
        public object vpnSettings { get; set; }
        [BsonIgnoreIfNull]
        public DateTime CreatedAt { get; set; }
    }

    [JsonObject("Applicationinventory")]
    public class ApplicationinventoryAll
    {
        [BsonIgnoreIfNull]
        public List<Applicationpackages> applicationPackages { get; set; }
        [BsonIgnoreIfNull]
        public DevicedateAll deviceDate { get; set; }
        [BsonIgnoreIfNull]
        public DateTime? receivedDate { get; set; }
    }

    [JsonObject("Devicedate")]
    public class DevicedateAll
    {
        [BsonIgnoreIfNull]
        public DateTime? date { get; set; }
        [BsonIgnoreIfNull]
        public string? timeZoneId { get; set; }
        [BsonIgnoreIfNull]
        public int? utcOffset { get; set; }
    }

    [JsonObject("applicationPackages")]
    public class Applicationpackages
    {
        [BsonIgnoreIfNull]
        public string? friendlyName { get; set; }
        [BsonIgnoreIfNull]
        public DateTime? installationTime { get; set; }
        [BsonIgnoreIfNull]
        public bool isSystemApplication { get; set; }
        [BsonIgnoreIfNull]
        public DateTime? lastUpDateTime { get; set; }
        [BsonIgnoreIfNull]
        public string? packageName { get; set; }
        [BsonIgnoreIfNull]
        public string? packageVersion { get; set; }
        [BsonIgnoreIfNull]
        public int? packageVersionCode { get; set; }
    }

    [JsonObject("Applicationusagestatisticsmonitorsettings")]
    public class ApplicationusagestatisticsmonitorsettingsAll
    {
        [BsonIgnoreIfNull]
        public bool enabled { get; set; }
        [BsonIgnoreIfNull]
        public object monitoringinterval { get; set; }
        [BsonIgnoreIfNull]
        public object storageTime { get; set; }
        [BsonIgnoreIfNull]
        public object synchronizationinterval { get; set; }
    }

    [JsonObject("Batterymonitorsettings")]
    public class BatterymonitorsettingsAll
    {
        [BsonIgnoreIfNull]
        public bool enabled { get; set; }
        [BsonIgnoreIfNull]
        public int? monitoringinterval { get; set; }
        [BsonIgnoreIfNull]
        public int? storageTime { get; set; }
        [BsonIgnoreIfNull]
        public int? synchronizationinterval { get; set; }
    }

    [JsonObject("Datausage")]
    public class DatausageAll
    {
        [BsonIgnoreIfNull]
        public DateTime? cycleStart { get; set; }
        [BsonIgnoreIfNull]
        public Devicedate1All deviceDate { get; set; }
        [BsonIgnoreIfNull]
        public long? receivedBytes { get; set; }
        [BsonIgnoreIfNull]
        public long? sentBytes { get; set; }
        [BsonIgnoreIfNull]
        public DateTime? receivedDate { get; set; }
    }

    [JsonObject("Devicedate1")]
    public class Devicedate1All
    {
        [BsonIgnoreIfNull]
        public DateTime? date { get; set; }
        [BsonIgnoreIfNull]
        public string? timeZoneId { get; set; }
        [BsonIgnoreIfNull]
        public int? utcOffset { get; set; }
    }

    [JsonObject("Datausagemonitorsettings")]
    public class DatausagemonitorsettingsAll
    {
        [BsonIgnoreIfNull]
        public int? beginOfCycle { get; set; }
        [BsonIgnoreIfNull]
        public bool enabled { get; set; }
        [BsonIgnoreIfNull]
        public int? monitoringinterval { get; set; }
        [BsonIgnoreIfNull]
        public int? storageTime { get; set; }
        [BsonIgnoreIfNull]
        public int? synchronizationinterval { get; set; }
    }

    [JsonObject("Deviceinformation")]
    public class DeviceinformationAll
    {
        [BsonIgnoreIfNull]
        public object carrier { get; set; }
        [BsonIgnoreIfNull]
        public List<string?> clientCapabilities { get; set; }
        [BsonIgnoreIfNull]
        public Devicedate2All deviceDate { get; set; }
        [BsonIgnoreIfNull]
        public string? imei { get; set; }
        [BsonIgnoreIfNull]
        public string? imei2 { get; set; }
        [BsonIgnoreIfNull]
        public int? locationMode { get; set; }
        [BsonIgnoreIfNull]
        public string? manufacturer { get; set; }
        [BsonIgnoreIfNull]
        public string? model { get; set; }
        [BsonIgnoreIfNull]
        public string? serialNumber { get; set; }
        [BsonIgnoreIfNull]
        public List<object> simCards { get; set; }
        [BsonIgnoreIfNull]
        public string? version { get; set; }
        [BsonIgnoreIfNull]
        public string? wifiMacAddress { get; set; }
        [BsonIgnoreIfNull]
        public DateTime? receivedDate { get; set; }
    }

    [JsonObject("Devicedate2")]
    public class Devicedate2All
    {
        [BsonIgnoreIfNull]
        public DateTime? date { get; set; }
        [BsonIgnoreIfNull]
        public string? timeZoneId { get; set; }
        [BsonIgnoreIfNull]
        public int? utcOffset { get; set; }
    }

    [JsonObject("Group")]
    public class GroupAll
    {
        [BsonIgnoreIfNull]
        public string enrollCode { get; set; }
        [BsonIgnoreIfNull]
        public string fullName { get; set; }
        [BsonIgnoreIfNull]
        [JsonProperty("id")]
        public int? GroupId { get; set; }
        [BsonIgnoreIfNull]
        public string? name { get; set; }
        [BsonIgnoreIfNull]
        public string? parentFullName { get; set; }
        [BsonIgnoreIfNull]
        public object parentGroupId { get; set; }
    }

    [JsonObject("Lastbatterydata")]
    public class LastbatterydataAll
    {
        [BsonIgnoreIfNull]
        public Devicedate3All deviceDate { get; set; }
        [BsonIgnoreIfNull]
        public int? level { get; set; }
        [BsonIgnoreIfNull]
        public DateTime? receivedDate { get; set; }
    }

    [JsonObject("Devicedate3")]
    public class Devicedate3All
    {
        [BsonIgnoreIfNull]
        public DateTime? date { get; set; }
        [BsonIgnoreIfNull]
        public string? timeZoneId { get; set; }
        [BsonIgnoreIfNull]
        public int? utcOffset { get; set; }
    }

    [JsonObject("Lastlocation")]

    public class LastlocationAll
    {
        [BsonIgnoreIfNull]
        public DateTime? lastCommunicationDate { get; set; }
        [BsonIgnoreIfNull]
        public DateTime? receivedDate { get; set; }
        [BsonIgnoreIfNull]
        public float? accuracy { get; set; }
        [BsonIgnoreIfNull]
        public float? altitude { get; set; }
        [BsonIgnoreIfNull]
        public float? bearing { get; set; }
        [BsonIgnoreIfNull]
        public CoordinateAll coordinate { get; set; }
        [BsonIgnoreIfNull]
        public Devicedate4All deviceDate { get; set; }
        [BsonIgnoreIfNull]
        public float? speed { get; set; }
    }

    [JsonObject("Coordinate")]
    public class CoordinateAll
    {
        [BsonIgnoreIfNull]
        public float? latitude { get; set; }
        [BsonIgnoreIfNull]
        public float? longitude { get; set; }
    }

    [JsonObject("Devicedate4")]
    public class Devicedate4All
    {
        [BsonIgnoreIfNull]
        public DateTime? date { get; set; }
        [BsonIgnoreIfNull]
        public string? timeZoneId { get; set; }
        [BsonIgnoreIfNull]
        public int? utcOffset { get; set; }
    }

    [JsonObject("Lastmemorydata")]
    public class LastmemorydataAll
    {
        [BsonIgnoreIfNull]
        public long availableExternalStorage { get; set; }
        [BsonIgnoreIfNull]
        public long availableinternalStorage { get; set; }
        [BsonIgnoreIfNull]
        public long? availableRamMemory { get; set; }
        [BsonIgnoreIfNull]
        public Devicedate5All deviceDate { get; set; }
        [BsonIgnoreIfNull]
        public long totalExternalStorage { get; set; }
        [BsonIgnoreIfNull]
        public long totalinternalStorage { get; set; }
        [BsonIgnoreIfNull]
        public long? totalRamMemory { get; set; }
        [BsonIgnoreIfNull]
        public DateTime? receivedDate { get; set; }
    }

    [JsonObject("Devicedate5")]
    public class Devicedate5All
    {
        [BsonIgnoreIfNull]
        public DateTime? date { get; set; }
        [BsonIgnoreIfNull]
        public string? timeZoneId { get; set; }
        [BsonIgnoreIfNull]
        public int? utcOffset { get; set; }
    }

    [JsonObject("Locationhistorymonitorsettings")]
    public class LocationhistorymonitorsettingsAll
    {
        [BsonIgnoreIfNull]
        public int? monitoringQuality { get; set; }
        [BsonIgnoreIfNull]
        public bool enabled { get; set; }
        [BsonIgnoreIfNull]
        public int? monitoringinterval { get; set; }
        [BsonIgnoreIfNull]
        public int? storageTime { get; set; }
        [BsonIgnoreIfNull]
        public int? synchronizationinterval { get; set; }
    }

    [JsonObject("Locationmonitorsettings")]
    public class LocationmonitorsettingsAll
    {
        [BsonIgnoreIfNull]
        public bool enabled { get; set; }
        [BsonIgnoreIfNull]
        public int? monitoringinterval { get; set; }
        [BsonIgnoreIfNull]
        public int? storageTime { get; set; }
        [BsonIgnoreIfNull]
        public int? synchronizationinterval { get; set; }
    }

    [JsonObject("Samsungpolicysettings")]
    public class MemorymonitorsettingsAll
    {
        [BsonIgnoreIfNull]
        public bool enabled { get; set; }
        [BsonIgnoreIfNull]
        public int? monitoringinterval { get; set; }
        [BsonIgnoreIfNull]
        public int? storageTime { get; set; }
        [BsonIgnoreIfNull]
        public int? synchronizationinterval { get; set; }
    }

    [JsonObject("Samsungpolicysettings")]
    public class SamsungpolicysettingsAll
    {
        [BsonIgnoreIfNull]
        public bool airplaneMode { get; set; }
        [BsonIgnoreIfNull]
        public bool audioRecord { get; set; }
        [BsonIgnoreIfNull]
        public bool bluetooth { get; set; }
        [BsonIgnoreIfNull]
        public bool camera { get; set; }
        [BsonIgnoreIfNull]
        public bool clipboard { get; set; }
        [BsonIgnoreIfNull]
        public bool clipboardShare { get; set; }
        [BsonIgnoreIfNull]
        public bool factoryReset { get; set; }
        [BsonIgnoreIfNull]
        public bool headphone { get; set; }
        [BsonIgnoreIfNull]
        public bool homeKey { get; set; }
        [BsonIgnoreIfNull]
        public bool microphone { get; set; }
        [BsonIgnoreIfNull]
        public bool navigationBar { get; set; }
        [BsonIgnoreIfNull]
        public bool nfc { get; set; }
        [BsonIgnoreIfNull]
        public bool otaUpgrade { get; set; }
        [BsonIgnoreIfNull]
        public bool powerOff { get; set; }
        [BsonIgnoreIfNull]
        public bool safeMode { get; set; }
        [BsonIgnoreIfNull]
        public bool screenCapture { get; set; }
        [BsonIgnoreIfNull]
        public bool settingsChanges { get; set; }
        [BsonIgnoreIfNull]
        public bool softwareInstallation { get; set; }
        [BsonIgnoreIfNull]
        public bool softwareUninstallation { get; set; }
        [BsonIgnoreIfNull]
        public bool statusBar { get; set; }
        [BsonIgnoreIfNull]
        public bool statusBarExpansion { get; set; }
        [BsonIgnoreIfNull]
        public bool sVoice { get; set; }
        [BsonIgnoreIfNull]
        public bool taskManager { get; set; }
        [BsonIgnoreIfNull]
        public bool videoRecord { get; set; }
        [BsonIgnoreIfNull]
        public bool wifi { get; set; }
    }

    [JsonObject("Applicationsetting")]
    public class ApplicationsettingAll
    {
        [BsonIgnoreIfNull]
        public List<object> configurations { get; set; }
        [BsonIgnoreIfNull]
        public string? packageName { get; set; }
    }

    [JsonObject("Blacklist")]
    public class BlacklistAll
    {
        [BsonIgnoreIfNull]
        public string alias { get; set; }
        [BsonIgnoreIfNull]
        [JsonProperty("id")]
        public int? BlacklistId { get; set; }
        [BsonIgnoreIfNull]
        public string? packageName { get; set; }
    }
}
