using AutoMapper;
using C4M.Api.ViewModel;
using C4M.Domain.Entities;

namespace C4M.Api.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<EstruturaEquipamento, DeviceCreate>();
            CreateMap<C4MEquipamentosMongo, Instrument>();
            CreateMap<Domain.Entities.ApplicationinventoryAll, ViewModel.ApplicationinventoryAll>();
            CreateMap<Domain.Entities.Applicationpackages, ViewModel.Applicationpackages>();
            CreateMap<Domain.Entities.DevicedateAll, ViewModel.DevicedateAll>();
            CreateMap<Domain.Entities.BatterymonitorsettingsAll, ViewModel.BatterymonitorsettingsAll>();
            CreateMap<Domain.Entities.BlacklistAll, ViewModel.BlacklistAll>();
            CreateMap<Domain.Entities.DatausageAll, ViewModel.DatausageAll>();
            CreateMap<Domain.Entities.Devicedate1All, ViewModel.Devicedate1All>();
            CreateMap<Domain.Entities.DatausagemonitorsettingsAll, ViewModel.DatausagemonitorsettingsAll>();
            CreateMap<Domain.Entities.DeviceinformationAll, ViewModel.DeviceinformationAll>();
            CreateMap<Domain.Entities.Devicedate2All, ViewModel.Devicedate2All>();
            CreateMap<Domain.Entities.GroupAll, ViewModel.GroupAll>();
            CreateMap<Domain.Entities.LastbatterydataAll, ViewModel.LastbatterydataAll>();
            CreateMap<Domain.Entities.Devicedate3All, ViewModel.Devicedate3All>();
            CreateMap<Domain.Entities.LastlocationAll, ViewModel.LastlocationAll>();
            CreateMap<Domain.Entities.CoordinateAll, ViewModel.CoordinateAll>();
            CreateMap<Domain.Entities.Devicedate4All, ViewModel.Devicedate4All>();
            CreateMap<Domain.Entities.LastmemorydataAll, ViewModel.LastmemorydataAll>();
            CreateMap<Domain.Entities.Devicedate5All, ViewModel.Devicedate5All>();
            CreateMap<Domain.Entities.LocationhistorymonitorsettingsAll, ViewModel.LocationhistorymonitorsettingsAll>();
            CreateMap<Domain.Entities.LocationmonitorsettingsAll, ViewModel.LocationmonitorsettingsAll>();
            CreateMap<Domain.Entities.MemorymonitorsettingsAll, ViewModel.MemorymonitorsettingsAll>();
            CreateMap<Domain.Entities.ApplicationusagestatisticsmonitorsettingsAll, ViewModel.ApplicationusagestatisticsmonitorsettingsAll>();
        }
    }
}
