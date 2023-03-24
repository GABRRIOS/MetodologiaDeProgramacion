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

        public void agergar(Comparable c)
        {
            cola.Add(c);
        }

        public bool contiene(Comparable c)
        {
            return cola.Contains(c);
        }

        public int cuatos()
        {
            return cola.Count();
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
