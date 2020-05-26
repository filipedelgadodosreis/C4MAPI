using AutoMapper;
using C4M.Api.ViewModel;

namespace C4M.Api.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<DeviceCreate, Domain.Entities.EstruturaEquipamento>();
            CreateMap<Instrument, Domain.Entities.C4MEquipamentosMongo>();
            CreateMap<ApplicationinventoryAll, Domain.Entities.ApplicationinventoryAll>();
            CreateMap<Applicationpackages, Domain.Entities.Applicationpackages>();
            CreateMap<DevicedateAll, Domain.Entities.DevicedateAll>();
            CreateMap<BatterymonitorsettingsAll, Domain.Entities.BatterymonitorsettingsAll>();
            CreateMap<BlacklistAll, Domain.Entities.BlacklistAll>();
            CreateMap<DatausageAll, Domain.Entities.DatausageAll>();
            CreateMap<Devicedate1All, Domain.Entities.Devicedate1All>();
            CreateMap<DatausagemonitorsettingsAll, Domain.Entities.DatausagemonitorsettingsAll>();
            CreateMap<DeviceinformationAll, Domain.Entities.DeviceinformationAll>();
            CreateMap<Devicedate2All, Domain.Entities.Devicedate2All>();
            CreateMap<GroupAll, Domain.Entities.GroupAll>();
            CreateMap<LastbatterydataAll, Domain.Entities.LastbatterydataAll>();
            CreateMap<Devicedate3All, Domain.Entities.Devicedate3All>();
            CreateMap<LastlocationAll, Domain.Entities.LastlocationAll>();
            CreateMap<CoordinateAll, Domain.Entities.CoordinateAll>();
            CreateMap<Devicedate4All, Domain.Entities.Devicedate4All>();
            CreateMap<LastmemorydataAll, Domain.Entities.LastmemorydataAll>();
            CreateMap<Devicedate5All, Domain.Entities.Devicedate5All>();
            CreateMap<LocationhistorymonitorsettingsAll, Domain.Entities.LocationhistorymonitorsettingsAll>();
            CreateMap<LocationmonitorsettingsAll, Domain.Entities.LocationmonitorsettingsAll>();
            CreateMap<MemorymonitorsettingsAll, Domain.Entities.MemorymonitorsettingsAll>();
            CreateMap<ApplicationusagestatisticsmonitorsettingsAll, Domain.Entities.ApplicationusagestatisticsmonitorsettingsAll>();
        }
    }
}
