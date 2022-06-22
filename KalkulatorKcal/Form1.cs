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
            double wzr1, wzr2, wag, wzr3, bmi;
            wzr1 = decimal.ToDouble(wzrost.Value);
            wzr2 = Math.Pow(wzr1, 0.1);
            wag = decimal.ToDouble(waga.Value);
            wzr3 = (wzr2 * wzr2);
            bmi = (wag / wzr3);
            MessageBox.Show("Twoje BMI wynosi: " + Math.Round(bmi, 2));
        }
    }

    public partial class Kalkulator : Form1
    {
      
    }

}