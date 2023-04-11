using MetodologiaDeProgramacion.Interfaces;
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
    internal class Gerente : Observador
    {      
        Coleccionable mejores;

        public Gerente()
        {
            this.mejores = new Cola();
        }

        public void actualizar(double monto, Observado observado)
        {
            venta(monto, (Vendedor)observado);
        }

        public void cerrar()
        {
            Console.WriteLine("los mejores vendedores son: ");
            Utils.imprimirElementos(mejores);
        }

        public void venta(double monto, Vendedor vendedor)
        {
            if (!mejores.contiene(vendedor))
            {
                if (monto > 5000)
                {
                    mejores.agregar(vendedor);
                }
                else vendedor.aumentarBonus();
            }           
        }
    }
}
