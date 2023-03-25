using MetodologiaDeProgramacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos.Comparables
{
    internal class Alumno : Persona
    {

        int legajo;
        int promedio;

        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public int getPromedio()
        {
            return promedio;
        }

        public override bool sosIgual(Comparable c)
        {
            if (promedio.Equals(((Alumno)c).getPromedio())) return true;
            return false;
        }

        public override bool sosMayor(Comparable c)
        {
            if (promedio > ((Alumno)c).getPromedio()) return true;
            return false;
        }

        public override bool sosMenor(Comparable c)
        {
            if (promedio < ((Alumno)c).getPromedio()) return true;
            return false;
        }

        public override string ToString()
        {
            return "Alumno: " + getNombre() + " Dni: " + getDni()+ " Legajo: " + legajo + " Promedio: " + promedio;
        }
    }
}
