using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Interfaces
{
    internal interface FabricaDeComparables
    {
        public Comparable crearAleatorio();

        public Comparable crearPorTeclado();
    }
}
