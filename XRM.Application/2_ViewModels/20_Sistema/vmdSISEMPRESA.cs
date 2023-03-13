using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace XRM.Application._2_ViewModels._20_Sistema
{
    public class vmdSISEMPRESA
    {
        [Key]
        public int TBSISEMPRESA_NS { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string TBSISEMPRESA_NM { get; set; }

        [DisplayName("Nome Fantasia")]
        [Required(ErrorMessage = "Preencha o campo nome fantasia")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string TBSISEMPRESA_NM_FANTASIA { get; set; }

        [DisplayName("Descrição")]
        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres")]
        public string TBSISEMPRESA_DS { get; set; }

        [DisplayName("Data cadastro")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime TBSISEMPRESA_DT_CAD { get; set; }

        [DisplayName("Data inativo")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? TBSISEMPRESA_DT_INA { get; set; }

        [DisplayName("CPF/CNPJ")]
        [Required(ErrorMessage = "Preencha o campo CPF/CNPJ")]
        public Int64 TBSISEMPRESA_CPF_CNPJ { get; set; }
    }
}
