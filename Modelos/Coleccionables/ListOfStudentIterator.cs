using MetodologiaDeProgramacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos.Coleccionables
{
    internal class ListOfStudentIterator : IteratorOfStudent
    {
        private List<Student> list;
        private int index;

        public ListOfStudentIterator(List<Student> _list)
        {
            list = _list;
        }

        public void beginning()
        {
            index = 0;
        }

        public bool end()
        {
            return index >= list.Count;
        }

        public Student current()
        {
            return list[index];
        }

        public void next()
        {
            index++;
        }
    }
}
