

using Microsoft.Win32;

namespace Examen_2.Models
{
    [Serializable]
    public class Camion
    {
        private DateTime fecha { get; set; }
        private int capacidad { get; set; }
        private double valorAsegurado { get; set; }
        public int NroRegistro { get; set; }

        Stack<Auto> transporte = new Stack<Auto>();
        public Camion(DateTime fecha, int capacidad)
        {
            this.fecha = fecha;
            this.capacidad = capacidad;
        }

        public void CargarVehiculo(Auto unAuto)
        {
            //if (unAuto != null && transporte.Count < capacidad)
            //{
            //    transporte.Push(unAuto);
            //}
            transporte.Push(unAuto);

        }
        public Auto RetirarVehiculo()
        {
            if (transporte.Count > 0)
            {
                return transporte.Pop();
            }
            return null;
        }
        public string[] VerCarga()
        {
            string[] carga = new string[transporte.Count];

            int n = 0;
            foreach (Auto au in transporte)
            {
                carga[n] = au.ToString().Trim();
                n++;
            }
            return carga;
        }

        public double ValorAsegurado()
        {
            double valor = 0;


            foreach (Auto au in transporte)
            {
                valor += au.Precio;
            }
            return valor;
        }

        public int CantidadDeVehiculos()
        {
            return transporte.Count();
        }
        public override string ToString()
        {
            string carga = string.Join(", ", VerCarga()); // Une todos los autos en una sola línea
            return $"{NroRegistro}_{fecha:yyyyMMdd}";
        }

    }
}
