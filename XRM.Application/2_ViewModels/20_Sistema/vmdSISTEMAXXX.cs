using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace XRM.Application._2_ViewModels._20_Sistema
{
    public class vmdSISTEMAXXX
    {
        [Key]
        public int TBSISTEMAXXX_NS { get; set; }

        [DisplayName("Sistema")]
        [Required(ErrorMessage = "Preencha o campo Sistema")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string TBSISTEMAXXX_NM { get; set; }

        [DisplayName("Descrição")]
        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres")]
        public string TBSISTEMAXXX_DS { get; set; }

        [DisplayName("Data cadastro")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime TBSISTEMAXXX_DT_CAD { get; set; }

        [DisplayName("Data inativo")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime TBSISTEMAXXX_DT_INA { get; set; }

        [DisplayName("View")]
        [Required(ErrorMessage = "Preencha o campo view")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string TBSISTEMAXXX_VIEW { get; set; }

        [DisplayName("Controller")]
        [Required(ErrorMessage = "Preencha o campo controller")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string TBSISTEMAXXX_CONTROLLER { get; set; }


        [DisplayName("Modulo")]
        public int TBSISMODULOX_NS { get; set; }


        [DisplayName("Modulo")]
        public string TBSISMODULOX_NM { get; set; }

        public virtual vmdSISMODULOX TBSYSMODULOX { get; set; }
    }
}
