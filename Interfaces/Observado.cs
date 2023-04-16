namespace MetodologiaDeProgramacion.Interfaces
{
    internal interface Observado
    {
        void agregarObservador(Observador o);
        void notificar(double monto);
    }
}
