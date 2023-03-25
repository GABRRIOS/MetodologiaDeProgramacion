using MetodologiaDeProgramacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos.Coleccionables
{
    internal class Pila : Coleccionable
    {
        List<Comparable> pila;

        public Pila()
        {
            pila = new List<Comparable>();
        }

        public void agregar(Comparable c)
        {
            pila.Add(c);
        }

        public bool contiene(Comparable c)
        {
            return pila.Contains(c);
        }

        public int cuantos()
        {
            return pila.Count();
        }

        public Comparable maximo()
        {
            Comparable comparable = pila[0];
            foreach (Comparable c in pila)
            {
                if (c.sosMayor(comparable)) comparable = c;
            }
            return comparable;
        }

        public Comparable minimo()
        {

            Comparable comparable = pila[0];
            foreach (Comparable c in pila)
            {
                if (c.sosMenor(comparable)) comparable = c;
            }
            return comparable;
        }
    }
}
