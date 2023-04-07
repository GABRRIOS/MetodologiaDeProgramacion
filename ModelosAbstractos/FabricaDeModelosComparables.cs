using MetodologiaDeProgramacion.FarbicaDeModelos;
using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.ModelosAbstractos
{
    abstract class FabricaDeModelosComparables
    {
        const int NUMERO = 0;
        const int ALUMNO = 1;

        static public Comparable crearAleatorio(int valor)
        {
            FabricaDeComparables? fabricaDeComparables = null;

            if (valor == NUMERO) fabricaDeComparables = new FabricaDeNumeros();
            else if (valor == ALUMNO) fabricaDeComparables = new FabricaDeAlumnos();
            else fabricaDeComparables = new FabricaDeNumeros();
            return fabricaDeComparables.crearAleatorio();
        }

        static public Comparable crearPorTeclado(int valor)
        {
            FabricaDeComparables? fabricaDeComparables = null;

            if (valor == NUMERO) fabricaDeComparables = new FabricaDeNumeros();
            else if (valor == ALUMNO) fabricaDeComparables = new FabricaDeAlumnos();
            else fabricaDeComparables = new FabricaDeNumeros();
            return fabricaDeComparables.crearPorTeclado();
        }
    }
}
