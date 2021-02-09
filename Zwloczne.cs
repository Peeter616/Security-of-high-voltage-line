using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZabLiniiSN
{
    class Zwloczne : ZabezpieczeineNadpradowe
    {
        double kb;
        double kr;
        double kp;

        public Zwloczne(double IMax, double Przek) : base(IMax, Przek) //konstruktor domyślny
        { }

        /// <summary>
        /// metody dodatkowe dla klasy
        /// </summary>

        void nastawKr(int kr)
        {
            switch (kr)
            {
                case 1:
                    this.kr = 1;
                    break;
                case 2:
                    this.kr = 2;
                    break;
                case 3:
                    this.kr = 3;
                    break;
                case 4:
                    this.kr = 4;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Nie wybrano współczynnika Kr. Domyślnie zostanie przypisana wartość 1");
                    this.kr = 1;
                    break;
            }
        }

        void nastawKp(int kp)
        {
            switch (kp)
            {
                case 1:
                    this.kp = 0.95;
                    break;
                case 2:
                    this.kp = 0.98;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Nie wybrano współczynnika Kr. Domyślnie zostanie przypisana wartość 0.98");
                    this.kp = 0.98;
                    break;
            }
        }

        /// <summary>
        /// metody dodatkowe dla klasy
        /// </summary>

        /// <summary>
        /// nadpisywanie metod z klasy rodzica
        /// </summary>

        protected sealed override void nastawKb(int kb)
        {
            switch (kb)
            {
                case 1:
                    this.kb = 1.1;
                    break;
                case 2:
                    this.kb = 1.2;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Nie wybrano współczynnika Kb. Domyślnie zostanie przypisana wartość 1.2");
                    this.kb = 1.2;
                    break;
            }
        }
        protected sealed override double oblicz()
        {
            return kb * kr * IMax / (kp * Przek);   //Równanie1: (Kb1*Kr*Imax)/(Kp*Przek1)
        }

        /// <summary>
        /// nadpisywanie metod z klasy rodzica
        /// </summary>

        public double obliczZabNadZwl(int kb, int kr, int kp) //metoda zbiorcza, uruchamia wszystkie poprzednie w celu uzyskania wyniku pradu zwlocznego
        {
            nastawKb(kb);
            nastawKr(kr);
            nastawKp(kp);
            return oblicz();
        }
    }
}