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
    public partial class frmGuardar : Form
    {
        Disco objDisco_ = new Disco();
        public frmGuardar(Disco objDisco)
        {
            objDisco_ = objDisco;
            InitializeComponent();
        }

        private void frmGuardar_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objDisco_.Guardar(txtPartitura.Text, txtNombre.Text, txtTamanio.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu objMenu = new frmMenu(objDisco_);
            objMenu.Show();
        }
    }
}
