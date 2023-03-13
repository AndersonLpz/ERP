using System;
using System.Collections.Generic;

namespace XRM.Domain._0_Entities._00_Sistema
{
    /*
     * tabela de cadastro do departamento
     */
    public class TBSISDEPARTA
    {
        public int TBSISDEPARTA_NS { get; set; }

        public string TBSISDEPARTA_NM { get; set; }

        public string TBSISDEPARTA_DS { get; set; }

        public DateTime TBSISDEPARTA_DT_CAD { get; set; }

        public DateTime? TBSISDEPARTA_DT_INA { get; set; }

        public virtual IEnumerable<TBSISEQUIPEX> EQUIPEXXXX { get; set; }

        public int? TBSISEMPRESA_NS { get; set; }

        public virtual TBSISEMPRESA TBSISEMPRESA { get; set; }
    }
}
