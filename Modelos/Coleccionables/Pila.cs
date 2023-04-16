using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Modelos.Coleccionables
{
    internal class Pila : Coleccionable
    {
        List<Comparable> pila;
        int paginaActual;

        public Pila()
        {
            pila = new List<Comparable>();
            paginaActual = 0;
        }

        public Comparable actual()
        {
            return pila[paginaActual];
        }

        public void agregar(Comparable c)
        {
            pila.Add(c);
        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable com in pila)
            {
                if (c.sosIgual(com)) return true;
            }
            return false;
        }

        public int cuantos()
        {
            return pila.Count();
        }

        public bool fin()
        {
            return paginaActual >= pila.Count();
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

        public void primero()
        {
            this.paginaActual = 0;
        }

        public void siguiente()
        {
            this.paginaActual = this.paginaActual + 1;
        }
    }
}
