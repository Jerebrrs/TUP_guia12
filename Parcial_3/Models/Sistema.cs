
namespace Parcial_3.Models
{
    [Serializable]
    public class Sistema
    {
        List<Ticket> tickets= new List<Ticket>();

        Transporte transporte = null;

        public Ticket CrearTicket(Cliente cliente,string tipo, double precio,string patente,string destino)
        {
            if (tipo == "Avion")
            {
                precio = precio * 1.21 * 1.30;
                transporte = new Avion(patente, destino, precio);
            }
            else
            {
                precio = precio * 1.115;
                transporte = new Avion(patente, destino, precio);
            }

            if (transporte!=null)
            {
                Ticket ticketrr = new Ticket(transporte);
                tickets.Add(ticketrr);
                return ticketrr;
            }
            return null;
        }

        public List<Ticket> GetTickets()
        {
            return tickets;
        }
    }
}
