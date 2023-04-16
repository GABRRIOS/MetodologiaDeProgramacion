namespace MetodologiaDeProgramacion.Interfaces
{
    internal interface Comparable
    {
        bool sosIgual(Comparable c);

        bool sosMenor(Comparable c);

        bool sosMayor(Comparable c);

        string ToString();
    }
}
