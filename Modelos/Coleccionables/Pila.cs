using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Modelos.Coleccionables
{
    internal class Pila : Coleccionable, Iterador, Ordenable
    {
        List<Comparable> pila;
        int paginaActual;
        OrdenEnAula1 ordenAulaLlena;
        OrdenEnAula1 ordenInicio;
        OrdenEnAula2 ordenLlegaAlumno;

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
            if (ordenInicio != null && cuantos() == 1) ordenInicio.ejecutar();
            if (ordenLlegaAlumno != null) ordenLlegaAlumno.ejecutar(c);
            if (ordenAulaLlena != null && cuantos() == 40) ordenAulaLlena.ejecutar();
        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable com in pila)
            {
                if (com.sosIgual(c)) return true;
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

        public void setOrdenAulaLlena(OrdenEnAula1 ordenEnAula1)
        {
            this.ordenAulaLlena = ordenEnAula1;
        }

        public void setOrdenInicio(OrdenEnAula1 ordenEnAula1)
        {
            this.ordenInicio = ordenEnAula1;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 ordenEnAula2)
        {
            this.ordenLlegaAlumno = ordenEnAula2;
        }

        public void siguiente()
        {
            this.paginaActual = this.paginaActual + 1;
        }
    }
}
