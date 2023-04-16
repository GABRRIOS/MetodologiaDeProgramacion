using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.ModelosAbstractos;
using MetodologiaDeProgramacion.Utilidades;

namespace MetodologiaDeProgramacion.FarbicaDeModelos
{
    internal class FabricaDeAlumnos : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            var nombre = GeneradorDeDatosAleatorios.stringAleatorio(6);
            int dni = GeneradorDeDatosAleatorios.numeroAleatorio(99999999);
            int legajo = GeneradorDeDatosAleatorios.numeroAleatorio(9999);
            int promedio = GeneradorDeDatosAleatorios.numeroAleatorio(10);
            return new Alumno(nombre, dni, legajo, promedio);
        }

        public override Comparable crearPorTeclado()
        {
            var nombre = LectorDeDatos.stringPorTeclado();
            int dni = LectorDeDatos.numeroPorTeclado();
            int legajo = LectorDeDatos.numeroPorTeclado();
            int promedio = LectorDeDatos.numeroPorTeclado();
            return new Alumno(nombre, dni, legajo, promedio);
        }
    }
}
