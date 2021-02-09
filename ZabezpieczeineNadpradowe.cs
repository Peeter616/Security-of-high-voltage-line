using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabLiniiSN
{
    abstract class ZabezpieczeineNadpradowe
    {
        private double Imax;
        private double przek;

        /// <summary>
        /// gettery, settery
        /// </summary>

        public double IMax
        {
            get
            {
                return Imax;
            }
            protected set
            {
                Imax = value;
            }
        }
        public double Przek
        {
            get
            {
                return przek;
            }
            protected set
            {
                if (value > 0)
                    przek = value;
                else
                    przek = 1;
            }
        }

        /// <summary>
        /// gettery, settery
        /// </summary>

        /// <summary>
        /// konstruktory
        /// </summary>

        public ZabezpieczeineNadpradowe()
        {
            this.IMax = 80;
            this.Przek = 40;
        }

        public ZabezpieczeineNadpradowe(double IMax, double Przek)
        {
            this.IMax = IMax;
            this.Przek = Przek;
        }

        /// <summary>
        /// konstruktory
        /// </summary>

        abstract protected void nastawKb(int kb); //abstrakyjna metoda nastawy kb
        abstract protected double oblicz(); //abstrakyjna metoda nastawy obliczania pradu
    }
}
