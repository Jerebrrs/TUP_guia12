using Examen_1.Models;

namespace Guia_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Agencia agencia = new Agencia();
        private void btnTicket_Click(object sender, EventArgs e)
        {
            string dni = tbDni.Text;

            Ticket ticket = null;
            try
            {
                if (rbCliente.Checked == true)
                {
                    ticket = new Cliente(dni);
                }
                else if (rbDenuncia.Checked == true)
                {
                    string patente = tbPatente.Text;
                    Vehiculo vehiculo = new Vehiculo(patente, new Cliente(dni));
                    ticket = new Denuncia(vehiculo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbDni.Clear();
                tbPatente.Clear();
            }
            if (ticket != null)
            {
                lbTurnos.Items.Add(ticket.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] tiposVehiculos = ["1-Auto", "2-Moto", "3-Equipo de Trabajo"];

            foreach (string s in tiposVehiculos)
            {
                cbTipo.Items.Add(s);
            }

            agencia.AgregarVehiculo("ABC123", "45312756");
            agencia.AgregarVehiculo("ABC345", "35122536");
            agencia.AgregarVehiculo("AAA111", "33666336");
        }

        private void btnAtenderCliente_Click(object sender, EventArgs e)
        {
            //este examen es horrible.
        }

        private void btnAtenderDenun_Click(object sender, EventArgs e)
        {

        }

        private void btnImportarVehiculos_Click(object sender, EventArgs e)
        {

        }
    }
}
