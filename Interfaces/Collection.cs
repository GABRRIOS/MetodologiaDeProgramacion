namespace MetodologiaDeProgramacion.Interfaces
{
    internal interface Collection
    {
        IteratorOfStudent getIterator();
        void addStudent(Student student);
        void sort();
    }
}
