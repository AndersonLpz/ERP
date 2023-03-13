using System;

namespace XRM.Domain._0_Entities._01_Cadastro
{
    /*
    * tabela de cadastro do cedente
    */
    public class TBCADCEDENTE
    {
        public int TBCADCEDENTE_NS { get; set; }

        public string TBCADCEDENTE_NM { get; set; }

        public string TBCADCEDENTE_DS { get; set; }

        public decimal TBCADCEDENTE_CPF_CNPJ { get; set; }

        public DateTime TBCADCEDENTE_DT_CAD { get; set; }

        public DateTime? TBCADCEDENTE_DT_INA { get; set; }

    }
}
