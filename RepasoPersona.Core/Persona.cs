using System;
using System.Collections.Generic;
using System.Linq;

namespace RepasoPersona.Core
{
    public class Persona : EnteConSaldo
    {
        public List<Cuenta> Cuentas { get; set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public int DNI { get; private set; }
        public override double Saldo => base.Saldo + TotalSaldoCuentas;//Puede modificar la forma de utilizar el saldo
        public double TotalSaldoCuentas => Cuentas.Sum(c => c.Saldo );//propiedad
        public Persona() => Saldo = 0;
        public Persona(string nombre, string apellido, double efectivo, int dni)
        {
            Cuentas = new List<Cuenta>(); 
            Nombre = nombre;
            Apellido = apellido;
            Saldo = efectivo;
            DNI = dni;
        } 
        

    }
}
