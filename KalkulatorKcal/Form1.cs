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
        public double Waga { get; set; }

        public double Wzrost { get; set; }

        public double Wiek { get; set; }

        public double Kcal { get; set; }

        public double Pal { get; set; }


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
            double wik;
            wik = decimal.ToDouble(wiek.Value);
            Wiek = wik;
        }
        public void waga_ValueChanged(object sender, EventArgs e)
        {
            double wag;
            wag = decimal.ToDouble(waga.Value);
            Waga = wag;
        }
        public void wzrost_ValueChanged(object sender, EventArgs e)
        {
            double wzr1, wzr2;
            wzr1 = decimal.ToDouble(wzrost.Value);
            wzr2 = Math.Pow(wzr1, 0.1);
            Wzrost = wzr2;
        }
        public void kcal_ValueChanged(object sender, EventArgs e)
        {
            double kcl;
            kcl = decimal.ToDouble(kcal.Value);
            Kcal = kcl;
        }

        private void pal_ValueChanged(object sender, EventArgs e)
        {
            double pal1, pal2;
            pal1 = decimal.ToDouble(pal.Value);
            pal2 = pal1 * 0.1;            
            Pal = pal2;
        }

        public void przycisk_bmi_Click(object sender, EventArgs e)
        {
            var kalkulator = new Kalkulator();
            var wynikBMI = kalkulator.BMI_Metoda(Waga, Wzrost);

            MessageBox.Show("Twoje BMI wynosi: " + Math.Round(wynikBMI, 2));
        }

        private void bmr_Click(object sender, EventArgs e)
        {
            var kalkulator = new Kalkulator();
            var wynikBMRmezczyzna = kalkulator.DEFICYT_Mezczyzna_Metoda(Waga, Wzrost, Wiek, Pal);
            var wynikBMRkobieta = kalkulator.DEFICYT_Kobieta_Metoda(Waga, Wzrost, Wiek, Pal);

            if (mezczyzna.Checked is true)
            {
                MessageBox.Show("BMR wynosi: " + Math.Round(wynikBMRmezczyzna, 2));
            }
            else
            {
                MessageBox.Show("BMR wynosi: " + Math.Round(wynikBMRkobieta, 2));
            }
        }

        private void przytyc_Click(object sender, EventArgs e)
        {
            if (kobieta.Checked is true)
            {

            }
            else
            {

            }
        }
               
    }

    public class Kalkulator : Form1
    {

        public Kalkulator()
        {
        }

        public double BMI_Metoda(double waga, double wzrost)
        {
            var bmiWynik = waga / (wzrost * wzrost);
            return bmiWynik;
        }

        public double DEFICYT_Mezczyzna_Metoda(double waga, double wzrost, double wiek, double pal)
        {
            var deficytMezczyzna = 66 + (13.7 * waga) + (5 * wzrost) - (6.8 * wiek) * pal;
            return deficytMezczyzna;
        }

        public double DEFICYT_Kobieta_Metoda(double waga, double wzrost, double wiek, double pal)
        {
            var deficytMezczyzna = 655 + (9.6 * waga) + (1.8 * wzrost) - (4.7 * wiek) * pal;
            return deficytMezczyzna;
        }
        
        public double WZROST_Metoda(double waga, double wzrost)
        {
            var bmiWynik = waga / (wzrost * wzrost);
            return bmiWynik;
        }

    }

}     