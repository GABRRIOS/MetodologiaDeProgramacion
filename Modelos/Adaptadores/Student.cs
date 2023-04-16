using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos.Adaptadores
{
    internal class Student
    {
        Comparable alumno;

        public Student(Comparable alumno)
        {
            this.alumno = alumno;
        }

        public Comparable getAlumno()
        {
            return alumno;
        }

        public int answerQ(int option)
        {
            if ((alumno.GetType().Equals(typeof(Alumno)))) return ((Alumno)alumno).reponderPregunta(option);
            else return ((AlumnoMuyEstudioso)alumno).reponderPregunta(option);
        }

        public void setQ(int q)
        {
            ((Alumno)alumno).setCalificacion(q);
        }

        public string showQ()
        {
            return ((Alumno)alumno).mostrarCalificacion();
        }

    }
}
