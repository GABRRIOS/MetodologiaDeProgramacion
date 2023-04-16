using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Estrategias.Alumno
{
    internal class EstrategiaPorLegajo : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c1).getLegajo().Equals(((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c2).getLegajo());
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c1).getLegajo() > ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c2).getLegajo();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c1).getLegajo() < ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c2).getLegajo();
        }
    }
}
