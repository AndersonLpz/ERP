using System;
using XRM.Domain._0_Entities._00_Sistema;

namespace XRM.Domain._0_Entities._01_Cadastro
{
    /*
     * tabela de cadastro de telefone
     */
    public class TBCADTELEFON
    {
        public int TBCADTELEFON_NS { get; set; }

        public int TBCADTELEFON_NUM { get; set; }

        public int TBCADTELEFON_DDD { get; set; }

        /* Telefone preferencial S = true / N = false */
        public bool TBCADTELEFON_PREF { get; set; }

        public DateTime TBCADTELEFON_DT_CAD { get; set; }

        public DateTime? TBCADTELEFON_DT_INA { get; set; }

        public int TBCADTELEFTP_NS { get; set; }

        public virtual TBCADTELEFTP TBCADTELEFTP { get; set; }

        public int? TBSISUSUARIO_NS { get; set; }

        public virtual TBSISUSUARIO TBSISUSUARIO { get; set; }

        public int? TBCLIENTEXXX_NS { get; set; }

        public virtual TBCADCLIENTE TBCADCLIENTE { get; set; }

        public int? TBSISEMPRESA_NS { get; set; }

        public virtual TBSISEMPRESA TBSISEMPRESA { get; set; }
    }
}
