

namespace Examen_1.Models
{
    public class Cliente : Ticket
    {
        private long dni { get; set; }
        static private int numero {get; set;}
        public Cliente(string dni) : base(numero)
        {
            this.dni = Convert.ToInt32(dni);
        }
    }
}
