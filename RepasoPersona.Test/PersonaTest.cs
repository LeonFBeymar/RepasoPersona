using System;
using Xunit;
using RepasoPersona.Core;

namespace RepasoPersona.Test
{
    public class PersonaTest
    {
        public Persona Pepito {get; set;}
        [Fact]
        public void Constructor()
        {
            Pepito = new Persona("Pepito","Gomez",0);
            Assert.Equal("Pepito",Pepito.Nombre);
            Assert.Equal("Gomez",Pepito.Apellido);
            Assert.Equal(0,Pepito.Efectivo);
        }
    }
}
