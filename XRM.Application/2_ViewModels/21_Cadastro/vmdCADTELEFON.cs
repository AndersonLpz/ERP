using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using XRM.Domain._0_Entities._00_Sistema;
using XRM.Domain._0_Entities._01_Cadastro;

namespace XRM.Application._2_ViewModels._21_Cadastro
{
    public class vmdCADTELEFON
    {
        [Key]
        public int TBCADTELEFON_NS { get; set; }

        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Preencha o campo Telefone")]
        public int TBCADTELEFON_NUM { get; set; }

        [DisplayName("DDD")]
        [Required(ErrorMessage = "Preencha o campo DDD")]
        public int TBCADTELEFON_DDD { get; set; }

        /* Telefone preferencial S = true / N = false */
        [DisplayName("Preferencial")]
        public bool TBCADTELEFON_PREF { get; set; }

        [DisplayName("Data cadastro")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime TBCADTELEFON_DT_CAD { get; set; }

        [DisplayName("Data inativo")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? TBCADTELEFON_DT_INA { get; set; }

        [ScaffoldColumn(false)]
        public int TBCADTELEFTP_NS { get; set; }

        public virtual TBCADTELEFTP TBCADTELEFTP { get; set; }

        [ScaffoldColumn(false)]
        public int? TBSISUSUARIO_NS { get; set; }

        public virtual TBSISUSUARIO TBSISUSUARIO { get; set; }

        [ScaffoldColumn(false)]
        public int? TBCLIENTEXXX_NS { get; set; }

        public virtual TBCADCLIENTE TBCADCLIENTE { get; set; }

        [ScaffoldColumn(false)]
        public int? TBSISEMPRESA_NS { get; set; }

        public virtual TBSISEMPRESA TBSISEMPRESA { get; set; }
    }
}
