using System;

namespace XRM.Domain._0_Entities._00_Sistema
{
    public class TBSISUSPEMOD
    {
        /*
         * Tabela de permissao de usuarios ao modulo.
         */
        public int TBSISUSPEMOD_NS { get; set; }

        public string TBSISUSPEMOD_NM { get; set; }

        public string TBSISUSPEMOD_DS { get; set; }

        public DateTime TBSISUSPEMOD_DT_CAD { get; set; }

        public DateTime TBSISUSPEMOD_DT_INA { get; set; }

        /* Permissao ao modulo S = True / N = false */
        public bool TBSISUSPEMOD_PERM { get; set; }

        public int TBSISUSUARIO_NS { get; set; }

        public virtual TBSISUSUARIO TBSISUSUARIO { get; set; }

        public int TBSISMODULOX_NS { get; set; }

        public virtual TBSISMODULOX TBSISMODULOX { get; set; }
    }
}