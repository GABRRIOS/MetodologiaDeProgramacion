using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.ModelosAbstractos;
using MetodologiaDeProgramacion.Utilidades;

namespace MetodologiaDeProgramacion.Decoradores
{
    internal class DecorarNota : AdicionalDecorador
    {

        DecoradorCalificacion decorador;
        public DecorarNota(DecoradorCalificacion decorador) : base(decorador)
        {
            this.decorador = decorador;
        }

        public override string mostrarCalificacion()
        {
            return base.mostrarCalificacion() + Utils.stringNumber(decorador.getCalificacion());
        }
    }
}
