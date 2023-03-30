using MetodologiaDeProgramacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos.Coleccionables
{
    internal class Conjunto : Coleccionable
    {

        List<Comparable> conjunto;

        public Conjunto()
        {
            conjunto = new List<Comparable>();
        }

        public void agregar(Comparable c)
        {
            if (!contiene(c)) conjunto.Add(c);
        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable e in this.conjunto)
            {
                if (c.sosIgual(e)) return true;
            }
            return false;
        }

        public int cuantos()
        {
            return conjunto.Count;
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
