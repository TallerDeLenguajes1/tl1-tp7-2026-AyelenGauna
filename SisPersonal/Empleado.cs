namespace EspacioEmpleado
{
    public class Empleado
    {
        public enum Cargo
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador   
        }
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargo cargo;

        public string Nombre {get => nombre; set => nombre = value;}
        public string Apellido {get => apellido; set => apellido = value;}
        public DateTime FechaNacimiento {get => fechaNacimiento; set => fechaNacimiento = value;}
        public char EstadoCivil {get => estadoCivil; set => estadoCivil = value;}
        public DateTime FechaIngreso {get => fechaIngreso; set => fechaIngreso = value;}
        public double SueldoBasico {get => sueldoBasico; set => sueldoBasico = value;}
        public Cargo Cargos {get => cargo; set => cargo = value;}
    }
}