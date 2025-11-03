
namespace Examen_1.Models
{
    public class Denuncia : Ticket
    {

        private Vehiculo dominio {  get; set; }
        static int numero {  get; set; }
        public Denuncia(Vehiculo asegurado) : base(numero)
        {
            this.dominio = asegurado;
        }
    }
}
