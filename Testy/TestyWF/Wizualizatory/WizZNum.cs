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
    public class WizZNum : Wizualizator
    {
        TextBox t;
         public WizZNum(ZadZNum z)
        {
            l = new Label();
            l.Text = z.pyt;
            p = new Panel();
            p.Size = new Size(450, 300);
            t = new TextBox();
        }

        public override string pobierzOdp()
        {
            return t.Text;
        }

        public override void wypelnijPanel()
        {
            int odl = 20;
            l.Location = new Point(10, 10);
            l.Size = new Size(400, odl);
            p.Controls.Add(l);
            t.Location = new Point(10, odl + 20);
            p.Controls.Add(t);
            p.Visible = true;
        }
    }
}
