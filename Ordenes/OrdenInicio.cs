using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos;

namespace MetodologiaDeProgramacion.Ordenes
{
    internal class OrdenInicio : OrdenEnAula1
    {
        Aula aula;

        public OrdenInicio(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar()
        {
            aula.comenzar();
        }
    }
}
