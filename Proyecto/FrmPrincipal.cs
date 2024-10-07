using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de login nuevamente
            Form1 loginForm = new Form1();
            loginForm.Show();

            // Cerrar el formulario principal
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            FrmInscripcion frmRegistrar = new FrmInscripcion();
            frmRegistrar.Show();
        }

        private void btnCobrarCuota_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad para Cobrar Cuota.");
        }

        private void btnListadoMorosos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad para Obtener Listado de Socios Morosos.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
