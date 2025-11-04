using Microsoft.VisualBasic;
using Parcial_3.Models;

namespace Parcial_3
{
    public partial class Form1 : Form
    {
        Sistema sistema = new Sistema();
        public Form1()
        {
            InitializeComponent();
        }

        VerTickets vtn = new VerTickets();

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] destinos = ["La Paz", "Parana", "Santa Fe"];
            foreach (string dts in destinos)
            {
                cbDestinos.Items.Add(dts);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                string destino = Convert.ToString(cbDestinos.SelectedItem);
                string[] transportePatente = (cbTransporte.SelectedItem as string).Split(";");

                string transporte = transportePatente[0];
                string patente = transportePatente[1];

                string cuit = tbCuit.Text;
                string nombre = tbNombre.Text;
                int telefono = Convert.ToInt32(tbTelefono.Text);
                string nTarjeta = tbTarjeta.Text;

                double precioBase = Convert.ToDouble(tbPrecio.Text);
                Cliente cliente = new Cliente(nombre, cuit, telefono, nTarjeta);

                Ticket ticketGenerado = sistema.CrearTicket(cliente, transporte, precioBase, patente, destino);

                if (ticketGenerado != null)
                {

                    MessageBox.Show($"Se creo el ticket: {ticketGenerado.NroTicket}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                tbCuit.Clear();
                tbNombre.Clear();
                tbPrecio.Clear();
                tbTarjeta.Clear();
                tbTelefono.Clear();
                cbDestinos.SelectedIndex = -1;
                cbTransporte.SelectedIndex = -1;
            }

        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            vtn.lbTicket.Items.Clear();
            List<Ticket> lista = sistema.GetTickets();
            lista.Sort();
            foreach (Ticket tck in lista)
            {
                vtn.lbTicket.Items.Add(tck);
            }

            vtn.ShowDialog();
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = ofd.FileName;
                    fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                    sr = new StreamReader(fs);

                    while (!sr.EndOfStream)
                    {
                        string linia = sr.ReadLine();
                        string[] liniasVec = linia.Split(";");
                        if (liniasVec.Length < 3)
                        {
                            MessageBox.Show($"Línea inválida: {linia}");
                            continue;
                        }
                        string destino = liniasVec[0].Trim();

                        double precio = Convert.ToDouble(liniasVec[1]);
                        string patente = liniasVec[2];

                        if (liniasVec.Length > 3)
                        {
                            string estrellas = liniasVec[3].Trim();
                            Bus bus = new Bus(patente, destino, precio, estrellas);
                            cbTransporte.Items.Add(bus.ToString());
                        }
                        else
                        {
                            Avion avion = new Avion(patente, destino, precio);
                            cbTransporte.Items.Add(avion.ToString());
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivos TXT|*.txt";
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    List<Ticket> lista = sistema.GetTickets();
                    foreach (Ticket item in lista)
                    {
                        sw.WriteLine(item.ToString());
                    }

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
