using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using XRM.Domain._0_Entities._00_Sistema;
using XRM.Domain._0_Entities._01_Cadastro;

namespace XRM.Application._2_ViewModels._21_Cadastro
{
    public class vmdCADEMAILXX
    {
        [Key]
        public int TBCADEMAILXX_NS { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Preencha o campo Logradouro")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string TBCADEMAILXX_NM { get; set; }

        [DisplayName("Descrição")]
        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres")]
        public string TBCADEMAILXX_DS { get; set; }
        
        /* Email preferencial S = true / N = false */
        [DisplayName("Preferencial")]
        public bool TBCADEMAILXX_PREF { get; set; }

        [DisplayName("Data cadastro")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime TBCADEMAILXX_DT_CAD { get; set; }

        [DisplayName("Data inativo")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? TBCADEMAILXX_DT_INA { get; set; }

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
