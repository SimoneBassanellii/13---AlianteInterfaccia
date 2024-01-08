using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___AlianteInterfaccia
{
    internal class Fusoliera : InterComposite
    {
        private double _lunghezza;
        private string _materiale;

        public double Lunghezza
        {
            get { return _lunghezza; }
            set
            {
                if (value >= 60)
                    _lunghezza = value;
                else
                    _lunghezza = 60;
            }
        }

        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }

        public Fusoliera(double lunghezza, string materiale)
        {
            Lunghezza = lunghezza;
            Materiale = materiale;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Fusoliera) || obj == null)
            {
                return false;
            }

            Fusoliera other = (Fusoliera)obj;
            return Lunghezza == other.Lunghezza && Materiale == other.Materiale;
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
            return "Fusoliera: " + Lunghezza + "m";
        }

        public double Price()
        {
            return 50 * Lunghezza;
        }
    }
}
