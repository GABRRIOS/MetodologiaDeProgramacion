using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Modelos.Comparables
{
    internal class Persona : Comparable
    {
        string nombre;
        int dni;

        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int getDni()
        {
            return this.dni;
        }

        public virtual bool sosIgual(Comparable c)
        {
            return dni == ((Persona)c).getDni();
        }

        public virtual bool sosMenor(Comparable c)
        {
            return dni > ((Persona)c).getDni();
        }

        public virtual bool sosMayor(Comparable c)
        {
            return dni < ((Persona)c).getDni();
        }

        public override string ToString()
        {
            return "Persona: " + nombre + " DNI: " + dni;
        }
    }
}
