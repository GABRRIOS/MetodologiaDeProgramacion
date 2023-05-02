using MetodologiaDeProgramacion.Adapter;
using MetodologiaDeProgramacion.Interfaces;

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

        public void nuevoAlumno(Comparable alumno)
        {
            teacher.goToClass(new StudentAdapter(alumno));
        }

        public void claseLista()
        {
            teacher.teachingAClass();
        }

    }
}
