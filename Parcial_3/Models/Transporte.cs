namespace Parcial_3.Models
{
    [Serializable]
    public class Transporte
    {
        public string Destino { get; set; }
        public double PrecioBase { get; set; }
        public string Patente { get; set; }

        public Transporte(string destino,double precio,string patente)
        {
            this.PrecioBase = precio;
            this.Destino = destino;
            this.Patente = patente;
        }
        virtual public string ToString()
        {
            return $@"{Destino}-{PrecioBase}";
        }
    }
}
