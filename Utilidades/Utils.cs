using MetodologiaDeProgramacion.Adapter;
using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos;
using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.ModelosAbstractos;
using MetodologiaDeProgramacion.Proxy;

namespace MetodologiaDeProgramacion.Utilidades
{
    static class Utils
    {
        public static void llenar(Coleccionable c, int opcion)
        {
            for (int x = 0; x < 20; x++)
            {
                c.agregar(FabricaDeComparables.crearAleatorio(opcion));
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
            Comparable comparable = FabricaDeComparables.crearPorTeclado(opcion);
            if (c.contiene(comparable)) imprimir("El elemento leído está en la colección");
            else imprimir("“El elemento leído no está en la colección");
        }

        public static string[] NOMBRES = {
            "Noah" ,"Liam" ,"William" ,"Mason" ,
            "James" ,"Benjamin" ,"Jacob" ,
            "Michael" ,"Elijah" ,"Ethan" ,
            "Alexander" ,"Oliver" ,"Daniel" ,
            "Lucas" ,"Matthew" ,"Aiden" ,
            "Jackson" ,"Logan" ,"David" ,"Joseph" , "Maria"};

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

        static public void imprimirElementos(Iterador c)
        {
            c.primero();
            while (!c.fin())
            {
                imprimir(c.actual().ToString());
                c.siguiente();
            }
        }

        static public void cambiarEstrategia(Iterador coleccionable, EstrategiaDeComparacion estrategia)
        {
            coleccionable.primero();
            while (!coleccionable.fin())
            {
                ((Alumno)coleccionable.actual()).setEstrategia(estrategia);
                coleccionable.siguiente();
            }
        }

        public static void jornadaDeVentas(Iterador c)
        {
            for (int x = 0; x < 20; x++)
            {
                c.primero();
                while (!c.fin())
                {
                    ((Vendedor)c.actual()).venta(GeneradorDeDatosAleatorios.numeroAleatorio(7000));
                    c.siguiente();
                }
            }
        }

        public static void newStudentsToClass(Teacher t)
        {
            int opcion = 0;
            for (int x = 0; x < 20; x++)
            {
                if (x >= 10) opcion = 1;
                var nombre = Utils.NOMBRES.GetValue(GeneradorDeDatosAleatorios.numeroAleatorio(20)) as string;
                int dni = GeneradorDeDatosAleatorios.numeroAleatorio(99999999);
                int legajo = GeneradorDeDatosAleatorios.numeroAleatorio(9999);
                int promedio = GeneradorDeDatosAleatorios.numeroAleatorio(10);
                t.goToClass(new StudentAdapter(new ProxyAlumno(nombre, dni, legajo, promedio, opcion)));
            }
        }
        public static string stringNumber(int numero)
        {
            if (numero == 0) return "(CERO)";
            if (numero == 1) return "(UNO)";
            if (numero == 2) return "(DOS)";
            if (numero == 3) return "(TRES)";
            if (numero == 4) return "(CUATRO)";
            if (numero == 5) return "(CINCO)";
            if (numero == 6) return "(SEIS)";
            if (numero == 7) return "(SIETE)";
            if (numero == 8) return "(OCHO)";
            if (numero == 9) return "(NUEVE)";
            return "(DIEZ)";

        }
    }
}
