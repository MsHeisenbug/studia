using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    public class ZadZNum : Zadanie
    {
        int popr;

        public ZadZNum(string tresc, int poprawna)
        {
            this.pyt = tresc;
            this.popr = poprawna;
            this.pkt = 1.5F;
            this.totalPoints = 1.5F;
            this.znacznik = 3;
        }

        public override bool sprPyt(string podaneOdp)
        {
            if (Convert.ToString(popr) == podaneOdp)
                return true;
            else
            {
                this.pkt = 0;
                return false;
            }

        }
    }
}
