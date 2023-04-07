using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.FarbicaDeModelos
{
    internal class FabricaDeAlumnos : FabricaDeComparables
    {
        public Comparable crearAleatorio()
        {
            int dni = GeneradorDeDatosAleatorios.numeroAleatorio(99999999);
            var nombre = GeneradorDeDatosAleatorios.stringAleatorio(6);
            int legajo = GeneradorDeDatosAleatorios.numeroAleatorio(9999);
            int promedio = GeneradorDeDatosAleatorios.numeroAleatorio(10);
            return new Alumno(nombre, dni, legajo, promedio);
        }

        public Comparable crearPorTeclado()
        {
            int dni = LectorDeDatos.numeroPorTeclado();
            var nombre = LectorDeDatos.stringPorTeclado();
            int legajo = LectorDeDatos.numeroPorTeclado();
            int promedio = LectorDeDatos.numeroPorTeclado();
            return new Alumno(nombre, dni, legajo, promedio);
        }
    }
}
