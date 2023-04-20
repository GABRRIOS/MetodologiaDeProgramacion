using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
