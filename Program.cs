using MetodologiaDeProgramacion.Estrategias.Alumno;
using MetodologiaDeProgramacion.Estrategias;
using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Coleccionables;
using MetodologiaDeProgramacion.Utilidades;

namespace MetodologiaDeProgramacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            Conjunto conjunto = new Conjunto();
            Diccionario diccionario = new Diccionario();
            ColeccionMultiple coleccionMultiple = new ColeccionMultiple(pila, cola);

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Utils.llenar(pila);
                    Utils.llenar(cola);
                    Utils.informar(pila);
                    Utils.informar(cola);
                    Utils.informar(coleccionMultiple);
                    break;
                case 2:
                    Utils.llenarPersonas(pila);
                    Utils.llenarPersonas(cola);
                    Utils.informar(coleccionMultiple);
                    break;
                case 3:
                    Utils.llenarAlumnos(pila);
                    Utils.llenarAlumnos(cola);
                    Utils.informar(coleccionMultiple);
                    break;
                case 4:
                    Utils.llenarAlumnos(pila);
                    Utils.llenarAlumnos(cola);
                    Utils.llenarAlumnos(conjunto);
                    Utils.llenarAlumnos(diccionario);
                    Utils.imprimirElementos(pila);
                    Utils.imprimirElementos(cola);
                    Utils.imprimirElementos(conjunto);
                    Utils.imprimirElementos(diccionario);
                    break;
                case 5:
                    Utils.llenarAlumnos(pila);
                    Utils.cambiarEstrategia(pila, new EstrategiaPorNombre());

                    Utils.informar(pila);
                    Utils.cambiarEstrategia(pila, new EstrategiaPorLegajo());

                    Utils.informar(pila);
                    Utils.cambiarEstrategia(pila, new EstrategiaPorPromedio());

                    Utils.informar(pila);
                    Utils.cambiarEstrategia(pila, new EstrategiaPorDni());
                    Utils.informar(pila);
                    break;
                default:
                    break;
            }
        }
    }
}