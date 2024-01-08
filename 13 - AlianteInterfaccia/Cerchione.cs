using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___AlianteInterfaccia
{
    public class Cerchione : InterComposite
    {
        private double _pollici;
        private string _materiale;

        public double Pollici
        {
            get { return _pollici; }
            set
            {
                if (value >= 10)
                    _pollici = value;
                else
                    _pollici = 10;
            }
        }

        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }

        public Cerchione()
        {
            Pollici = 0;
            Materiale = string.Empty;
        }

        public Cerchione(double pollici, string materiale)
        {
            Pollici = pollici;
            Materiale = materiale;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Cerchione) || obj == null)
            {
                return false;
            }

            Cerchione other = (Cerchione)obj;
            return Pollici == other.Pollici && Materiale == other.Materiale;
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
            return $"Cerchione: {Pollici} pollici, {Materiale}";
        }

        public double Price()
        {
            return Pollici * 2;
        }
    }
}
