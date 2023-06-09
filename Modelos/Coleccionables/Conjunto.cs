﻿using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Modelos.Coleccionables
{
    internal class Conjunto : Coleccionable, Iterador, Ordenable
    {

        List<Comparable> conjunto;
        int paginaActual;
        OrdenEnAula1 ordenAulaLlena;
        OrdenEnAula1 ordenInicio;
        OrdenEnAula2 ordenLlegaAlumno;

        public Conjunto()
        {
            conjunto = new List<Comparable>();
            paginaActual = 0;
        }

        public List<Comparable> getConjunto()
        {
            return this.conjunto;
        }

        public Comparable actual()
        {
            return conjunto[paginaActual];
        }

        public void agregar(Comparable c)
        {
            if (!contiene(c))
            {
                conjunto.Add(c);
                if (ordenInicio != null && cuantos() == 1) ordenInicio.ejecutar();
                if (ordenLlegaAlumno != null) ordenLlegaAlumno.ejecutar(c);
                if (ordenAulaLlena != null && cuantos() == 40) ordenAulaLlena.ejecutar();
            }

        }

        public bool contiene(Comparable c)
        {
            foreach (Comparable com in conjunto)
            {
                if (com.sosIgual(c)) return true;
            }
            return false;
        }

        public int cuantos()
        {
            return conjunto.Count;
        }

        public bool fin()
        {
            return paginaActual >= conjunto.Count();
        }

        public Comparable maximo()
        {
            Comparable comparable = conjunto[0];
            foreach (Comparable c in conjunto)
            {
                if (c.sosMayor(comparable)) comparable = c;
            }
            return comparable;
        }

        public Comparable minimo()
        {
            Comparable comparable = conjunto[0];
            foreach (Comparable c in conjunto)
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
