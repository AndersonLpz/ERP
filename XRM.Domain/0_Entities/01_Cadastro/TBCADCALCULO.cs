using System;

namespace XRM.Domain._0_Entities._01_Cadastro
{
    /*
    * tabela de cadastro das regras de calculo do cedente.
    */
    public class TBCADCALCULO
    {
        public int TBCADCALCULO_NS { get; set; }

        public DateTime TBCADCALCULO_DT_CAD { get; set; }

        public DateTime? TBCADCALCULO_DT_INA { get; set; }

        /* Faixa de atraso*/
        public int? TBCADCALCULO_FX_ATRASO { get; set; }

        /* Periodo de atraso*/
        public DateTime? TBCADCALCULO_DT_ATRASO { get; set; }

        /* Valor de atraso */
        public decimal? TBCADCALCULO_VR_ATRASO { get; set; }

        #region TBCEDETPCALC

        /*
         *  Tabela de cadastro do tipo de calculo do Cedente
         *  1 - Faixa de Atraso
         *  2 - Periodo de Atraso
         *  3 - Valor de Atraso
         */
        public int TBCADCALTIPO_NS { get; set; }

        public virtual TBCADCALTIPO TBCADCALTIPO { get; set; }

        #endregion TBCEDETPCALC

        #region TBCEDENTEXXX

        public int TBCADCEDENTE_NS { get; set; }

        public virtual TBCADCEDENTE TBCADCEDENTE { get; set; }

        #endregion TBCEDENTEXXX
    }
}