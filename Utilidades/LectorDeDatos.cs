using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Utilidades
{
    static class LectorDeDatos
    {
        public static int numeroPorTeclado() => Convert.ToInt32(Console.ReadLine());

        public static string stringPorTeclado() => Console.ReadLine();
    }
}
