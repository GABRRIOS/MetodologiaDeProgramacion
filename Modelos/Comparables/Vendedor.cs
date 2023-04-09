using MetodologiaDeProgramacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiaDeProgramacion.Modelos.Comparables
{
    internal class Vendedor : Persona
    {
        private double sueldoBasico;
        private double bonus;

        public Vendedor(string nombre, int dni, double sueldoBasico) : base(nombre, dni)
        {
            this.sueldoBasico = sueldoBasico;
            this.bonus = 1;
        }

        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public double Bonus { get => bonus; set => bonus = value; } 

        public override bool sosIgual(Comparable c)
        {
            return Bonus == ((Vendedor)c).Bonus;
        }

        public override bool sosMenor(Comparable c)
        {
            return Bonus > ((Vendedor)c).Bonus;
        }

        public override bool sosMayor(Comparable c)
        {
            return Bonus < ((Vendedor)c).Bonus;
        }

        public void venta(decimal monto)
        {
            Console.WriteLine(monto);
        }

        public void aumentarBonus()
        {
            bonus = bonus + 0.1;
        }

        public override string ToString()
        {
            return "Persona: " + getNombre() + " DNI: " + getDni() + " Sueldo Basico: " + SueldoBasico + " Bonus: " + Bonus;
        }
    }
}
