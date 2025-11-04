

namespace Parcial_3.Models
{
    [Serializable]
    public class Bus : Transporte
    {
        public string Patente { get; set; }
        public string Estrellas { get; set; }
        public Bus(string patente,string destino, double precio, string estrellas) : base(destino, precio)
        {
            this.Patente = patente;
            this.Estrellas = estrellas;
        }
        public override string ToString()
        {
            return $@"Bus;{Patente}";
        }
    }
}
