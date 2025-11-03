

namespace Examen_1.Models
{
    public class Agencia
    {
        public List<Ticket> ListaAtendidos = new List<Ticket>();
        private Queue<Cliente> nuevosCliente = new Queue<Cliente>();
        private Queue<Denuncia> denuncias = new Queue<Denuncia>();
        private Queue<Vehiculo> listaVehiculo = new Queue<Vehiculo>();

        public void AgregarTicket(Ticket turno)
        {

            if (turno !=null)
            {
                if (turno is Cliente)
                {
                    nuevosCliente.Enqueue((Cliente)turno);
                }
                else
                {
                    denuncias.Enqueue((Denuncia)turno);
                }
            }
           
        }
    }
}
