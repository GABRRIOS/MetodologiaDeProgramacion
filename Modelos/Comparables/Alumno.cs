using MetodologiaDeProgramacion.Estrategias;
using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Utilidades;

namespace MetodologiaDeProgramacion.Modelos.Comparables
{
    internal class Alumno : Persona, Student
    {

        int legajo;
        int promedio;
        EstrategiaDeComparacion estrategia;
        int calificacion;

        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            estrategia = new EstrategiaPorDni();
        }

        public int getPromedio()
        {
            return promedio;
        }

        public int getLegajo()
        {
            return legajo;
        }

        public void setEstrategia(EstrategiaDeComparacion estrategia)
        {
            this.estrategia = estrategia;
        }

        public void setCalificacion(int calificacion)
        {
            this.calificacion = calificacion;
        }

        public int getCalificacion()
        {
            return calificacion;
        }

        public override bool sosIgual(Comparable c)
        {
            return estrategia.sosIgual(this, c);
        }

        public override bool sosMayor(Comparable c)
        {
            return estrategia.sosMayor(this, c);
        }

        public override bool sosMenor(Comparable c)
        {
            return estrategia.sosMenor(this, c);
        }

        public virtual int reponderPregunta(int pregunta)
        {
            return GeneradorDeDatosAleatorios.numeroAleatorio(3);
        }

        public string mostrarCalificacion()
        {
            return getNombre() + " " + calificacion;
        }

        public override string ToString()
        {
            return "Alumno: " + getNombre() + " Dni: " + getDni() + " Legajo: " + legajo + " Promedio: " + promedio;
        }

        public string getName()
        {
            return getNombre();
        }

        public virtual int yourAnswerIs(int question)
        {
            return reponderPregunta(question);
        }

        public void setScore(int score)
        {
            setCalificacion(score);
        }

        public string showResult()
        {
            return mostrarCalificacion();
        }

        public bool equals(Student student)
        {
            return sosIgual((Alumno)student);
        }

        public bool lessThan(Student student)
        {
            return sosMenor((Alumno)student);
        }

        public bool greaterThan(Student student)
        {
            return sosMayor((Alumno)student);
        }
    }
}
