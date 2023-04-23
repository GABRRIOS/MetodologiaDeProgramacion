using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.ModelosAbstractos;

namespace MetodologiaDeProgramacion.Decoradores
{
    internal class DecorarRecuadro : AdicionalDecorador
    {
        DecoradorCalificacion decorador;
        public DecorarRecuadro(DecoradorCalificacion decorador) : base(decorador)
        {
            this.decorador = decorador;
        }

        public override string mostrarCalificacion()
        {
            return new String('*', base.mostrarCalificacion().Length + 8)
                + "\n*   " + base.mostrarCalificacion() + "   *\n"
                + new String('*', base.mostrarCalificacion().Length + 8);
        }
    }
}
