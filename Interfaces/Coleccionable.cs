using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Interfaces
{
    internal interface Coleccionable : Iterador
    {
        int cuantos();

        Comparable minimo();

        Comparable maximo();

        void agregar(Comparable c);

        bool contiene(Comparable c);
    }
}
