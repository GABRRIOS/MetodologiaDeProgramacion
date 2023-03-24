using MetodologiaDeProgramacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos.Coleccionables
{
    internal class Pila
    {
        List<Comparable> pila;

        public Pila()
        {
            pila = new List<Comparable>();
        }

        public void agergar(Comparable c)
        {
            pila.Add(c);
        }

        public bool contiene(Comparable c)
        {
            return pila.Contains(c);
        }

        public int cuatos()
        {
            return pila.Count();
        }

        public Comparable maximo()
        {
            throw new NotImplementedException();
        }

        public Comparable minimo()
        {
            throw new NotImplementedException();
        }
    }
}
