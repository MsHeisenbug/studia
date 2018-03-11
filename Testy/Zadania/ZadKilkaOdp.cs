using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    public class ZadKilkaOdp : Zadanie
    {
        public string[] odp;
        protected string[] popr;
        public ZadKilkaOdp(string tresc, string[] odpowiedzi, string[] poprawne)
        {
            this.pyt = tresc;
            this.odp = odpowiedzi;
            this.popr = poprawne;
            this.pkt = popr.Count() * 0.5F;
            this.totalPoints = this.pkt;
            this.znacznik = 2;
        }

        public override bool sprPyt(string podaneOdp)
        {
            char[] separator = { '|' };
            string[] podaneOdpArray = podaneOdp.Split(separator);

            bool poprawnosc = false;

            for(int i=0; i< popr.Length; i++)
            {
                bool flagFound = false;
                for (int j = 0; j < podaneOdpArray.Length; j++)
                {
                    if(popr[i] == podaneOdpArray[j])
                    {
                        poprawnosc = true;
                        flagFound = true;
                        break;
                    }
                }
                if(flagFound == false)
                {
                    this.pkt -= 0.5F;
                }
            }

            return poprawnosc;
        }
    }
}

