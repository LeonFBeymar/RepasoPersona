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
        public override double Saldo { get => base.Saldo + TotalSaldoCuentas; internal set => base.Saldo = value; }//
        public Persona() => Saldo = 0;
        public Persona(string nombre, string apellido, double efectivo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Saldo = efectivo;
            Cuentas = new List<Cuenta>(); 
        } 
        double TotalSaldoCuentas => Cuentas.Sum(c => c.Saldo );//propiedad

    }
}
