using System;

namespace RepasoPersona.Core
{
    public class Persona
    {
        public string Nombre {get; private set;}
        public string Apellido {get; private set;}
        public double Efectivo {get; private set;}
        public Persona (string nombre, string apellido, double efectivo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Efectivo = efectivo;
        }
        public Persona () => Efectivo = 0;
        public void Debito(double monto)
        {
            if (monto <= 0)
            {
                throw new Exception("El monto debe ser > 0");
            }
            if (Efectivo < monto)
            {
                throw new Exception("Saldo insuficiente");
            }
            else Efectivo -= monto;
        }

        public void Acreditar(double monto)
        {
            if(monto <= 0)
            {
                throw new Exception("El monto debe ser > 0");
            }
            else Efectivo += monto;
        }
    }
}
