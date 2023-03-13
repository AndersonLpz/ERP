using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace XRM.Application._2_ViewModels._20_Sistema
{
    public class vmdSISMODULOX
    {
        [Key]
        public int TBSISMODULOX_NS { get; set; }

        [DisplayName("Modulo")]
        [Required(ErrorMessage = "Preencha o campo Departamento")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string TBSISMODULOX_NM { get; set; }

        [DisplayName("Descrição")]
        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres")]
        public string TBSISMODULOX_DS { get; set; }

        [DisplayName("Data cadastro")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime TBSISMODULOX_DT_CAD { get; set; }

        [DisplayName("Data inativo")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? TBSISMODULOX_DT_INA { get; set; }
    }
}