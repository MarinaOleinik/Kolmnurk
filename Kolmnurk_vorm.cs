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
        public Kolmnurk_vorm()
        {
            InitializeComponent();
            
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            
            double a, b, c;
            a = Convert.ToDouble(A_txt.Text);
            b = Convert.ToDouble(B_txt.Text);
            c = Convert.ToDouble(C_txt.Text);
            Triangle t= new Triangle(a,b,c);
            lv.Items.Add("Külg A");
            lv.Items[0].SubItems.Add(t.OutputA());
            lv.Items.Add("Külg B");
            lv.Items[1].SubItems.Add(t.OutputB());
            lv.Items.Add("Külg C");
            lv.Items[2].SubItems.Add(t.OutputC());

        }
    }
}
