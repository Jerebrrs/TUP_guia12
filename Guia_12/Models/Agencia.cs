

namespace Examen_1.Models
{
    public class Agencia
    {
        public List<Ticket> ListaAtendidos = new List<Ticket>();
        private Queue<Cliente> nuevosCliente = new Queue<Cliente>();
        private Queue<Denuncia> denuncias = new Queue<Denuncia>();
        List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        public void AgregarTicket(Ticket turno)
        {

            if (turno != null)
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

        public void AgregarVehiculo(string patente, string dueño)
        {
            listaVehiculos.Sort();

            Vehiculo nuevo = new Vehiculo(patente, new Cliente(dueño));
            listaVehiculos.Add(nuevo);
            //Vehiculo v = new Vehiculo(patente, null);

            //int idx = listaVehiculos.BinarySearch(v);
            //if (idx != -1)
            //{
            //    throw new Exception("La pate");
            //}
            //else
            //{



            //}

        }

        public void AtenderTicket(int tipo)
        {

        }
    }
}
