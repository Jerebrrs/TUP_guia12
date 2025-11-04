

namespace Parcial_3.Models
{
    [Serializable]
    public class Avion : Transporte
    {
        public string Patente { get; set; }

        public Avion(string patente, string destino, double precio) : base(destino, precio)
        {
            this.Patente = patente;
        }

        public override string ToString()
        {
            return $@"Avion;{Patente}";
        }
    }
}
