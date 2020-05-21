using AutoMapper;
using C4M.Api.ViewModel;

namespace C4M.Api.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Domain.Entities.Device, DeviceCreate>();
            CreateMap<Domain.Entities.Instrument, Instrument>();
            CreateMap<Domain.Entities.Applicationinventory, Applicationinventory>();
            CreateMap<Domain.Entities.Applicationpackage, Applicationpackage>();
            CreateMap<Domain.Entities.Devicedate, Devicedate>();
            CreateMap<Domain.Entities.Batterymonitorsettings, Batterymonitorsettings>();
            CreateMap<Domain.Entities.Blacklist, Blacklist>();
            CreateMap<Domain.Entities.Datausage, Datausage>();
            CreateMap<Domain.Entities.Devicedate1, Devicedate1>();
            CreateMap<Domain.Entities.Datausagemonitorsettings, Datausagemonitorsettings>();
            CreateMap<Domain.Entities.Deviceinformation, Deviceinformation>();
            CreateMap<Domain.Entities.Devicedate2, Devicedate2>();
            CreateMap<Domain.Entities.Group, Group>();
            CreateMap<Domain.Entities.Lastbatterydata, Lastbatterydata>();
            CreateMap<Domain.Entities.Devicedate3, Devicedate3>();
            CreateMap<Domain.Entities.Lastlocation, Lastlocation>();
            CreateMap<Domain.Entities.Coordinate, Coordinate>();
            CreateMap<Domain.Entities.Devicedate4, Devicedate4>();
            CreateMap<Domain.Entities.Lastmemorydata, Lastmemorydata>();
            CreateMap<Domain.Entities.Devicedate5, Devicedate5>();
            CreateMap<Domain.Entities.Locationhistorymonitorsettings, Locationhistorymonitorsettings>();
            CreateMap<Domain.Entities.Locationmonitorsettings, Locationmonitorsettings>();
            CreateMap<Domain.Entities.Memorymonitorsettings, Memorymonitorsettings>();
            CreateMap<Domain.Entities.Applicationusagestatisticsmonitorsettings, Applicationusagestatisticsmonitorsettings>();
        }
    }
}
