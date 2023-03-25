﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
