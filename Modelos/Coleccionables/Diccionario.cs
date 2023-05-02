using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Modelos.Coleccionables
{
    internal class Diccionario : Coleccionable, Iterador, Ordenable
    {
        List<ClaveValor> diccionario;
        int paginaActual;
        OrdenEnAula1 ordenAulaLlena;
        OrdenEnAula1 ordenInicio;
        OrdenEnAula2 ordenLlegaAlumno;

        public Diccionario()
        {
            diccionario = new List<ClaveValor>();
            this.paginaActual = 0;
        }

        public void agregar(Comparable c)
        {
            Random rnd = new Random();
            diccionario.Add(new ClaveValor(c, rnd.Next(0, 99)));
        }
        public void agregar(Comparable c, object v)
        {
            foreach (ClaveValor e in this.diccionario)
            {
                if (c.sosIgual(e.Clave)) e.Valor = v;
                if (ordenInicio != null && cuantos() == 1) ordenInicio.ejecutar();
                if (ordenLlegaAlumno != null) ordenLlegaAlumno.ejecutar(c);
                if (ordenAulaLlena != null && cuantos() == 40) ordenAulaLlena.ejecutar();
            }
        }

        public bool contiene(Comparable c)
        {
            foreach (ClaveValor e in this.diccionario)
            {
                if (c.sosIgual(e.Clave)) return true;
            }
            return false;
        }
        public object? valorDe(Comparable c)
        {
            foreach (ClaveValor cv in this.diccionario)
            {
                if (cv.Clave.sosIgual(c)) return cv.Valor;
            }
            return null;
        }

        public int cuantos()
        {
            return diccionario.Count();
        }

        public Comparable maximo()
        {
            Comparable c = (diccionario[0]).Clave;
            foreach (ClaveValor cv in diccionario)
            {
                if (cv.Clave.sosMayor(c)) c = cv.Clave;
            }
            return c;
        }

        public Comparable minimo()
        {
            Comparable c = (diccionario[0]).Clave;
            foreach (ClaveValor cv in diccionario)
            {
                if (cv.Clave.sosMenor(c)) c = cv.Clave;
            }
            return c;
        }

        public void primero()
        {
            paginaActual = 0;
        }

        public void siguiente()
        {
            this.paginaActual = this.paginaActual + 1;
        }

        public bool fin()
        {
            return paginaActual >= diccionario.Count;
        }

        public Comparable actual()
        {
            return diccionario[paginaActual].Clave;
        }

        public void setOrdenInicio(OrdenEnAula1 ordenEnAula1)
        {
            this.ordenInicio = ordenEnAula1;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 ordenEnAula2)
        {
            this.ordenLlegaAlumno = ordenEnAula2;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 ordenEnAula1)
        {
            this.ordenAulaLlena = ordenEnAula1;
        }
    }
}
