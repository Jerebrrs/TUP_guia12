

namespace Parcial_3.Models
{
    [Serializable]
    public class Avion : Transporte
    {

        public Avion(string patente, string destino, double precio) : base(destino, precio,patente)
        {
            this.Patente = patente;
        }

        public override string ToString()
        {
            return $@"Avion;{Patente}";
        }
    }
}
