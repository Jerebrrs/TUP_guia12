using Examen_2.Models;

namespace Examen_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sistema sistema = new Sistema();
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int n = 0;
                Auto auto = lbAutos.SelectedItem as Auto;

                if (auto != null)
                {
                    sistema.CargarCamion(n, auto);
                    lbAutos.Items.Remove(auto);
                    lbAutos.SelectedItem = null;
                    MessageBox.Show($"Cantidad en camión: {sistema.camion.CantidadDeVehiculos()}");

                }
                else
                {
                    MessageBox.Show("Seleccione un auto a cargar.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnCrearCamion_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = dtpFecha.Value;
                if (tbcapacidad.Text == "")
                {
                    MessageBox.Show($"Se Debe ingresar la capacidad del vehiculo");
                }
                int capacidad = Convert.ToInt32(tbcapacidad.Text);

                int nroRegistro = sistema.GenerarCamion(fecha, capacidad);
                MessageBox.Show($"Se creo el camion con el nro:{nroRegistro}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbcapacidad.Clear();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<Auto> list = new List<Auto>();

            list.Add(new Auto(199, "Audi"));
            list.Add(new Auto(120, "Cronos"));
            list.Add(new Auto(222, "Mobi"));

            foreach (Auto au in list)
            {
                lbAutos.Items.Add(au);
            }
        }

        private void btnCerrarCam_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos CSV|*.csv";

            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
               
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    //string[] autos = sistema.camion.VerCarga();
                    if (sistema.camion == null)
                    {
                        MessageBox.Show("No hay ningún camión cargado en el sistema.");
                        return;
                    }
                    sw.WriteLine(sistema.camion.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close(); 
                }
            }


        }
    }
}
