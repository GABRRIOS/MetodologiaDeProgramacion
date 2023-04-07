﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Utilidades
{
    static class GeneradorDeDatosAleatorios
    {
        public static int numeroAleatorio(int maximo)
        {
            Random rnd = new Random();
            return rnd.Next(0, maximo);
        }

        public static string stringAleatorio(int cant)
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, cant)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    }
}
