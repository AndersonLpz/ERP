using System;
using XRM.Domain._0_Entities._00_Sistema;

namespace XRM.Domain._0_Entities._01_Cadastro
{
    /*
     * tabela de cadastro de email
     */
    public class TBCADEMAILXX
    {
        public int TBCADEMAILXX_NS { get; set; }

        public string TBCADEMAILXX_NM { get; set; }

        public string TBCADEMAILXX_DS { get; set; }

        /* Email preferencial S = true / N = false */
        public bool TBCADEMAILXX_PREF { get; set; }

        public DateTime TBCADEMAILXX_DT_CAD { get; set; }

        public DateTime? TBCADEMAILXX_DT_INA { get; set; }

        public int? TBSISUSUARIO_NS { get; set; }

        public virtual TBSISUSUARIO TBSISUSUARIO { get; set; }

        public int? TBCLIENTEXXX_NS { get; set; }

        public virtual TBCADCLIENTE TBCADCLIENTE { get; set; }

        public int? TBSISEMPRESA_NS { get; set; }

        public virtual TBSISEMPRESA TBSISEMPRESA { get; set; }
    }
}
