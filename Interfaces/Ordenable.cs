using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Interfaces
{
    internal interface Ordenable
    {
        void setOrdenInicio(OrdenEnAula1 ordenEnAula1);
        void setOrdenLlegaAlumno(OrdenEnAula2 ordenEnAula2);
        void setOrdenAulaLlena(OrdenEnAula1 ordenEnAula1);
    }
}
