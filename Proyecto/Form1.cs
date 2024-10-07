using Proyecto.Datos;
using System.Data;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar la imagen desde los recursos
                pictureBox1.Image = Properties.Resources.img1; // Asegúrate de que 'img1' es el nombre correcto del recurso
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados en los TextBox
            string numeroDocumento = textBox1.Text; // Asumiendo que textBox1 es para el número de documento
            string carnet = textBox2.Text; // Asumiendo que textBox2 es para la contraseña

            // Crear una instancia de la clase Cliente
            Cliente datosCliente = new Cliente();



            try
            {
                // Llamar al método Log_Cli para verificar el cliente
                DataTable tablaLogin = datosCliente.Log_Cli(numeroDocumento, carnet);

                // Validar si se encontró el cliente
                if (tablaLogin.Rows.Count > 0)
                {
                    MessageBox.Show("Ingreso exitoso");


                    // Crear una instancia del nuevo formulario
                    FrmPrincipal principal = new FrmPrincipal();

                    // Pasar datos si es necesario, por ejemplo el nombre del usuario
                    //principal.usuario = txtUsuario.Text;

                    // Mostrar el nuevo formulario
                    principal.Show();

                    // Ocultar el formulario de login
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Número de documento y/o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el cliente: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
