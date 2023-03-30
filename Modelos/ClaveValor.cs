using MetodologiaDeProgramacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos
{
    internal class ClaveValor
    {

        Comparable clave;
        object valor;

        public object Valor { get => valor; set => valor = value; }
        internal Comparable Clave { get => clave; set => clave = value; }
    }
}
