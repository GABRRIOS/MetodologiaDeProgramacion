using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.ModelosAbstractos;
using MetodologiaDeProgramacion.Utilidades;

namespace MetodologiaDeProgramacion.FarbicaDeModelos
{
    internal class FabricaDeVendedores : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            var nombre = GeneradorDeDatosAleatorios.stringAleatorio(6);
            int dni = GeneradorDeDatosAleatorios.numeroAleatorio(40999999);
            double sueldoBasico = GeneradorDeDatosAleatorios.numeroAleatorio(99999);
            return new Vendedor(nombre, dni, sueldoBasico);
        }

        public override Comparable crearPorTeclado()
        {
            var nombre = LectorDeDatos.stringPorTeclado();
            int dni = LectorDeDatos.numeroPorTeclado();
            double sueldoBasico = LectorDeDatos.numeroPorTeclado();
            return new Vendedor(nombre, dni, sueldoBasico);
        }
    }
}
