using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorKcal
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public void mezczyzna_CheckedChanged(object sender, EventArgs e)
        {
            if (mezczyzna.Checked)
            {
                kobieta.Checked = false;
            }
        }

        public void kobieta_CheckedChanged(object sender, EventArgs e)
        {
            if (kobieta.Checked)
            {
                mezczyzna.Checked = false;
            }
        }

        public void wiek_ValueChanged(object sender, EventArgs e)
        {
            
        }
        public void waga_ValueChanged(object sender, EventArgs e)
        {
           
        }
        public void wzrost_ValueChanged(object sender, EventArgs e)
        {
            
        }
        public void kcal_ValueChanged(object sender, EventArgs e)
        {
            
        }

        public void przycisk_bmi_Click(object sender, EventArgs e)
        {
            
        }
    }

    public partial class Form1
    {
        private void Kalkulator()
        {
           
        }



        public virtual void BMI()
        {
          double a, b, c, d, e;
        //string przycisk;
             a = decimal.ToDouble(wzrost.Value);
             b = Math.Pow(a, 0.1);
             c = decimal.ToDouble(waga.Value);             
             d = (b * b);
             e = (c / d);
            //przycisk = ();

            if (e == 0) 
            {
                MessageBox.Show("Twoje BMI wynosi: " + e);
            }

        }
        
    }

}