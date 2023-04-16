using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.ModelosAbstractos;
using MetodologiaDeProgramacion.Utilidades;

namespace MetodologiaDeProgramacion.FarbicaDeModelos
{
    class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Numero(GeneradorDeDatosAleatorios.numeroAleatorio(99));
        }

        public override Comparable crearPorTeclado()
        {
            return new Numero(LectorDeDatos.numeroPorTeclado());
        }
    }
}
