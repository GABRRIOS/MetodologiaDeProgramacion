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
    internal class Gerente : Observado
    {      
        Conjunto mejores;
        List<Observador> observadores;

        public Gerente()
        {
            this.mejores = new Conjunto();
            this.observadores = new List<Observador>();
        }

        public void agregarObservador(Observador o)
        {
            if (!observadores.Contains(o)) observadores.Add(o);
        }

        public void cerrar()
        {
            Utils.imprimirElementos(mejores);
        }

        public void notificar()
        {
            foreach(Observador o in observadores)
            {
                o.actualizar(this);
            }
        }

        public void quitarObservador(Observador o)
        {
           observadores.Remove(o);
        }

        public void venta(double monto, Vendedor vendedor)
        {
            if (monto > 5000) mejores.agregar(vendedor);
            else vendedor.aumentarBonus();
        }
    }
}
