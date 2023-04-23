using MetodologiaDeProgramacion.Decoradores;
using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Utilidades
{
    static class UtilsDecorators
    {

        public static DecoradorCalificacion aplicarDecoradoPorLegajo(DecoradorCalificacion dc)
        {
            return new DecorarLegajo(dc);
        }

        public static DecoradorCalificacion aplicarDecoradoPorNota(DecoradorCalificacion dc)
        {
            return new DecorarNota(dc);
        }

        public static DecoradorCalificacion aplicarDecoradoPorPromocion(DecoradorCalificacion dc)
        {
            return new DecorarPromocion(dc);
        }
        public static DecoradorCalificacion aplicarDecoradoPorRecuadro(DecoradorCalificacion dc)
        {
            return new DecorarRecuadro(dc);
        }
    }
}
