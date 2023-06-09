﻿using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Modelos.Comparables
{
    internal class Numero : Comparable
    {
        private int valor;

        public Numero(int v)
        {
            valor = v;
        }

        public int getValor()
        {
            return valor;
        }

        public bool sosIgual(Comparable c)
        {
            return valor == ((Numero)c).getValor();
        }

        public bool sosMayor(Comparable c)
        {
            return valor > ((Numero)c).getValor();
        }

        public bool sosMenor(Comparable c)
        {
            return valor < ((Numero)c).getValor();
        }

        public override string ToString()
        {
            return "Numero: " + valor;
        }
    }
}
