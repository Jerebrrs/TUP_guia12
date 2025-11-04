namespace Examen_2.Models
{
    [Serializable]
    public class Sistema
    {
        public int NroOrden { get; set; }
        List<Camion> listaCamiones = new List<Camion>();
        List<Auto> listaAutos = new List<Auto>();
        public Camion camion;
        public void RecibirCamion(Camion unCamion)
        {
            if (unCamion != null)
            {
               
                listaCamiones.Add(unCamion);
            }
        }

        public Auto DescarCamion(int nroOrden)
        {
            Camion camion =VerCamion(nroOrden);
            Auto auto=camion.RetirarVehiculo();
            return auto;
        }

        public int GenerarCamion(DateTime fecha, int capacidad)
        {
            Camion camion = new Camion(fecha, capacidad);
            listaCamiones.Add(camion);
            this.camion = camion;
            camion.NroRegistro = NroOrden;
         
            return camion.NroRegistro;
        }

        public void CargarCamion(int nroOrden, Auto auto)
        {
            Camion camion = VerCamion(nroOrden);
            if (camion == null)
            {
                throw new InvalidOperationException($"No Camion found with NroRegistro {nroOrden}");
            }
            camion.CargarVehiculo(auto);
            listaAutos.Add(auto);
        }

        public Camion VerCamion(int numero)
        {
            for (int n = 0; n < listaCamiones.Count; n++)
            {
                if (listaCamiones[n].NroRegistro == numero)
                    return listaCamiones[n];
            }
            return null;
        }
    }
}
