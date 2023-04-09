using MetodologiaDeProgramacion.FarbicaDeModelos;
using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.ModelosAbstractos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MetodologiaDeProgramacion.Utilidades
{
    static class Utils
    {
        public static void llenar(Coleccionable c, int opcion)
        {
            for (int x = 0; x < 20; x++)
            {
                c.agregar(FabricaDeModelosComparables.crearAleatorio(opcion));
            }         
        }

        public static void imprimir(string value)
        {
            Console.WriteLine(value);
        }

        public static void informar(Coleccionable c, int opcion)
        {
            Comparable max = c.maximo();
            Comparable min = c.minimo();
            imprimir(c.cuantos().ToString());
            imprimir(max.ToString());
            imprimir(min.ToString());
            if ((max.GetType().Equals(typeof(Persona)))) return;
            Comparable comparable = FabricaDeModelosComparables.crearPorTeclado(opcion);
            if (c.contiene(comparable)) imprimir("El elemento leído está en la colección");
            else imprimir("“El elemento leído no está en la colección");
        }

        private static List<String> NOMBRES = new List<String>{
            "Noah" ,"Liam" ,"William" ,"Mason" ,
            "James" ,"Benjamin" ,"Jacob" ,
            "Michael" ,"Elijah" ,"Ethan" ,
            "Alexander" ,"Oliver" ,"Daniel" ,
            "Lucas" ,"Matthew" ,"Aiden" ,
            "Jackson" ,"Logan" ,"David" ,"Joseph" };

        public static void llenarPersonas(Coleccionable c)
        {
            for (int x = 0; x < 20; x++)
            {
                Random rnd = new Random();
                var r = new Random();
                int dni = rnd.Next(20999999, 50999999);
                var nombre = NOMBRES[rnd.Next(20)];
                Comparable comparable = new Persona(nombre.ToString(), dni);
                c.agregar(comparable);
            }       
        }

        static public void llenarAlumnos(Coleccionable c)
        {
            for (int x = 0; x < 20; x++)
            {
                Random rnd = new Random();
                var r = new Random();
                var nombre = NOMBRES[rnd.Next(20)];
                int dni = rnd.Next(20999999, 50999999);
                int legajo = rnd.Next(9999);
                int promedio = rnd.Next(10);
                Comparable comparable = new Alumno(nombre.ToString(), dni, legajo, promedio);
                c.agregar(comparable);
            }   
        }

        static public void imprimirElementos(Coleccionable c)
        {
            c.primero();
            while (!c.fin())
            {
                imprimir(c.actual().ToString());
                c.siguiente();
            }
        }

        static public void cambiarEstrategia(Coleccionable coleccionable, EstrategiaDeComparacion estrategia)
        {
            coleccionable.primero();
            while (!coleccionable.fin())
            {
                ((Alumno)coleccionable.actual()).setEstrategia(estrategia);
                coleccionable.siguiente();
            }
        }
    }
}
