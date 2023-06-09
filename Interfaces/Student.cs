﻿namespace MetodologiaDeProgramacion.Interfaces
{
    internal interface Student
    {
        string getName();
        int yourAnswerIs(int question);
        void setScore(int score);
        string showResult();
        bool equals(Student student);
        bool lessThan(Student student);
        bool greaterThan(Student student);
    }
}
