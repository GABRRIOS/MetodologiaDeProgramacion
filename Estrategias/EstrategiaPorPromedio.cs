using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;

namespace MetodologiaDeProgramacion.Estrategys
{
    internal class EstrategiaPorPromedio : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getPromedio().Equals(((Alumno)c2).getPromedio());
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getPromedio() > ((Alumno)c2).getPromedio();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getLegajo() < ((Alumno)c2).getLegajo();
        }
    }
}
