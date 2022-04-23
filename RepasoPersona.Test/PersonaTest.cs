using System;
using RepasoPersona.Core;
using Xunit;
using System.Collections.Generic;

namespace RepasoPersona.Test
{
    public class PersonaTest
    {
    
        public Persona Pepito { get; set; }//Se comoporta como una variable
        
        public PersonaTest() => Pepito = new Persona("Juan", "Gomez", 0, 2450043);
        [Fact]
        public void Constructor()//metodo de prueba que se llama constructor
        {
            Assert.Equal("Juan", Pepito.Nombre);
            Assert.Equal("Gomez", Pepito.Apellido);
            Assert.Equal(0, Pepito.Saldo);
            Assert.Equal(2450043, Pepito.DNI);
            
        }
        [Fact]
        public void AcreditarPositivo()
        {
            double esperado = 1000;
            Pepito.Acreditar(esperado);
            
            Assert.Equal(esperado, Pepito.Saldo, 3);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-157.34)]
        public void AcreditarCeroONegativo(double monto)
        {
            var ex = Assert.Throws<ArgumentException>(() => Pepito.Acreditar(0));
            Assert.Equal("El monto tiene que ser mayor a cero.", ex.Message);
        }

        [Fact]
        public void Debitar()
        {
            double monto = 500.45;
            double debito = 135.45;
            Pepito.Acreditar(monto);
            Pepito.Debitar(debito);

            Assert.Equal(monto - debito, Pepito.Saldo, 2);
        }

        [Fact]
        public void DebitarInsuficiente()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => Pepito.Debitar(1000));
            Assert.Equal("El monto supera al efectivo.", ex.Message);
        }

        [Fact]
        public void DebitarCero()
        {
            var ex = Assert.Throws<ArgumentException>(() => Pepito.Debitar(0));
            Assert.Equal("El monto tiene que ser mayor a cero.", ex.Message);
        }

        public Cuenta cuenta1 { get; set; } 
        public Cuenta cuenta2 { get; set; }
        [Fact]
        public double SumaCuentas()
        {
            cuenta1 = new Cuenta(1241, 400);
            cuenta2 = new Cuenta(31241, 787);
            return Pepito.TotalSaldoCuentas;
        }
    }
}
