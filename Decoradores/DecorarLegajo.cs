using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.ModelosAbstractos;

namespace MetodologiaDeProgramacion.Decoradores
{
    internal class DecorarLegajo : AdicionalDecorador
    {
        DecoradorCalificacion decorador;

        public DecorarLegajo(DecoradorCalificacion decorador) : base(decorador)
        {
            this.decorador = decorador;
            decorador.setNombre(decorador.getNombre() + "(" + decorador.getLegajo() + ")");
        }

        public override string mostrarCalificacion()
        {
            return base.mostrarCalificacion();
        }
    }
}
