using AutoMapper;
using XRM.Application._2_ViewModels._20_Sistema;
using XRM.Application._2_ViewModels._21_Cadastro;
using XRM.Domain._0_Entities._00_Sistema;
using XRM.Domain._0_Entities._01_Cadastro;

namespace XRM.Application._3_AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            #region Sistema

            CreateMap<vmdSISDEPARTA, TBSISDEPARTA>();
            CreateMap<vmdSISEMPRESA, TBSISEMPRESA>();
            CreateMap<vmdSISMODULOX, TBSISMODULOX>();
            CreateMap<vmdSISTEMAXXX, TBSISTEMAXXX>();

            #endregion Sistema

            #region Cadastro

            CreateMap<vmdCADEMAILXX, TBCADEMAILXX>();
            CreateMap<vmdCADENDEREC, TBCADENDEREC>();
            CreateMap<vmdCADTELEFON, TBCADTELEFON>();

            #endregion Cadastro
        }
    }
}
