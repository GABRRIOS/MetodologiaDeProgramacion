using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.ModelosAbstractos;
using MetodologiaDeProgramacion.Utilidades;

namespace MetodologiaDeProgramacion.FarbicaDeModelos
{
    internal class FabricaDePersonas : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            var nombre = Utils.NOMBRES.GetValue(GeneradorDeDatosAleatorios.numeroAleatorio(20)) as String;
            int dni = GeneradorDeDatosAleatorios.numeroAleatorio(99999999);
            return new Persona(nombre, dni);
        }

        public override Comparable crearPorTeclado()
        {
            var nombre = LectorDeDatos.stringPorTeclado();
            int dni = LectorDeDatos.numeroPorTeclado();
            return new Persona(nombre, dni);
        }
    }
}
