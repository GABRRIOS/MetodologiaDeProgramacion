namespace MetodologiaDeProgramacion.Modelos.Comparables
{
    internal class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, int promedio) : base(nombre, dni, legajo, promedio)
        {
        }

        public override int reponderPregunta(int opcion)
        {
            return 3;
        }

        public override int yourAnswerIs(int question)
        {
            return reponderPregunta(question);
        }
    }
}
