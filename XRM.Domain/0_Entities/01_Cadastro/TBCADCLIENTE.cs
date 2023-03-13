using System;
using System.Collections.Generic;
using XRM.Domain._0_Entities._04_Cobranca;

namespace XRM.Domain._0_Entities._01_Cadastro
{
    /*
     * tabela de cadastro do cliente
     */
    public class TBCADCLIENTE
    {
        public int TBCLIENTEXXX_NS { get; set; }

        public string TBCLIENTEXXX_NM { get; set; }

        public Int64 TBCADCLIENTE_CPF_CNPJ { get; set; }

        public string TBCLIENTEXXX_DS { get; set; }

        public DateTime TBCLIENTEXXX_DT_CAD { get; set; }

        public DateTime TBCLIENTEXXX_DT_INA { get; set; }

        /* Data de atualização do cadastro do cliente*/
        public DateTime? TBCLIENTEXXX_DT_ATU { get; set; }

        public virtual IEnumerable<TBCADEMAILXX> TBCADEMAILXX { get; set; }

        public virtual IEnumerable<TBCADENDEREC> TBCADENDEREC { get; set; }

        public virtual IEnumerable<TBCADTELEFON> TBCADTELEFON { get; set; }

        public virtual IEnumerable<TBCOBCONTRAT> TBCOBCONTRAT { get; set; }
    }
}
