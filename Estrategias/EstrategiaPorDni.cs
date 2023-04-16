﻿using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Estrategias
{
    internal class EstrategiaPorDni : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable c1, Comparable c2)
        {
            return ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c1).getDni().Equals(((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c2).getDni());
        }

        public bool sosMayor(Comparable c1, Comparable c2)
        {
            return ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c1).getDni() < ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c2).getDni();
        }

        public bool sosMenor(Comparable c1, Comparable c2)
        {
            return ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c1).getDni() > ((MetodologiaDeProgramacion.Modelos.Comparables.Alumno)c2).getDni();
        }
    }
}
