

namespace Examen_1.Models
{
    public abstract class Ticket
    {
        protected int nroOrden { get; set; }
        private DateTime fechaHora { get; set; }

        protected Ticket(int nr)
        {
            this.nroOrden = nr;
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
    }
}
