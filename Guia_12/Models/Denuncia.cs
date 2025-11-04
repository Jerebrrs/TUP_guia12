
namespace Examen_1.Models
{
    public class Denuncia : Ticket
    {

        private Vehiculo dominio {  get; set; }
        static int numero {  get; set; }
        public Denuncia(Vehiculo asegurado)
        {
            this.dominio = asegurado;
            nroOrden = ++numero;
        }

        override public string ToString()
        {
            return $"DENUNCIA:{base.ToString()};{dominio.ToString()}";
        }
    }
}
