using MetodologiaDeProgramacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos.Coleccionables
{
    internal class Cola : Coleccionable
    {
        List<Comparable> cola;

        public Cola()
        {
            cola = new List<Comparable>();
        }

        public void agregar(Comparable c)
        {
            cola.Add(c);
        }

        public bool contiene(Comparable c)
        {
            return cola.Contains(c);
        }

        public int cuantos()
        {
            return cola.Count();
        }

        public Comparable maximo()
        {
            Comparable comparable = cola[0];
            foreach (Comparable c in cola) {
                if(c.sosMayor(comparable)) comparable = c;
            }
            return comparable;
        }

        public Comparable minimo()
        {
            Comparable comparable = cola[0];
            foreach (Comparable c in cola)
            {
                if (c.sosMenor(comparable)) comparable = c;
            }
            return comparable;
        }
    }
}
