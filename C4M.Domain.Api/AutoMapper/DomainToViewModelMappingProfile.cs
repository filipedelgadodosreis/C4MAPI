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
            CreateMap<Equipamentos, Instrument>();
            CreateMap<Domain.Entities.Applicationinventory, ViewModel.Applicationinventory>();
            CreateMap<Domain.Entities.Applicationpackage, ViewModel.Applicationpackage>();
            CreateMap<Domain.Entities.Devicedate, ViewModel.Devicedate>();
            CreateMap<Domain.Entities.Batterymonitorsettings, ViewModel.Batterymonitorsettings>();
            CreateMap<Domain.Entities.Blacklist, ViewModel.Blacklist>();
            CreateMap<Domain.Entities.Datausage, ViewModel.Datausage>();
            CreateMap<Domain.Entities.Devicedate1, ViewModel.Devicedate1>();
            CreateMap<Domain.Entities.Datausagemonitorsettings, ViewModel.Datausagemonitorsettings>();
            CreateMap<Domain.Entities.Deviceinformation, ViewModel.Deviceinformation>();
            CreateMap<Domain.Entities.Devicedate2, ViewModel.Devicedate2>();
            CreateMap<Domain.Entities.Group, ViewModel.Group>();
            CreateMap<Domain.Entities.Lastbatterydata, ViewModel.Lastbatterydata>();
            CreateMap<Domain.Entities.Devicedate3, ViewModel.Devicedate3>();
            CreateMap<Domain.Entities.Lastlocation, ViewModel.Lastlocation>();
            CreateMap<Domain.Entities.Coordinate, ViewModel.Coordinate>();
            CreateMap<Domain.Entities.Devicedate4, ViewModel.Devicedate4>();
            CreateMap<Domain.Entities.Lastmemorydata, ViewModel.Lastmemorydata>();
            CreateMap<Domain.Entities.Devicedate5, ViewModel.Devicedate5>();
            CreateMap<Domain.Entities.Locationhistorymonitorsettings, ViewModel.Locationhistorymonitorsettings>();
            CreateMap<Domain.Entities.Locationmonitorsettings, ViewModel.Locationmonitorsettings>();
            CreateMap<Domain.Entities.Memorymonitorsettings, ViewModel.Memorymonitorsettings>();
            CreateMap<Domain.Entities.Applicationusagestatisticsmonitorsettings, ViewModel.Applicationusagestatisticsmonitorsettings>();

            CreateMap<EquipamentosDadosMinimos, DeviceCreateDadosMinimos>();
            CreateMap<DadosMinimos, InstrumentDadosMinimos>();
            CreateMap<Domain.Entities.Batterymonitorsettingsdm, ViewModel.Batterymonitorsettingsdm>();
            CreateMap<Domain.Entities.Deviceinformationdm, ViewModel.Deviceinformationdm>();
            CreateMap<Domain.Entities.Devicedatedm, ViewModel.Devicedatedm>();
            CreateMap<Domain.Entities.Lastbatterydatadm, ViewModel.Lastbatterydatadm>();
            CreateMap<Domain.Entities.Devicedate1dm, ViewModel.Devicedate1dm>();
        }
    }
}
