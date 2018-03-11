using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    public class ZadZTekst : Zadanie
    {
        protected string popr;
        public ZadZTekst(string tresc, string poprawna)
        {
            this.pyt = tresc;
            
            this.popr = poprawna;
            this.pkt = 1.5F;
            this.totalPoints = 1.5F;
            this.znacznik = 4;
        }

        public override bool sprPyt(string podanaOdp)
        {
            if (podanaOdp.ToLower() == this.popr.ToLower())
                return true;
            else
            {
                this.pkt = 0;
                return false;
            }
        }
    }
}

