using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;
using MetodologiaDeProgramacion.ModelosAbstractos;

namespace MetodologiaDeProgramacion.Decoradores
{
    internal class DecorarPromocion : AdicionalDecorador
    {
        DecoradorCalificacion decorador;
        public DecorarPromocion(DecoradorCalificacion decorador) : base(decorador)
        {
            this.decorador = decorador;
        }

        public override string mostrarCalificacion()
        {
            String val = "";
            if (((Alumno)decorador).getCalificacion() >= 7) val = "(PROMOCION)";
            else if (((Alumno)decorador).getCalificacion() < 4) val = "(DESAPROBADO)";
            else val = "(APROBADO)";
            return base.mostrarCalificacion() + val;
        }
    }
}
