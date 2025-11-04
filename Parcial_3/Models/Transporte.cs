namespace Parcial_3.Models
{
    [Serializable]
    public class Transporte
    {
        public string Destino { get; set; }
        public double PrecioBase { get; set; }

        public Transporte(string destino,double precio)
        {
            this.PrecioBase = precio;
            this.Destino = destino;
        }
        virtual public string ToString()
        {
            return $@"{Destino}-{PrecioBase}";
        }
    }
}
