using MetodologiaDeProgramacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos.Coleccionables
{
    internal class ColeccionMultiple : Coleccionable
    {

        Coleccionable p;
        Coleccionable c;

        public ColeccionMultiple(Coleccionable p, Coleccionable c)
        {
            this.p = p;
            this.c = c;
        }

        public Comparable actual()
        {
            throw new NotImplementedException();
        }

        public void agregar(Comparable c)
        {
        }

        public bool contiene(Comparable c)
        {
            return this.c.contiene(c) || this.p.contiene(c); 
        }

        public int cuantos()
        {
            return p.cuantos() + c.cuantos();
        }

        public bool fin()
        {
            throw new NotImplementedException();
        }

        public Comparable maximo()
        {
            Comparable pMax = p.maximo();
            Comparable cMax = c.maximo();  
            if (pMax.sosMayor(cMax)) return pMax;
            return cMax;
        }

        public Comparable minimo()
        {
            Comparable pMin = p.minimo();
            Comparable cMin = c.minimo();
            if (pMin.sosMenor(cMin)) return pMin;
            return cMin;
        }

        public void primero()
        {
            throw new NotImplementedException();
        }

        public void siguiente()
        {
            throw new NotImplementedException();
        }
    }
}
