using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using XRM.Domain._0_Entities._00_Sistema;

namespace XRM.Application._2_ViewModels._20_Sistema
{
    public class vmdSISDEPARTA
    {
        [Key]
        public int TBSISDEPARTA_NS { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string TBSISDEPARTA_NM { get; set; }

        [DisplayName("Descrição")]
        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres")]
        public string TBSISDEPARTA_DS { get; set; }

        [DisplayName("Data cadastro")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime TBSISDEPARTA_DT_CAD { get; set; }

        [DisplayName("Data inativo")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime? TBSISDEPARTA_DT_INA { get; set; }

        public virtual IEnumerable<TBSISEQUIPEX> EQUIPEXXXX { get; set; }

        public int? TBSISEMPRESA_NS { get; set; }

        public virtual TBSISEMPRESA TBSISEMPRESA { get; set; }
    }
}
