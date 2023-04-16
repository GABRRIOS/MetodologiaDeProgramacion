using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Modelos
{
    internal class ClaveValor
    {

        Comparable clave;
        object valor;

        public ClaveValor(Comparable clave, object valor)
        {
            this.clave = clave;
            this.valor = valor;
        }

        public object Valor { get => valor; set => valor = value; }
        internal Comparable Clave { get => clave; set => clave = value; }
    }
}
