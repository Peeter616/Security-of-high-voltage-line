using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZabLiniiSN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Zwarciowe zwr;
        Zwloczne zwl;
        int kb;
        int kr;
        int kp;

        private void buttonZabZwloczne_Click(object sender, EventArgs e)
        {

            //włączanie panelu zabezpieczenia zwłocznego

            buttonZabZwloczne.Enabled = false;
            groupBoxKb1.Enabled = true;
            groupBoxKr.Enabled = true;
            groupBoxKp.Enabled = true;
            labelPrzekladnia.Enabled = true;
            numericUpDownPrzekladnia.Enabled = true;
            labelIMax.Enabled = true;
            numericUpDownIMax.Enabled = true;
            buttonOblicz1.Enabled = true;
            labelOblWarNast2.Enabled = true;
            textBoxWynik1.Enabled = true;
            buttonKoniecObl1.Enabled = true;
            radioButtonZabZwloczne12.Checked = true;
            radioButtonKr1.Checked = true;
            radioButtonKp098.Checked = true;

            //wylaczanie panelu zabezpieczenia zwarciowego

            buttonZabZwar.Enabled = true;
            groupBoxKb2.Enabled = false;
            labelPrzek2.Enabled = false;
            numericUpDownPrzekladnia2.Enabled = false;
            labelIkMax.Enabled = false;
            numericUpDownIkMax.Enabled = false;
            buttonOblicz2.Enabled = false;
            labelOblNast2.Enabled = false;
            textBoxWynik2.Enabled = false;
            buttonKoniec2.Enabled = false;

        }

        private void buttonZabZwar_Click(object sender, EventArgs e)
        {

            //włączanie panelu zabezpieczenia zwarciowego

            buttonZabZwar.Enabled = false;
            groupBoxKb2.Enabled = true;
            labelPrzek2.Enabled = true;
            numericUpDownPrzekladnia2.Enabled = true;
            labelIkMax.Enabled = true;
            numericUpDownIkMax.Enabled = true;
            buttonOblicz2.Enabled = true;
            labelOblNast2.Enabled = true;
            textBoxWynik2.Enabled = true;
            buttonKoniec2.Enabled = true;
            radioButtonZwarKb14.Checked = true;

            //wylaczanie panelu Zabezpieczenia zwłocznego

            buttonZabZwloczne.Enabled = true;
            groupBoxKb1.Enabled = false;
            groupBoxKr.Enabled = false;
            groupBoxKp.Enabled = false;
            labelPrzekladnia.Enabled = false;
            numericUpDownPrzekladnia.Enabled = false;
            labelIMax.Enabled = false;
            numericUpDownIMax.Enabled = false;
            buttonOblicz1.Enabled = false;
            labelOblWarNast2.Enabled = false;
            textBoxWynik1.Enabled = false;
            buttonKoniecObl1.Enabled = false;

        }

        private void buttonOblicz1_Click(object sender, EventArgs e)
        {

            zwl = new Zwloczne(Convert.ToDouble(numericUpDownIMax.Value), Convert.ToDouble(numericUpDownPrzekladnia.Value)); //tworzenie zwarcia

            //sprawdzanie parametrów

            if (radioButtonZwloczne11.Checked == true)
                kb = 1;
            else
                kb = 2;

            if (radioButtonKr2.Checked == true)
                kr = 2;
            else if (radioButtonKr3.Checked == true)
                kr = 3;
            else if (radioButtonKr4.Checked == true)
                kr = 4;
            else
                kr = 1;

            if (radioButtonKp095.Checked == true)
                kp = 1;
            else
                kp = 2;

            //sprawdzanie parametrów

            textBoxWynik1.Text = Convert.ToString(zwl.obliczZabNadZwl(kb, kr, kp).ToString("#.##")); //wyświetlanie wyniku

        }

        private void buttonKoniecObl1_Click(object sender, EventArgs e)
        {

            //wylaczanie panelu zabezpieczenia zwarciowego

            buttonZabZwloczne.Enabled = true;
            groupBoxKb1.Enabled = false;
            groupBoxKr.Enabled = false;
            groupBoxKp.Enabled = false;
            labelPrzekladnia.Enabled = false;
            numericUpDownPrzekladnia.Enabled = false;
            labelIMax.Enabled = false;
            numericUpDownIMax.Enabled = false;
            buttonOblicz1.Enabled = false;
            labelOblWarNast2.Enabled = false;
            textBoxWynik1.Enabled = false;
            buttonKoniecObl1.Enabled = false;

        }

        private void buttonOblicz2_Click(object sender, EventArgs e)
        {

            zwr = new Zwarciowe(Convert.ToDouble(numericUpDownIkMax.Value), Convert.ToDouble(numericUpDownPrzekladnia2.Value));

            //sprawdzanie parametrów

            if (radioButtonZwar12.Checked == true)
            {
                kb = 1;
            }
            else if (radioButtonZwarKb13.Checked == true)
            {
                kb = 2;
            }
            else if (radioButtonZwarKb15.Checked == true)
            {
                kb = 4;
            }
            else if (radioButtonZwarKb16.Checked == true)
            {
                kb = 5;
            }
            else
                kb = 3;

            //sprawdzanie parametrów

            textBoxWynik2.Text = Convert.ToString(zwr.obliczZabNadZwarc(kb).ToString("#.##")); //wyświetlanie wyniku

        }

        private void buttonKoniec2_Click(object sender, EventArgs e)
        {

            //wylaczanie panelu Zabezpieczenia zwłocznego

            buttonZabZwar.Enabled = true;
            groupBoxKb2.Enabled = false;
            labelPrzek2.Enabled = false;
            numericUpDownPrzekladnia2.Enabled = false;
            labelIkMax.Enabled = false;
            numericUpDownIkMax.Enabled = false;
            buttonOblicz2.Enabled = false;
            labelOblNast2.Enabled = false;
            textBoxWynik2.Enabled = false;
            buttonKoniec2.Enabled = false;

        }
    }
}