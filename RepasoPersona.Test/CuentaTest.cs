using System;
using RepasoPersona.Core;
using Xunit;

namespace RepasoPersona.Test
{
    public class CuentaTest
    {
        public Cuenta cuentita{get;set;}

        public CuentaTest() => cuentita = new Cuenta(123456,0);

        [Fact]
        public void Constructor()
        {
            Assert.Equal(123456,cuentita.CBU);
        }
        [Fact]
        public void AcreditarPositivo()
        {
            double esperado = 1000;
            cuentita.Acreditar(esperado);
            
            Assert.Equal(esperado, cuentita.Saldo);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-157.34)]
        public void AcreditarCeroONegativo(double monto)
        {
            var ex = Assert.Throws<ArgumentException>(() => cuentita.Acreditar(0));
            Assert.Equal("El monto tiene que ser mayor a cero.", ex.Message);
        }

        [Fact]
        public void Debitar()
        {
            double monto = 500.45;
            double debito = 135.45;
            cuentita.Acreditar(monto);
            cuentita.Debitar(debito);

            Assert.Equal(monto - debito, cuentita.Saldo);
        }

        [Fact]
        public void DebitarInsuficiente()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => cuentita.Debitar(1000));
            Assert.Equal("El monto supera al efectivo.", ex.Message);
        }

        [Fact]
        public void DebitarCero()
        {
            var ex = Assert.Throws<ArgumentException>(() => cuentita.Debitar(0));
            Assert.Equal("El monto tiene que ser mayor a cero.", ex.Message);
        }

    }
}