using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabLiniiSN
{
    class Zwarciowe : ZabezpieczeineNadpradowe
    {
        double kb;

        public Zwarciowe(double IMax, double Przek) : base(IMax, Przek) //konstruktor domyślny
        { }

        /// <summary>
        /// nadpisywanie metod z klasy rodzica
        /// </summary>

        protected sealed override void nastawKb(int kb)
        {
            switch (kb)
            {
                case 1:
                    this.kb = 1.2;
                    break;
                case 2:
                    this.kb = 1.3;
                    break;
                case 3:
                    this.kb = 1.4;
                    break;
                case 4:
                    this.kb = 1.5;
                    break;
                case 5:
                    this.kb = 1.6;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Nie wybrano współczynnika Kb. Domyślnie zostanie przypisana wartość 1.4");
                    this.kb = 1.4;
                    break;
            }
        }

        protected sealed override double oblicz()
        {
            return kb * IMax / Przek;   //Równanie2: (Kb2*Ikmax)/Przek2
        }

        /// <summary>
        /// nadpisywanie metod z klasy rodzica
        /// </summary>
        
        public double obliczZabNadZwarc(int kb) //metoda zbiorcza, uruchamia wszystkie poprzednie w celu uzyskania wyniku pradu zwarciowego
        {
            nastawKb(kb);
            return oblicz();
        }
    }
}
