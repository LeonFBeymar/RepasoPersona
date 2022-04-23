using System;
namespace RepasoPersona.Core
{
    public class EnteConSaldo
    {
        public virtual double Saldo { get; internal set; }// El virtual hace que se pueda modificar el valor de saldo en un futuro
        public void Debitar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");

            if (monto > Saldo)
                throw new InvalidOperationException("El monto supera al efectivo.");
            Saldo -= monto;
        }
        public void Acreditar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");
            Saldo += monto;
        }
    }
}