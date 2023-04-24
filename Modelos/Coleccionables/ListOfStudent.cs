using MetodologiaDeProgramacion.Interfaces;
using MetodologiaDeProgramacion.Modelos.Comparables;

namespace MetodologiaDeProgramacion.Modelos.Coleccionables
{
    internal class ListOfStudent : Collection
    {
        private List<Student> list = new List<Student>();

        public IteratorOfStudent getIterator()
        {
            return new ListOfStudentIterator(list);
        }

        public void addStudent(Student student)
        {
            list.Add(student);
        }

        public void sort()
        {
            list.Sort(new StudentComparer());
        }
    }
}
