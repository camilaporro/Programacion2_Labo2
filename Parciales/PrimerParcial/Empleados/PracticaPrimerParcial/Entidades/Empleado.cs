namespace Entidades
{
    abstract public class Empleado
    {
        protected TimeSpan horaEgreso;
        protected TimeSpan horaIngreso;
        protected string legajo;
        protected string nombre;

        

        protected Empleado(string legajo, string nombre, TimeSpan horaIngreso)
        {
            this.horaIngreso = horaIngreso;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public TimeSpan HoraEgreso
        {
            get { return this.horaEgreso; }
            set 
            {
                if (ValidaHoraEgreso(value) == value)
                {
                    this.horaEgreso = value;
                }
            }
        }

        public TimeSpan HoraIngreso
        {
            get { return this.horaIngreso; }
        }

        public string Legajo
        {
            get { return this.legajo; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public abstract string EmitirFactura();

        protected virtual double Facturar()
        {
            return (this.HoraEgreso - this.HoraIngreso).TotalHours;
        }

        private TimeSpan ValidaHoraEgreso(TimeSpan horaEgreso) 
        {
            if (horaEgreso > this.HoraIngreso)
            {
                return horaEgreso;
            }
            else { return DateTime.Now.TimeOfDay; }
        }

        public static bool operator ==(Empleado emp1, Empleado emp2)
        {
            if (emp1 is null || emp2 is null)
            {
                return false;
            }

            else { return emp1.legajo == emp2.legajo; }
            
        }

        public static bool operator !=(Empleado emp1, Empleado emp2)
        {
            return !(emp1 == emp2);
        }

    }
}