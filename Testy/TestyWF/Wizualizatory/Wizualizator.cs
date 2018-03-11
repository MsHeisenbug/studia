using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestyWF.Wizualizatory
{

    public abstract class Wizualizator
    {
        public Label l;
        public Panel p;
        public abstract void wypelnijPanel();

        public abstract string pobierzOdp();
    }
}
