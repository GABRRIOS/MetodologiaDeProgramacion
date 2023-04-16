using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Estrategias
{
    internal class EstrategiaPorPromedio : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c1).getPromedio().Equals(((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c2).getPromedio());
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c1).getPromedio() > ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c2).getPromedio();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c1).getLegajo() < ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c2).getLegajo();
        }
    }
}
