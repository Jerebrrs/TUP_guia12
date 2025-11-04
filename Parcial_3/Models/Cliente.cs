

namespace Parcial_3.Models
{
    [Serializable]
    public class Cliente
    {
        public string Nombre { get; set; }
        public long Cuit { get; set; }
        private int telefono { get; set; }
        private long nTarjeta { get; set; }

        public Cliente(string nombre, string cuit, int telefono,string ntarjeta)                                                                             
        {
            //if (cuit.Length == 11)
            //{
            //    this.Cuit = Convert.ToInt64(cuit);
            //}
            //else
            //{
            //    throw new DNIExepcion("El Cuit debe tener 11 Caracteres.");
            //}
            //if (ntarjeta.Length == 16)
            //{
            //    this.nTarjeta = Convert.ToInt64(ntarjeta);
            //}
            //else
            //{
            //    throw new TarjetaExeption("La tarjeta debe tener 16 Caracteres.");
            //}
            this.nTarjeta = Convert.ToInt64(ntarjeta);
            this.Cuit = Convert.ToInt64(cuit);
            this.Nombre = nombre;
            this.telefono=telefono;
           
        }

        public override string ToString()
        {
            return $@"{Nombre}-{Cuit}";
        }
    }
}
