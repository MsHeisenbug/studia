using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadania;

namespace TestyWF.Wizualizatory
{
    public class WizJednaOdp : Wizualizator
    {
        RadioButton[] r;

        public WizJednaOdp(ZadJednaOdp z)
        {
            p = new Panel();
            p.Size = new Size(450, 300);
            r = new RadioButton[z.odp.Count()];
            l = new Label();
            l.Text = z.pyt;

            for (int j = 0; j < z.odp.Count(); j++)
            {
                r[j] = new RadioButton();
                r[j].Text = z.odp[j];
            }
        }


        public override string pobierzOdp()
        {
            for(int i=0; i<r.Count(); i++)
            {
                if(r[i].Checked)
                {
                    return r[i].Text;
                }
            }

            return string.Empty;
        }

        public override void wypelnijPanel()
        {
            int odl = 20;
            l.Location = new Point(10, 10);
            l.Size = new Size(400, odl);
            p.Controls.Add(l);

            for (int i=0; i<r.Count(); i++)
            {
                r[i].Location = new Point(10, odl + 20);
                r[i].Size = new Size(300, 25);
                odl += 20;
                p.Controls.Add(r[i]);
                
            }
        }
    }
}
