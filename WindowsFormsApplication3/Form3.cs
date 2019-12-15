using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Rice r = new Rice();
        oil o = new oil();
        Meat M = new Meat();
        sugar s = new sugar();
        Pasta p = new Pasta();
        fish f = new fish();
        Chicken c = new Chicken();
        Milk m = new Milk();
        Water w = new Water();
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (RiceAdd.Text == "" || meatadd.Text == "" || milkadd.Text == "" || fishadd.Text == "" || chickenadd.Text == "" || meatadd.Text == "" || sugaradd.Text == "" || pastaadd.Text == "")
            {
                MessageBox.Show("please fill all textboxs");
            }
            else
            {
                //countof (property of class) /////////////////count() method to return count of object//
                r.Countof = int.Parse(RiceAdd.Text);
                o.Countof = int.Parse(oiladd.Text);
                M.Countof = int.Parse(meatadd.Text);
                s.Countof = int.Parse(sugaradd.Text);
                p.Countof = int.Parse(pastaadd.Text);
                f.Countof = int.Parse(fishadd.Text);
                c.Countof = int.Parse(chickenadd.Text);
                m.Countof = int.Parse(milkadd.Text);
                w.Countof = int.Parse(wateradd.Text);
                MessageBox.Show("All products are uploaded");
            }
        }     
        private void Gotoform2(object sender, EventArgs e)
        {
            this.Hide();
            Form2 a = new Form2();
            a.Show();
        }

        private void show_stock_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void showquantitybtn_Click(object sender, EventArgs e)
        {
            RiceAdd.Text = Convert.ToString(r.Count());
            oiladd.Text = Convert.ToString(o.Count());
            milkadd.Text = Convert.ToString(m.Count());
            sugaradd.Text = Convert.ToString(s.Count());
            fishadd.Text = Convert.ToString(f.Count());
            meatadd.Text = Convert.ToString(M.Count());
            wateradd.Text = Convert.ToString(w.Count());
            pastaadd.Text = Convert.ToString(p.Count());
            chickenadd.Text = Convert.ToString(c.Count());
        }
    }
}
