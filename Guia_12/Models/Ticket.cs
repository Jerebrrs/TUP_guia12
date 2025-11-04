

namespace Examen_1.Models
{
    public abstract class Ticket
    {
        protected int nroOrden { get; set; }
        private DateTime fechaHora { get; set; }

        public Ticket()
        {
            this.fechaHora= DateTime.Now;
        }
        public int VerNumero()
        {
            return nroOrden;
        }
        public DateTime VerFechaHora()
        {
            return fechaHora;
        }

        override public string ToString()
        {
            return $"TCK({VerNumero()});{VerFechaHora():d/M/yyyy}";
        }
    }
}
