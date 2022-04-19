using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeningWeekend
{
    public class OpeningWeekend
    {
        public string eredetiCim;
        public string magyarCim;
        public string bemutato;
        public string forgalmazo;
        public int bevel;
        public int latogato;
        public OpeningWeekend(string eredetiCim, string magyaCim, string bemuato, string forgalmazo, int bevel, int latogato) 
        { 
            this.eredetiCim = eredetiCim;
            this.magyarCim = magyaCim;
            this.bemutato = bemuato;
            this.forgalmazo = forgalmazo;
            this.bevel = bevel;
            this.latogato = latogato;

        }
    }
}
