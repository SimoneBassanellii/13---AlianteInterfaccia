using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___AlianteInterfaccia
{
    public interface InterComposite
    {
        void Add(InterComposite componente);

        void Remove(InterComposite componente);
       
        InterComposite GetChild(int index);
      
        bool Equals(object obj);

        string ToString();

        double Price();
    }
}
