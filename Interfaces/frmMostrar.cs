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
    public partial class frmMostrar : Form
    {
        Disco objDisco_ = new Disco();
        public frmMostrar(Disco objDisco)
        {
            objDisco_ = objDisco;
            InitializeComponent();
            pbPart1.Maximum = objDisco.tamanio[0];
            objDisco_.Mostrar();
            MessageBox.Show(Convert.ToString(objDisco.uso[0]));
            pbPart1.Value = Convert.ToInt32(objDisco.uso[0]);
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
        }
    }
}
