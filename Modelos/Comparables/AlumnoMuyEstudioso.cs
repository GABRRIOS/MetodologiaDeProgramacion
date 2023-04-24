namespace MetodologiaDeProgramacion.Modelos.Comparables
{
    internal class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, int promedio) : base(nombre, dni, legajo, promedio)
        {
        }

        public override int reponderPregunta(int pregunta)
        {
            return pregunta;
        }

        public override int yourAnswerIs(int question)
        {
            return reponderPregunta(question);
        }
    }
}
