using MetodologiaDeProgramacion.Estrategias;
using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Modelos.Comparables
{
    internal class Alumno : Persona
    {

        int legajo;
        int promedio;
        EstrategiaDeComparacion estrategia;

        public Alumno(string nombre, int dni, int legajo, int promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            estrategia = new EstrategiaPorDni();
        }

        public int getPromedio()
        {
            return promedio;
        }

        public int getLegajo()
        {
            return legajo;
        }

        public void setEstrategia(EstrategiaDeComparacion estrategia)
        {
            this.estrategia = estrategia;
        }

        public override bool sosIgual(Comparable c)
        {
            return estrategia.sosIgual(this, c);
        }

        public override bool sosMayor(Comparable c)
        {
            return estrategia.sosMayor(this, c);
        }

        public override bool sosMenor(Comparable c)
        {
            return estrategia.sosMenor(this, c);
        }

        public override string ToString()
        {
            return "Alumno: " + getNombre() + " Dni: " + getDni() + " Legajo: " + legajo + " Promedio: " + promedio;
        }
    }
}
