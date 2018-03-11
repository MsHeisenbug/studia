using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zadania
{
    public class ZadJednaOdp : Zadanie
    {
        public string[] odp;
        protected string popr;
        

        public ZadJednaOdp(string tresc, string[] odpowiedzi, string poprawna)
        {
            this.pyt = tresc;
            this.odp = odpowiedzi;
            this.popr = poprawna;
            this.pkt = 1;
            this.totalPoints = 1;
            this.znacznik = 1;
        }

        public override bool sprPyt(string podanaOdp)
        {
            if (podanaOdp == this.popr)
                return true;
            else
            {
                this.pkt = 0;
                return false;
            }
        }
    }
}
