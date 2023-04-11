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
    internal class FabricaDeVendedores : FabricaDeComparables
    {
        public Comparable crearAleatorio()
        {         
            var nombre = GeneradorDeDatosAleatorios.stringAleatorio(6);
            int dni = GeneradorDeDatosAleatorios.numeroAleatorio(40999999);
            double sueldoBasico = GeneradorDeDatosAleatorios.numeroAleatorio(99999);
            return new Vendedor(nombre, dni, sueldoBasico);
        }

        public Comparable crearPorTeclado()
        {            
            var nombre = LectorDeDatos.stringPorTeclado();
            int dni = LectorDeDatos.numeroPorTeclado();
            double sueldoBasico = LectorDeDatos.numeroPorTeclado();
            return new Vendedor(nombre, dni, sueldoBasico);
        }
    }
}
