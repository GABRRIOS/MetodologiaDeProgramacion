namespace MetodologiaDeProgramacion.Interfaces
{
    internal interface Coleccionable : Iterador
    {
        int cuantos();

        Comparable minimo();

        Comparable maximo();

        void agregar(Comparable c);

        bool contiene(Comparable c);
    }
}
