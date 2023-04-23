using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.ModelosAbstractos;

namespace MetodologiaDeProgramacion.Decoradores
{
    internal class DecorarLegajo : AdicionalDecorador
    {
        DecoradorCalificacion decorador;

        public DecorarLegajo(DecoradorCalificacion decorador) : base(decorador)
        {
            this.decorador = decorador;
        }

        public override string mostrarCalificacion()
        {
            ((Alumno)decorador).setNombre(((Alumno)decorador).getNombre() + "(" + ((Alumno)decorador).getLegajo() + ")");
            return base.mostrarCalificacion();
        }
    }
}
