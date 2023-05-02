using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos;

namespace MetodologiaDeProgramacion.Ordenes
{
    internal class OrdenAulaLlena : OrdenEnAula1
    {
        Aula aula;

        public OrdenAulaLlena(Aula aula)
        {
            this.aula = aula;
        }
        public void ejecutar()
        {
            aula.claseLista();
        }
    }
}
