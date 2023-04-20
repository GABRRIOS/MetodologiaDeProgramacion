using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Modelos.Comparables
{
    internal class StudentComparer : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            if (s1.equals(s2))
                return 0;
            else
            if (s1.lessThan(s2))
                return 1;
            else
                return -1;
        }
    }
}
