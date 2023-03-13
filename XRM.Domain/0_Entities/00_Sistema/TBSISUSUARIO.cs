using System;
using System.Collections.Generic;

namespace XRM.Domain._0_Entities._00_Sistema
{
    /*
     * Tabela de cadastro de usuario do sistema
     */
    public class TBSISUSUARIO
    {
        public int TBSISUSUARIO_NS { get; set; }

        public string TBSISUSUARIO_NM { get; set; }

        public decimal TBSISUSUARIO_CPF_CNPJ { get; set; }

        public DateTime TBSISUSUARIO_DT_CAD { get; set; }

        public DateTime? TBSISUSUARIO_DT_INA { get; set; }

        public int TBSISUSUPERF_NS { get; set; }

        public virtual TBSISUSUPERF TBSISUSUPERF { get; set; }

        public int TBSISDEPARTA_NS { get; set; }

        public virtual TBSISDEPARTA TBSISDEPARTA { get; set; }

        public virtual IEnumerable<TBSISUSPEMOD> TBSISUSPEMOD { get; set; }

    }
}
