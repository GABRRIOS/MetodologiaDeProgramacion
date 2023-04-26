using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Modelos.Coleccionables
{
    internal class Cola : Coleccionable
    {
        List<Comparable> cola;
        int paginaActual;

        public Cola()
        {
            cola = new List<Comparable>();
            paginaActual = 0;
        }

        public Comparable actual()
        {
            return cola[paginaActual];
        }

        public void agregar(Comparable c)
        {
            cola.Add(c);
        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable com in cola)
            {
                if (com.sosIgual(c)) return true;
            }
            return false;
        }

        public int cuantos()
        {
            return cola.Count();
        }

        public bool fin()
        {
            return paginaActual >= cola.Count();
        }

        public Comparable maximo()
        {
            Comparable comparable = cola[0];
            foreach (Comparable c in cola)
            {
                if (c.sosMayor(comparable)) comparable = c;
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

        public void primero()
        {
            this.paginaActual = 0;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 ordenEnAula1)
        {
            throw new NotImplementedException();
        }

        public void setOrdenInicio(OrdenEnAula1 ordenEnAula1)
        {
            throw new NotImplementedException();
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 ordenEnAula2)
        {
            throw new NotImplementedException();
        }

        public void siguiente()
        {
            this.paginaActual = this.paginaActual + 1;
        }
    }
}
