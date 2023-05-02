using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos;

namespace MetodologiaDeProgramacion.Ordenes
{
    internal class OrdenLlegaAlumno : OrdenEnAula2
    {
        Aula aula;

        public OrdenLlegaAlumno(Aula aula)
        {
            this.aula = aula;
        }
        public void ejecutar(Comparable comparable)
        {
            aula.nuevoAlumno(comparable);
        }
    }
}
