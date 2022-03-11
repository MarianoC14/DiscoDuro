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
    public partial class frmMochadas : Form
    {
        Disco objDisco = new Disco();
        frmMenu objMenu;
        public frmMochadas()
        {
            InitializeComponent();
            txtPart1.Text = "0";
            txtPart2.Text = "0";
            txtPart3.Text = "0";
            txtPart4.Text = "0";
            txtPart5.Text = "0";
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            int cant;
            cant = Convert.ToInt32(txtPartituras.Text);
            switch(cant)
            {
                case 1: txtPart1.Visible = true; lbl_p1.Visible = true; break;
                case 2: txtPart1.Visible = true; txtPart2.Visible = true; lbl_p1.Visible = true; lbl_p2.Visible = true; break;
                case 3: txtPart1.Visible = true; txtPart2.Visible = true; txtPart3.Visible = true;
                    lbl_p1.Visible = true; lbl_p2.Visible = true; lbl_p3.Visible = true; break;
                case 4: txtPart1.Visible = true; txtPart2.Visible = true; txtPart3.Visible = true;
                    txtPart4.Visible = true; lbl_p1.Visible = true; lbl_p2.Visible = true; lbl_p3.Visible = true;
                    lbl_p4.Visible = true; break;
                case 5: txtPart1.Visible = true; txtPart2.Visible = true; txtPart3.Visible = true;
                    txtPart4.Visible = true; txtPart5.Visible = true; lbl_p1.Visible = true; lbl_p2.Visible = true; lbl_p3.Visible = true;
                    lbl_p4.Visible = true; lbl_p5.Visible = true; break;

            }
            btnAsignar.Visible = true;
            //objDisco.Establecer_Partituras(txt);
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            objDisco.Establecer_Partituras(Convert.ToInt32(txtTamanio.Text), Convert.ToInt32(txtPartituras.Text), 
                Convert.ToInt32(txtPart1.Text), Convert.ToInt32(txtPart2.Text), Convert.ToInt32(txtPart3.Text),
                Convert.ToInt32(txtPart4.Text), Convert.ToInt32(txtPart5.Text));
            objMenu = new frmMenu(objDisco);
            this.Hide();
            objMenu.Show();
        }
    }
}
