using MetodologiaDeProgramacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos.Coleccionables
{
    internal class Diccionario : Coleccionable
    {
        List<ClaveValor> diccionario;

        public Diccionario()
        {
            diccionario = new List<ClaveValor>();
        }

        public void agregar(Comparable c)
        {
            throw new NotImplementedException();
        }
        public void agregar(Comparable c, object v) {
            foreach (ClaveValor e in this.diccionario)
            {
                if (c.sosIgual(e.Clave)) e.Valor = v;
            }
        }

        public bool contiene(Comparable c)
        {
            throw new NotImplementedException();
        }
        public object valorDe(Comparable c)
        {
            return null;
        }

        public int cuantos()
        {
            throw new NotImplementedException();
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
