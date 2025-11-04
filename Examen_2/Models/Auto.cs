

namespace Examen_2.Models
{
    [Serializable]
    public class Auto
    {

        private int numeroRegistro {  get; set; }
        private string modelo { get; set; }
        private double precio;
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Auto(int registro,string modelo)
        {
            this.numeroRegistro = registro;
            this.modelo = modelo;
        }
        public int NroRegistro()
        {
            return numeroRegistro;
        }
        public override string ToString()
        {
            return $@"{numeroRegistro};{modelo}";
        }
    }
}
