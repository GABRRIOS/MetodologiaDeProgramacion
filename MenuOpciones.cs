using MetodologiaDeProgramacion.Estrategias;
using MetodologiaDeProgramacion.Modelos;
using MetodologiaDeProgramacion.Modelos.Coleccionables;
using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.Utilidades;

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
                    Utils.llenar(pila, 1);
                    Utils.llenar(cola, 1);
                    Utils.informar(coleccionMultiple, 1);
                    break;
                case 3:
                    Utils.llenar(pila, 2);
                    Utils.llenar(cola, 2);
                    Utils.informar(coleccionMultiple, 2);
                    break;
                case 4:
                    Utils.llenar(pila, 2);
                    Utils.llenar(cola, 2);
                    Utils.llenar(conjunto, 2);
                    Utils.llenar(diccionario, 2);
                    Utils.imprimirElementos(pila);
                    Utils.imprimirElementos(cola);
                    Utils.imprimirElementos(conjunto);
                    Utils.imprimirElementos(diccionario);
                    break;
                case 5:
                    Utils.llenar(pila, 2);
                    Utils.cambiarEstrategia(pila, new EstrategiaPorNombre());
                    Utils.informar(pila, 2);

                    Utils.cambiarEstrategia(pila, new EstrategiaPorLegajo());
                    Utils.informar(pila, 2);

                    Utils.cambiarEstrategia(pila, new EstrategiaPorPromedio());
                    Utils.informar(pila, 2);

                    Utils.cambiarEstrategia(pila, new EstrategiaPorDni());
                    Utils.informar(pila, 2);
                    break;
                case 6:
                    Utils.llenar(cola, 3);
                    Gerente g = new Gerente();
                    while (!cola.fin())
                    {
                        ((Vendedor)cola.actual()).agregarObservador(g);
                        cola.siguiente();
                    }
                    Utils.jornadaDeVentas(cola);
                    g.cerrar();
                    break;
                case 7:
                    Teacher t = new Teacher();
                    t.setStudents(Utils.newListStudents());
                    t.teachingAClass();
                    break;
                default:
                    break;
            }
        }
    }
}
