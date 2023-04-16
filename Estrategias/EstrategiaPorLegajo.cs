using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;

namespace MetodologiaDeProgramacion.Estrategys
{
    internal class EstrategiaPorLegajo : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getLegajo().Equals(((Alumno)c2).getLegajo());
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getLegajo() > ((Alumno)c2).getLegajo();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getLegajo() < ((Alumno)c2).getLegajo();
        }
    }
}
