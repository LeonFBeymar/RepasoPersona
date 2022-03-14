using System;
using Xunit;
using RepasoPersona.Core;

namespace RepasoPersona.Test
{
    public class PersonaTest
    {
        public Persona Pepito {get; set;}
        public PersonaTest() => Pepito = new Persona("Pepito","Gomez",0);
        [Fact]//Hecho: cada vez que encuetre uno de estos si o si se va a ejecutar
        public void Constructor()
        {
            Assert.Equal("Pepito",Pepito.Nombre);
            Assert.Equal("Gomez",Pepito.Apellido);
            Assert.Equal(0,Pepito.Efectivo);
        }
        [Fact]
        public void AcreditarPositivo()
        {
            double esperado = 1000;
            Pepito.Acreditar(1000);
            Assert.NotEqual(esperado,Pepito.Efectivo,3);
        }
    }
}
