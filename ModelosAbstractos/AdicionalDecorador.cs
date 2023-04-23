using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.ModelosAbstractos
{
    abstract class AdicionalDecorador : DecoradorCalificacion
    {
        private DecoradorCalificacion decorador;

        public AdicionalDecorador(DecoradorCalificacion decorador)
        {
            this.decorador = decorador;
        }
        public virtual string mostrarCalificacion()
        {
            return decorador.mostrarCalificacion();
        }
    }
}
