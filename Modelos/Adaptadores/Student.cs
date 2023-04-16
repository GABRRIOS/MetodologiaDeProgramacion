using MetodologiaDeProgramacion.Interfaces;
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
    }
}
