using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRM.Domain._0_Entities._00_Sistema
{
    /*
     * Tabela de permissao do usuario ao sistema
     */
    public class TBSISUSPESIS
    {
        public int TBSISUSPESIS_NS { get; set; }

        public DateTime TBSISUSPESIS_DT_CAD { get; set; }

        public DateTime TBSISUSPESIS_DT_INA { get; set; }
        
        public int TBSISUSUARIO_NS { get; set; }

        public virtual TBSISUSUARIO TBSISUSUARIO { get; set; }

        public int TBSISTEMAXXX_NS { get; set; }

        public virtual TBSISTEMAXXX TBSISTEMAXXX { get; set; }
    }
}
