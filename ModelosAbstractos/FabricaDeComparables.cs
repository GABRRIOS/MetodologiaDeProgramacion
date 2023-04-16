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
    abstract class FabricaDeComparables
    {
        const int NUMERO = 0;
        const int PERSONA = 1;
        const int ALUMNO = 2;
        const int VENDEDOR = 3;

        static public Comparable crearAleatorio(int valor)
        {
            FabricaDeComparables? fabricaDeComparables = null;

            if (valor == NUMERO) fabricaDeComparables = new FabricaDeNumeros();
            else if (valor == PERSONA) fabricaDeComparables = new FabricaDePersonas();
            else if (valor == ALUMNO) fabricaDeComparables = new FabricaDeAlumnos();
            else if (valor == VENDEDOR) fabricaDeComparables = new FabricaDeVendedores();
            else fabricaDeComparables = new FabricaDeNumeros();
            return fabricaDeComparables.crearAleatorio();
        }

        public virtual Comparable crearAleatorio()
        {
            throw new NotImplementedException();
        }

        static public Comparable crearPorTeclado(int valor)
        {
            FabricaDeComparables? fabricaDeComparables = null;

            if (valor == NUMERO) fabricaDeComparables = new FabricaDeNumeros();
            else if (valor == PERSONA) fabricaDeComparables = new FabricaDePersonas();
            else if (valor == ALUMNO) fabricaDeComparables = new FabricaDeAlumnos();
            else if (valor == VENDEDOR) fabricaDeComparables = new FabricaDeVendedores();
            else fabricaDeComparables = new FabricaDeNumeros();
            return fabricaDeComparables.crearPorTeclado();
        }

        public virtual Comparable crearPorTeclado()
        {
            throw new NotImplementedException();
        }
    }
}
