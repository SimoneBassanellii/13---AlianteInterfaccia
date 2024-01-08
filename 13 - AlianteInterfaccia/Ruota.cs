using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___AlianteInterfaccia
{
    internal class Ruota : InterComposite
    {
        private Gomma _gomma;
        private Cerchione _cerchione;

        public Gomma Gomma
        {
            get { return _gomma; }
            set { _gomma = value; }
        }

        public Cerchione Cerchione
        {
            get { return _cerchione; }
            set { _cerchione = value; }
        }

        public Ruota()
        {
            Gomma = new Gomma();
            Cerchione = new Cerchione();
        }

        public Ruota(Gomma gomma, Cerchione cerchione)
        {
            Gomma = gomma;
            Cerchione = cerchione;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ruota) || obj == null)
            {
                return false;
            }

            Ruota other = (Ruota)obj;
            return Gomma.Equals(other.Gomma) && Cerchione.Equals(other.Cerchione);
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
            return "Particolari gomma: " + Gomma + " Particolari cerchione " + Cerchione;
        }

        public double Price()
        {
            return 0;
        }
    }
}