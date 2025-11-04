

namespace Examen_1.Models
{
    public class Cliente : Ticket
    {
        private long dni { get; set; }
        static private int numero {get; set;}
        public Cliente(string dni) 
        {
            if (dni.Length <7)
            {
                throw new ExeptionDni("El dni debe tener al menos 7 caracteres numericos.");
            }
            this.dni = Convert.ToInt64(dni);
            if (this.dni > 50000000)
            {
                throw new ExeptionDni();
            }
                nroOrden = ++numero;
        }

        override public string ToString()
        {
            return $"Cliente:{base.ToString()};{dni}";
        }
    }
}
