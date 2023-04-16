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
    internal class FabricaDeAlumnoMuyEstudioso : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            var nombre = GeneradorDeDatosAleatorios.stringAleatorio(6);
            int dni = GeneradorDeDatosAleatorios.numeroAleatorio(99999999);
            int legajo = GeneradorDeDatosAleatorios.numeroAleatorio(9999);
            int promedio = GeneradorDeDatosAleatorios.numeroAleatorio(10);
            return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio);
        }

        public override Comparable crearPorTeclado()
        {
            var nombre = LectorDeDatos.stringPorTeclado();
            int dni = LectorDeDatos.numeroPorTeclado();
            int legajo = LectorDeDatos.numeroPorTeclado();
            int promedio = LectorDeDatos.numeroPorTeclado();
            return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio);
        }
    }
}
