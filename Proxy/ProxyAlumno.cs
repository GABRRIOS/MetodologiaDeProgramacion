using MetodologiaDeProgramacion.Modelos.Comparables;

namespace MetodologiaDeProgramacion.Proxy
{
    internal class ProxyAlumno : Alumno
    {
        int opcion;
        Alumno alumnoReal;

        public ProxyAlumno(string nombre, int dni, int legajo, int promedio, int opcion) : base(nombre, dni, legajo, promedio)
        {
            this.opcion = opcion;
        }

        public override int reponderPregunta(int pregunta)
        {
            if (alumnoReal == null)
            {
                if (opcion == 0)
                {
                    Console.WriteLine("Creando instancia Alumno");
                    alumnoReal = new Alumno(getNombre(), getDni(), getLegajo(), getPromedio());
                }
                else
                {
                    Console.WriteLine("Creando instancia AlumnoMuyEstudioso");
                    alumnoReal = new AlumnoMuyEstudioso(getNombre(), getDni(), getLegajo(), getPromedio());
                }
            }
            return alumnoReal.reponderPregunta(pregunta);
        }
    }
}
