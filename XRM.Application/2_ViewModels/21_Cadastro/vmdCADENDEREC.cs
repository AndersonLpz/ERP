using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using XRM.Domain._0_Entities._00_Sistema;
using XRM.Domain._0_Entities._01_Cadastro;

namespace XRM.Application._2_ViewModels._21_Cadastro
{
    public class vmdCADENDEREC
    {
        [Key]
        public int TBCADENDEREC_NS { get; set; }

        [DisplayName("Logradouro")]
        [Required(ErrorMessage = "Preencha o campo Logradouro")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string TBCADENDEREC_NM { get; set; }

        [DisplayName("Descrição")]
        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres")]
        public string TBCADENDEREC_DS { get; set; }

        [DisplayName("Numero")]
        public int TBCADENDEREC_NU { get; set; }

        [DisplayName("Complemento")]
        [Required(ErrorMessage = "Preencha o campo Complemento")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        public string TBCADENDEREC_COMPLEMENTO { get; set; }

        [DisplayName("CEP")]
        public int TBCADENDEREC_CEP { get; set; }

        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Preencha o campo Cidade")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        public string TBCADENDEREC_CIDADE { get; set; }

        [DisplayName("UF")]
        [Required(ErrorMessage = "Preencha o campo UF")]
        [MaxLength(2, ErrorMessage = "Máximo {0} caracteres")]
        public string TBCADENDEREC_UF { get; set; }
               
        /* Endereço preferencial S = true / N = false */
        [DisplayName("Preferencial")]
        public bool TBCADENDEREC_PREF { get; set; }

        [DisplayName("Data cadastro")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime TBCADENDEREC_DT_CAD { get; set; }

        [DisplayName("Data inativo")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? TBCADENDEREC_DT_INA { get; set; }

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
