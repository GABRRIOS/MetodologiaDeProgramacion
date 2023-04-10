using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Interfaces
{
    internal interface Observado
    {
        void agregarObservador(Observador o);
        void quitarObservador(Observador o);
        void notificar();
    }
}
