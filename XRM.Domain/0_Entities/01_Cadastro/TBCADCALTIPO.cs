using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRM.Domain._0_Entities._01_Cadastro
{
    /*
     *  Tabela de cadastro do tipo de calculo do Cedente
     *  1 - Faixa de Atraso
     *  2 - Periodo de Atraso
     *  3 - Valor de Atraso
     */
    public class TBCADCALTIPO
    {
        public int TBCADCALTIPO_NS { get; set; }

        public string TBCADCALTIPO_NM { get; set; }

        public string TBCADCALTIPO_DS { get; set; }

        public DateTime TBCADCALTIPO_DT_CAD { get; set; }

        public DateTime? TBCADCALTIPO_DT_INA { get; set; }
    }
}
