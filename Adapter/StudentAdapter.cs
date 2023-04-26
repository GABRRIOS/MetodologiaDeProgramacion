using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.Utilidades;

namespace MetodologiaDeProgramacion.Adapter
{
    internal class StudentAdapter : Student
    {
        Comparable alumno;

        public StudentAdapter(Comparable alumno)
        {
            this.alumno = alumno;
        }

        public Comparable getAlumno() 
        { 
        return alumno;
        }
        public string getName()
        {
            return ((Alumno)alumno).getNombre();
        }

        public virtual int yourAnswerIs(int question)
        {
            return ((Alumno)alumno).reponderPregunta(question);
        }

        public void setScore(int score)
        {
            ((Alumno)alumno).setCalificacion(score);
        }

        public string showResult()
        {
            DecoradorCalificacion dc = UtilsDecorators.aplicarDecoradoPorNota(((Alumno)alumno));
            dc = UtilsDecorators.aplicarDecoradoPorLegajo(dc);
            dc = UtilsDecorators.aplicarDecoradoPorPromocion(dc);
            dc = UtilsDecorators.aplicarDecoradoPorLegajo(dc);
            dc = UtilsDecorators.aplicarDecoradoPorRecuadro(dc);
            return dc.mostrarCalificacion();
        }

        public bool equals(Student student)
        {
            return alumno.sosIgual(((StudentAdapter)student).getAlumno());
        }

        public bool lessThan(Student student)
        {
            return alumno.sosMenor(((StudentAdapter)student).getAlumno());
        }

        public bool greaterThan(Student student)
        {
            return alumno.sosMayor(((StudentAdapter)student).getAlumno());
        }
    }
}
