using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Interfaces
{
    internal interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();

    }
}
