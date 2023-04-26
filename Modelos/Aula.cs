using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos
{
    internal class Aula
    {

        private Teacher teacher;

        public Aula()
        {
            teacher = new Teacher();
        }

        public void comenzar()
        {
            Console.WriteLine("Creating new Teacher");
            teacher = new Teacher();
        }

        public void nuevoAlumno(Alumno alumno)
        {
            teacher.goToClass((Student) alumno);
        }

        public void claseLista()
        {
            teacher.teachingAClass();
        }

    }
}
