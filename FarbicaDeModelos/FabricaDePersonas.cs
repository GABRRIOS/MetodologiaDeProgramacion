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
    internal class FabricaDePersonas : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            var nombre = GeneradorDeDatosAleatorios.stringAleatorio(6);
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
