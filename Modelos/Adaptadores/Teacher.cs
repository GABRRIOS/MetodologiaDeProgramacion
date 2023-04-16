using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos.Adaptadores
{
    internal class Teacher
    {
        List<Student> students;

        public Teacher(List<Student> students) {
            this.students = students;
        }

        public void teachingAClass()
        {
            takeExam();
            publishResults();
        }

        private void takeExam()
        {
            foreach (Student s in students)
            {
                int note = 0;
                //Realiza 10 preguntas a cada uno de los students
                for (int x = 0; x < 10; x++)
                {
                    note = note + s.answerQ(0);
                }
                //califica al alumno en base a las respuestas correctas;
                s.setQ(note / 3);
            }
        }
        
        private void publishResults()
        {
            //sort;
            students.OrderBy(student => ((Alumno)student.getAlumno()).getCalificacion());

            foreach (Student s in students)
            {
                Utils.imprimir(s.showQ());
            }
        }
    }
}
