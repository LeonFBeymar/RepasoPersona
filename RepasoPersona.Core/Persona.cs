using System;
using System.Collections.Generic;
using System.Linq;

namespace RepasoPersona.Core
{
    public class Persona : EnteConSaldo
    {
        public List<Cuenta> Cuentas { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }

        public int DNI { get; private set; }
        public override double Saldo { get => base.Saldo + TotalSaldoCuentas; internal set => base.Saldo = value; }//Puede modificar la forma de utilizar el saldo
        public Persona() => Saldo = 0;
        public Persona(string nombre, string apellido, double efectivo, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Saldo = efectivo;
            DNI = dni;
            Cuentas = new List<Cuenta>(); 
        } 
        double TotalSaldoCuentas => Cuentas.Sum(c => c.Saldo );//propiedad

    }
}
