using System;
using XRM.Domain._0_Entities._00_Sistema;

namespace XRM.Domain._0_Entities._01_Cadastro
{
    /*
     * tabela de cadastro de endereço
     */
    public class TBCADENDEREC
    {
        public int TBCADENDEREC_NS { get; set; }

        public string TBCADENDEREC_NM { get; set; }

        public string TBCADENDEREC_DS { get; set; }

        public int TBCADENDEREC_NU { get; set; }

        public string TBCADENDEREC_COMPLEMENTO { get; set; }

        public int TBCADENDEREC_CEP { get; set; }
        
        public string TBCADENDEREC_CIDADE { get; set; }

        public string TBCADENDEREC_UF { get; set; }

        /* Endereço preferencial S = true / N = false */
        public bool TBCADENDEREC_PREF { get; set; }

        public DateTime TBCADENDEREC_DT_CAD { get; set; }

        public DateTime? TBCADENDEREC_DT_INA { get; set; }

        public int? TBSISUSUARIO_NS { get; set; }

        public virtual TBSISUSUARIO TBSISUSUARIO { get; set; }

        public int? TBCLIENTEXXX_NS { get; set; }

        public virtual TBCADCLIENTE TBCADCLIENTE { get; set; }

        public int? TBSISEMPRESA_NS { get; set; }

        public virtual TBSISEMPRESA TBSISEMPRESA { get; set; }

    }
}
