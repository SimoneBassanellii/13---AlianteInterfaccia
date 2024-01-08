using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___AlianteInterfaccia
{
    internal class Coda : InterComposite
    {
        private double _lunghezza;

        public double Lunghezza
        {
            get { return _lunghezza; }
            set
            {
                if (value >= 6)
                    _lunghezza = value;
                else
                    _lunghezza = 8;
            }
        }

        public Coda(double lunghezza)
        {
            Lunghezza = lunghezza;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Coda) || obj == null)
            {
                return false;
            }

            Coda other = (Coda)obj;
            return Lunghezza == other.Lunghezza;
        }

        public void Add(InterComposite component)
        {

        }

        public void Remove(InterComposite component)
        {

        }

        public InterComposite GetChild(int index)
        {
            return null;
        }

        public override string ToString()
        {
            return "Coda: " + Lunghezza + "m";
        }

        public double Price()
        {
            return 20 * Lunghezza;
        }
    }
}
