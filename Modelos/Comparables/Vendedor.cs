using MetodologiaDeProgramacion.Interfaces;

namespace MetodologiaDeProgramacion.Modelos.Comparables
{
    internal class Vendedor : Persona, Observado
    {
        private double sueldoBasico;
        private double bonus;
        Observador gerente;

        public Vendedor(string nombre, int dni, double sueldoBasico) : base(nombre, dni)
        {
            this.sueldoBasico = sueldoBasico;
            this.bonus = 1;
            gerente = new Gerente();
        }

        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public double Bonus { get => bonus; set => bonus = value; }

        public override bool sosMenor(Comparable c)
        {
            return Bonus > ((Vendedor)c).Bonus;
        }

        public override bool sosMayor(Comparable c)
        {
            return Bonus < ((Vendedor)c).Bonus;
        }

        public void venta(double monto)
        {
            notificar(monto);
        }

        public void aumentarBonus()
        {
            this.bonus += 0.1;
        }

        public void agregarObservador(Observador o)
        {
            this.gerente = o;
        }

        public void notificar(double monto)
        {
            gerente.actualizar(monto, this);
        }

        public override string ToString()
        {
            return "Nombre: " + getNombre() + " DNI: " + getDni() + " Sueldo Basico: " + SueldoBasico + " Bonus: " + String.Format("{0:00.0}", bonus);
        }
    }
}
