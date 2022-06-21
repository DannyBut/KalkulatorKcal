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
                //MessageBox.Show("Tak");
            }           
        }

        public void kobieta_CheckedChanged(object sender, EventArgs e)
        {
            if (kobieta.Checked)
            {
                mezczyzna.Checked = false;
                //MessageBox.Show("hHm, woman");
            } 
        }

        public void wiek_ValueChanged(object sender, EventArgs e)
        {
               //MessageBox.Show("Robi wrażenie"); 
        }
        public void waga_ValueChanged(object sender, EventArgs e)
        {
            if (waga.Value >= 120)
            {
               // MessageBox.Show("Oj dużo dużo");
            }
        }   
        private void wzrost_ValueChanged(object sender, EventArgs e)
        {
            double a, b, c, d;
            
            a = decimal.ToDouble(wzrost.Value);
            b = Math.Pow(a, 0.1);
            c = decimal.ToDouble(waga.Value);
            d = (b * b);
            
            MessageBox.Show("Twoje BMI wynosi: " + (c / d));
        }
        private void kcal_ValueChanged(object sender, EventArgs e)
        {

        }
        public void Kalkulator()
        {
           
        }

       
    }
}

