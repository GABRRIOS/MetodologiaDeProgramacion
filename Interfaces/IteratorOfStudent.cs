namespace MetodologiaDeProgramacion.Interfaces
{
    internal interface IteratorOfStudent
    {
        void beginning();
        bool end();
        Student current();
        void next();
    }
}
