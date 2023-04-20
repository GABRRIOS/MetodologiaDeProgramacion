using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Interfaces
{
    internal interface Collection
    {
        IteratorOfStudent getIterator();
        void addStudent(Student student);
        void sort();
    }
}
