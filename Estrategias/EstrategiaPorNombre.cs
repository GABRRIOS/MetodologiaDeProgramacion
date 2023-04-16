using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;

namespace MetodologiaDeProgramacion.Estrategys
{
    internal class EstrategiaPorNombre : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getNombre().Equals(((Alumno)c2).getNombre());
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            //No se entiende en enunciado que se debe comprar en nombre return true por defecto;
            return true;
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            //No se entiende en enunciado que se debe comprar en nombre return true por defecto;
            return true;
        }
    }
}
