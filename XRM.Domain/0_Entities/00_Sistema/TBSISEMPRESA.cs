using System;
using System.Collections.Generic;
using XRM.Domain._0_Entities._01_Cadastro;

namespace XRM.Domain._0_Entities._00_Sistema
{
    /*
     * tabela de cadastro de empresa
     */
    public class TBSISEMPRESA
    {
        public int TBSISEMPRESA_NS { get; set; }

        public string TBSISEMPRESA_NM { get; set; }

        public string TBSISEMPRESA_NM_FANTASIA { get; set; }

        public string TBSISEMPRESA_DS { get; set; }

        public DateTime TBSISEMPRESA_DT_CAD { get; set; }

        public DateTime? TBSISEMPRESA_DT_INA { get; set; }

        public Int64 TBSISEMPRESA_CPF_CNPJ { get; set; }

        public virtual IEnumerable<TBCADENDEREC> TBCADENDEREC { get; set; }
    }
}
