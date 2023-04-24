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

        public int getCalificacion()
        {
            return decorador.getCalificacion();
        }

        public int getLegajo()
        {
            return decorador.getLegajo();
        }

        public string getNombre()
        {
            return decorador.getNombre();
        }

        public virtual string mostrarCalificacion()
        {
            return decorador.mostrarCalificacion();
        }

        public void setNombre(string nombre)
        {
            decorador.setNombre(nombre);
        }
    }
}
