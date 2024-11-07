using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolmnurk
{
    public partial class Kolmnurk_vorm : Form
    {
        double a = 0, b = 0, c = 0, d=0, h = 0;
        Triangle t;
        Nelinurk n;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public Kolmnurk_vorm()
        {
            InitializeComponent();
            A_txt.Text = "0";
            B_txt.Text = "0";
            C_txt.Text = "0";
            D_txt.Text = "0";
            H_txt.Text = "0";
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(A_txt.Text);
            b = Convert.ToDouble(B_txt.Text);
            c = Convert.ToDouble(C_txt.Text);
            d = Convert.ToDouble(D_txt.Text);
            h = Convert.ToDouble(H_txt.Text);
            double S,P;
            if (a!=0 && b!=0 && c!=0 && d==0 && h==0)
            {
                t = new Triangle(a, b, c);
                S=t.Area();
                P=t.Perimeter();
                start_btn.Text = P.ToString();
            }
            else if (a != 0 && b == 0 && c == 0 && d==0 && h != 0)
            {
                t = new Triangle(h, a);
                S = t.Area();
                start_btn.Text = "S="+S.ToString();
                
            }
            else if (a != 0 && b != 0 && c != 0 && d != 0 && h == 0)
            {
                n=new Nelinurk(a,b,c,d);
                S=n.Area();
                P = n.Perimeter();
                start_btn.Text = P.ToString();
            }

            /*lv.Items.Add("Külg A");
            lv.Items[0].SubItems.Add(t.OutputA());
            lv.Items.Add("Külg B");
            lv.Items[1].SubItems.Add(t.OutputB());
            lv.Items.Add("Külg C");
            lv.Items[2].SubItems.Add(t.OutputC());
            lv.Items.Add("Kõrgus");
            lv.Items[3].SubItems.Add(t.OutputH());*/
            
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
