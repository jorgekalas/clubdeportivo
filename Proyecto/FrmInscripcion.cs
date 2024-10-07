using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Entidades;
using Proyecto.Datos;

namespace Proyecto
{
    public partial class FrmInscripcion : Form
    {
        public FrmInscripcion()
        {
            InitializeComponent();
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.Items.Add("DNI");
            cboTipoDocumento.Items.Add("Pasaporte");
            cboTipoDocumento.Items.Add("Cédula");
            cboTipoDocumento.Items.Add("Otro");
            cboTipoDocumento.SelectedIndex = 0; // Seleccionar un valor predeterminado

            {
                try
                {
                    // Cargar la imagen desde los recursos
                    pictureBox1.Image = Properties.Resources.img2;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios estén llenos
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDocumento.Text == "" || cboTipoDocumento.Text == "")
            {
                MessageBox.Show("Debe completar los datos requeridos (*)", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una instancia del cliente
            E_Cliente nuevoCliente = new E_Cliente
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                TipoDocumento = cboTipoDocumento.Text,
                NumeroDocumento = txtDocumento.Text,
                Socio = chkSocio.Checked,
                Carnet = "CARNET" + txtDocumento.Text // Genera un carnet simple basado en el número de documento
            };

            // Crear una instancia de la clase ClientesDatos para registrar al cliente
            Clientes clientesDatos = new Clientes();
            string resultado = clientesDatos.Nuevo_Cliente(nuevoCliente);

            if (int.TryParse(resultado, out int codigo))
            {
                if (codigo == 1)
                {
                    MessageBox.Show("El cliente ya existe en el sistema.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Cliente registrado con éxito. Código: " + codigo, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Error al registrar el cliente: " + resultado, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos del formulario
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            cboTipoDocumento.SelectedIndex = -1; // Desmarcar el combo box
            chkSocio.Checked = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario de inscripción y volver al formulario principal
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
