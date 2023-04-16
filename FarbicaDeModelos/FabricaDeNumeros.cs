using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.ModelosAbstractos;
using MetodologiaDeProgramacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.FarbicaDeModelos
{
    class FabricaDeNumeros : FabricaDeComparables
    {
        public override  Comparable crearAleatorio()
        {
            return new Numero(GeneradorDeDatosAleatorios.numeroAleatorio(99));
        }

        public override Comparable crearPorTeclado()
        {
            return new Numero(LectorDeDatos.numeroPorTeclado());
        }
    }
}
