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
    public class WizKilkaOdp : Wizualizator
    {

        CheckBox[] ch;
    

        public WizKilkaOdp(ZadKilkaOdp z)
        {
            ch = new CheckBox[z.odp.Count()];
            p = new Panel();
            p.Size = new Size(450, 300);
            l = new Label();
            l.Text = z.pyt;

            for (int j = 0; j < z.odp.Count(); j++)
            {
                ch[j] = new CheckBox();
                ch[j].Text = z.odp[j];
            }

        }

        public override string pobierzOdp()
        {
            string retString = string.Empty;

            for (int i = 0; i < ch.Count(); i++)
            {
                if (ch[i].Checked)
                {
                    retString += ch[i].Text + "|";
                }
            }

            if(retString.Length > 0)
            {
                retString = retString.Substring(0, retString.Length - 1); // usuniecie ostatniego "|"
            }

            return retString;
        }

        public override void wypelnijPanel()
        {
            int odl = 20;
            l.Location = new Point(10, 10);
            l.Size = new Size(400, odl);
            p.Controls.Add(l);

            for (int i = 0; i < ch.Count(); i++)
            {
                ch[i].Location = new Point(10, odl + 20);
                ch[i].Size = new Size(400, 25);
                odl += 20;
                p.Controls.Add(ch[i]);
                
            }

            p.Visible = true;
        }
    }
}
