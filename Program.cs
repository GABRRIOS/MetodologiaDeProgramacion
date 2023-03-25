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
                default:
                    break;
            }
        }
    }
}