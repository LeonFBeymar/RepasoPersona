namespace RepasoPersona.Core
{
    public class Cuenta : EnteConSaldo
    {
        public int CBU { get; private set; }
        Persona Cliente = new Persona();
        public Cuenta(Persona cliente, int cbu)
        {
            Cliente = cliente;
            CBU = cbu;
        } 
    }
}