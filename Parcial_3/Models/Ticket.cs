

namespace Parcial_3.Models
{
    [Serializable]
    public class Ticket :IComparable<Ticket>
    {
        int contador = 0;
        public double PrecioFinal { get; set; }
        public DateTime FechaCompra {  get; set; }
        public string Destino { get; set; }
        public int NroTicket { get; set; }

     
        public Ticket(Transporte transporte)
        {
            this.PrecioFinal = transporte.PrecioBase;
            this.Destino = transporte.Destino;
            this.FechaCompra = DateTime.Now;
            contador++;
            NroTicket = contador;
        }

        public override string ToString()
        {
            return $@"Ticket({NroTicket});{Destino};{FechaCompra:dd/MM/yy};${PrecioFinal:f2}";
        }

        public int CompareTo(Ticket? other)
        {
            if (other!=null)
            {
                return Destino.CompareTo(other.Destino);
            }
            return -1;
        }
    }
}
