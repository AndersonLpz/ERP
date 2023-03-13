using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRM.Domain._0_Entities._04_Cobranca
{
    /*
     * Tabela de cadastro do tipo de campo do detalhe
     * 1 - String
     * 2 - Decimal
     * 3 - Data
     * 4 - Inteiro
     */
    public class TBCOBDETTPCP
    {
        public int TBCOBDETTPCP_NS { get; set; }

        public string TBCOBDETTPCP_NM { get; set; }

        public string TBCOBDETTPCP_DS { get; set; }

        public DateTime TBCOBDETTPCP_DT_CAD { get; set; }

        public DateTime? TBCOBDETTPCP_DT_INA { get; set; }

    }
}
