using System;

namespace XRM.Domain._0_Entities._04_Cobranca
{
    /*
     * tabela de cadastro de status da Divida e Contrato
     * Negociado
        Distribuído
        Acionado
        Pago
        Devolvido
        Parcialmente Negociado
     */
    public class TBCOBSTATUSX
    {
        public int TBCOBSTATUSX_NS { get; set; }

        public string TBCOBSTATUSX_NM { get; set; }

        public string TBCOBSTATUSX_DS { get; set; }

        public DateTime TBCOBSTATUSX_DT_CAD { get; set; }

        public DateTime? TBCOBSTATUSX_DT_INA { get; set; }
    }
}
