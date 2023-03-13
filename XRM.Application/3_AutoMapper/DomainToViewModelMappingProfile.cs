using AutoMapper;
using XRM.Application._2_ViewModels._20_Sistema;
using XRM.Application._2_ViewModels._21_Cadastro;
using XRM.Domain._0_Entities._00_Sistema;
using XRM.Domain._0_Entities._01_Cadastro;

namespace XRM.Application._3_AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            #region Sistema 

            CreateMap<TBSISDEPARTA, vmdSISDEPARTA>();
            CreateMap<TBSISEMPRESA, vmdSISEMPRESA>();
            CreateMap<TBSISMODULOX, vmdSISMODULOX>();
            CreateMap<TBSISTEMAXXX, vmdSISTEMAXXX>();

            #endregion Sistema 

            #region Cadastro

            CreateMap<TBCADEMAILXX, vmdCADEMAILXX>();
            CreateMap<TBCADENDEREC, vmdCADENDEREC>();
            CreateMap<TBCADTELEFON, vmdCADTELEFON>();

            #endregion Cadastro
        }
    }
}
