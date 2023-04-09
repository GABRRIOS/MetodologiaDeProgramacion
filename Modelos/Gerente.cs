using MetodologiaDeProgramacion.Modelos.Coleccionables;
using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos
{
    internal class Gerente
    {
        Conjunto mejores;

        public Gerente()
        {
            this.mejores = new Conjunto();
        }

        public void cerrar()
        {
            Utils.imprimirElementos(mejores);
        }

        public void venta(double monto, Vendedor vendedor)
        {
            if (monto > 5000) mejores.agregar(vendedor);
            else vendedor.aumentarBonus();
        }
    }
}
