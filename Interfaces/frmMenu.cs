using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace Interfaces
{
    public partial class frmMenu : Form
    {
        frmGuardar objGuardar;
        frmEliminar objEliminar;
        frmMostrar objMostrar;
        Disco objDisco_;
        public frmMenu(Disco objDisco)
        {
            objDisco_ = objDisco;
            InitializeComponent();
            MessageBox.Show(Convert.ToString(objDisco.tamanio[1]));
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objGuardar = new frmGuardar(objDisco_);
            this.Hide();
            objGuardar.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objEliminar = new frmEliminar(objDisco_);
            this.Hide();
            objEliminar.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            objMostrar = new frmMostrar(objDisco_);
            this.Hide();
            objMostrar.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
