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
            CreateMap<Devicedate, Domain.Entities.Devicedate>();
            CreateMap<Batterymonitorsettings, Domain.Entities.Batterymonitorsettings>();
            CreateMap<Blacklist, Domain.Entities.Blacklist>();
            CreateMap<Datausage, Domain.Entities.Datausage>();
            CreateMap<Devicedate1, Domain.Entities.Devicedate1>();
            CreateMap<Datausagemonitorsettings, Domain.Entities.Datausagemonitorsettings>();
            CreateMap<Deviceinformation, Domain.Entities.Deviceinformation>();
            CreateMap<Devicedate2, Domain.Entities.Devicedate2>();
            CreateMap<Group, Domain.Entities.Group>();
            CreateMap<Lastbatterydata, Domain.Entities.Lastbatterydata>();
            CreateMap<Devicedate3, Domain.Entities.Devicedate3>();
            CreateMap<Lastlocation, Domain.Entities.Lastlocation>();
            CreateMap<Coordinate, Domain.Entities.Coordinate>();
            CreateMap<Devicedate4, Domain.Entities.Devicedate4>();
            CreateMap<Lastmemorydata, Domain.Entities.Lastmemorydata>();
            CreateMap<Devicedate5, Domain.Entities.Devicedate5>();
            CreateMap<Locationhistorymonitorsettings, Domain.Entities.Locationhistorymonitorsettings>();
            CreateMap<Locationmonitorsettings, Domain.Entities.Locationmonitorsettings>();
            CreateMap<Memorymonitorsettings, Domain.Entities.Memorymonitorsettings>();
            CreateMap<Applicationusagestatisticsmonitorsettings, Domain.Entities.Applicationusagestatisticsmonitorsettings>();
        }
    }
}
