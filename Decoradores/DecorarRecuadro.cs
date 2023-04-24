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
            int valor = base.mostrarCalificacion().Length + 8;
            return new String('*', valor)
                + "\n*   " + base.mostrarCalificacion() + "   *\n"
                + new String('*', valor);
        }
    }
}
