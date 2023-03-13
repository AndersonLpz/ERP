using System;

namespace XRM.Domain._0_Entities._04_Cobranca
{
    /*
     * Tabela de cadastro do calculo da divida.
     */
    public class TBCOBDIVCALC
    {
        public int TBCOBCONTRAT_NS { get; set; }

        public int TBCOBDIVIDAX_NS { get; set; }

        public virtual TBCOBDIVIDAX TBCOBDIVIDAX { get; set; }

        /* Data da Divida. */
        public DateTime TBCOBDIVCALC_DT_DIV { get; set; }

        /* Data de atualização do calculo da divida. */
        public DateTime TBCOBDIVCALC_DT_ATU { get; set; }

        /* Quantidade de dias de atraso da divida. */
        public int TBCOBDIVCALC_QNT_DIAS { get; set; }

        public decimal TBCOBDIVCALC_VL { get; set; }

        public decimal TBCOBDIVCALC_VL_AT { get; set; }

        /* Valor do desconto sobre o valor atualizado*/
        public decimal TBCOBDIVCALC_VL_AT_DESC { get; set; }

        public decimal TBCOBDIVCALC_VL_JUROS { get; set; }

        /* Valor de desconto sobre o juros. */
        public decimal TBCOBDIVCALC_VL_JUROS_DESC { get; set; }

        public decimal TBCOBDIVCALC_VL_MULTA { get; set; }

        /* Valor de desconto sobre a multa. */
        public decimal TBCOBDIVCALC_VL_MULTA_DESC { get; set; }

        /* Valor que foi pago da divida*/
        public decimal TBCOBDIVCALC_VL_PAGO { get; set; }

        /* Saldo devedor da divida. */
        public decimal TBCOBDIVCALC_VL_SALDO_DEV { get; set; }


    }
}
