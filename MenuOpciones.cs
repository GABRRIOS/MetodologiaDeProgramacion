using MetodologiaDeProgramacion.Estrategias.Alumno;
using MetodologiaDeProgramacion.Estrategias;
using MetodologiaDeProgramacion.Modelos.Coleccionables;
using MetodologiaDeProgramacion.Modelos;
using MetodologiaDeProgramacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion
{
    static class MenuOpciones
    {
        static public void ejecutarMenu()
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            Conjunto conjunto = new Conjunto();
            Diccionario diccionario = new Diccionario();
            ColeccionMultiple coleccionMultiple = new ColeccionMultiple(pila, cola);

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Utils.llenar(pila, 0);
                    Utils.llenar(cola, 0);
                    Utils.informar(pila, 0);
                    Utils.informar(cola, 0);
                    Utils.informar(coleccionMultiple, 0);
                    break;
                case 2:
                    Utils.llenarPersonas(pila);
                    Utils.llenarPersonas(cola);
                    Utils.informar(coleccionMultiple, 0);
                    break;
                case 3:
                    Utils.llenar(pila, 1);
                    Utils.llenar(cola, 1);
                    Utils.informar(coleccionMultiple, 1);
                    break;
                case 4:
                    Utils.llenar(pila, 1);
                    Utils.llenar(cola, 1);
                    Utils.llenar(conjunto, 1);
                    Utils.llenar(diccionario, 1);
                    Utils.imprimirElementos(pila);
                    Utils.imprimirElementos(cola);
                    Utils.imprimirElementos(conjunto);
                    Utils.imprimirElementos(diccionario);
                    break;
                case 5:
                    Utils.llenar(pila, 1);
                    Utils.cambiarEstrategia(pila, new EstrategiaPorNombre());
                    Utils.informar(pila, 1);

                    Utils.cambiarEstrategia(pila, new EstrategiaPorLegajo());
                    Utils.informar(pila, 1);

                    Utils.cambiarEstrategia(pila, new EstrategiaPorPromedio());
                    Utils.informar(pila, 1);

                    Utils.cambiarEstrategia(pila, new EstrategiaPorDni());
                    Utils.informar(pila, 1);
                    break;
                case 6:
                    Utils.llenar(conjunto, 2);
                    Gerente g = new Gerente();
                    Utils.jornadaDeVentas(conjunto);
                    g.cerrar();
                    break;
                default:
                    break;
            }
        }
    }
}
