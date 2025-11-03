
namespace Examen_1.Models
{
    public class Vehiculo
    {
        private string nroPatente { get;set; }
        private Cliente dueño { get; set; }

        public Vehiculo(string patente, Cliente dueño)
        {
            this.nroPatente = patente;
            this.dueño = dueño;
        }


        public Cliente VerDueño()
        {

            if (this.dueño!=null)
            {
                return dueño;
            }
            return null;
        }


        public string Verpatente()
        {

            if (this.nroPatente != null)
            {
                return nroPatente;
            }
            return null;
        }
    }
}
