using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Interfaces
{
    internal interface Coleccionable
    {
        int cuatos();

        Comparable minimo();

        Comparable maximo();

        void agergar(Comparable c);

        bool contiene(Comparable c);
    }
}
