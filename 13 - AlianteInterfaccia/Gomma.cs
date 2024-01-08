using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___AlianteInterfaccia
{
    internal class Gomma : InterComposite
    {
        private double _altezza;
        private double _larghezza;
        private double _raggio;

        public double Altezza
        {
            get { return _altezza; }
            set
            {
                if (value >= 1.5)
                    _altezza = value;
                else
                    _altezza = 1.5;
            }
        }

        public double Larghezza
        {
            get { return _larghezza; }
            set
            {
                if (value >= 1)
                    _larghezza = value;
                else
                    _larghezza = 1;
            }
        }

        public double Raggio
        {
            get { return _raggio; }
            set
            {
                if (value >= 10)
                    _raggio = value;
                else
                    _raggio = 10;
            }
        }

        public Gomma()
        {
            Altezza = 0;
            Larghezza = 0;
            Raggio = 0;
        }

        public Gomma(double altezza, double larghezza, double raggio)
        {
            Altezza = altezza;
            Larghezza = larghezza;
            Raggio = raggio;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Gomma) || obj == null)
            {
                return false;
            }

            Gomma other = (Gomma)obj;
            return Altezza == other.Altezza && Larghezza == other.Larghezza && Raggio == other.Raggio;
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
            return $"Gomma: Altezza: {Altezza}; Larghezza: {Larghezza}; Raggio{Raggio}";
        }

        public double Price()
        {
            return 10 * Altezza * Larghezza * Raggio;
        }
    }
}
