using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    public class Zadanie
    {
        public string pyt;
        public float pkt;
        public float totalPoints;
        public int znacznik;
        public virtual bool sprPyt(string odp) { return false; }
        public virtual void stworzPanel() { }
    }
}
