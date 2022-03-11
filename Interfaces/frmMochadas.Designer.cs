
namespace Interfaces
{
    partial class frmMochadas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartituras = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_p1 = new System.Windows.Forms.Label();
            this.lbl_p3 = new System.Windows.Forms.Label();
            this.lbl_p2 = new System.Windows.Forms.Label();
            this.lbl_p4 = new System.Windows.Forms.Label();
            this.lbl_p5 = new System.Windows.Forms.Label();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.txtPart1 = new System.Windows.Forms.TextBox();
            this.txtPart2 = new System.Windows.Forms.TextBox();
            this.txtPart3 = new System.Windows.Forms.TextBox();
            this.txtPart4 = new System.Windows.Forms.TextBox();
            this.txtPart5 = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce total de partituras: ";
            // 
            // txtPartituras
            // 
            this.txtPartituras.Location = new System.Drawing.Point(314, 96);
            this.txtPartituras.Name = "txtPartituras";
            this.txtPartituras.Size = new System.Drawing.Size(100, 22);
            this.txtPartituras.TabIndex = 1;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(252, 160);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(91, 32);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Introuce tamaño del disco: ";
            // 
            // lbl_p1
            // 
            this.lbl_p1.AutoSize = true;
            this.lbl_p1.Location = new System.Drawing.Point(132, 222);
            this.lbl_p1.Name = "lbl_p1";
            this.lbl_p1.Size = new System.Drawing.Size(133, 17);
            this.lbl_p1.TabIndex = 4;
            this.lbl_p1.Text = "Tamaño partitura 1:";
            this.lbl_p1.Visible = false;
            // 
            // lbl_p3
            // 
            this.lbl_p3.AutoSize = true;
            this.lbl_p3.Location = new System.Drawing.Point(132, 289);
            this.lbl_p3.Name = "lbl_p3";
            this.lbl_p3.Size = new System.Drawing.Size(133, 17);
            this.lbl_p3.TabIndex = 6;
            this.lbl_p3.Text = "Tamaño partitura 3:";
            this.lbl_p3.Visible = false;
            // 
            // lbl_p2
            // 
            this.lbl_p2.AutoSize = true;
            this.lbl_p2.Location = new System.Drawing.Point(132, 259);
            this.lbl_p2.Name = "lbl_p2";
            this.lbl_p2.Size = new System.Drawing.Size(133, 17);
            this.lbl_p2.TabIndex = 5;
            this.lbl_p2.Text = "Tamaño partitura 2:";
            this.lbl_p2.Visible = false;
            // 
            // lbl_p4
            // 
            this.lbl_p4.AutoSize = true;
            this.lbl_p4.Location = new System.Drawing.Point(132, 323);
            this.lbl_p4.Name = "lbl_p4";
            this.lbl_p4.Size = new System.Drawing.Size(133, 17);
            this.lbl_p4.TabIndex = 7;
            this.lbl_p4.Text = "Tamaño partitura 4:";
            this.lbl_p4.Visible = false;
            // 
            // lbl_p5
            // 
            this.lbl_p5.AutoSize = true;
            this.lbl_p5.Location = new System.Drawing.Point(132, 350);
            this.lbl_p5.Name = "lbl_p5";
            this.lbl_p5.Size = new System.Drawing.Size(133, 17);
            this.lbl_p5.TabIndex = 8;
            this.lbl_p5.Text = "Tamaño partitura 5:";
            this.lbl_p5.Visible = false;
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(314, 56);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(100, 22);
            this.txtTamanio.TabIndex = 9;
            // 
            // txtPart1
            // 
            this.txtPart1.Location = new System.Drawing.Point(314, 219);
            this.txtPart1.Name = "txtPart1";
            this.txtPart1.Size = new System.Drawing.Size(100, 22);
            this.txtPart1.TabIndex = 10;
            this.txtPart1.Visible = false;
            // 
            // txtPart2
            // 
            this.txtPart2.Location = new System.Drawing.Point(314, 254);
            this.txtPart2.Name = "txtPart2";
            this.txtPart2.Size = new System.Drawing.Size(100, 22);
            this.txtPart2.TabIndex = 11;
            this.txtPart2.Visible = false;
            // 
            // txtPart3
            // 
            this.txtPart3.Location = new System.Drawing.Point(314, 284);
            this.txtPart3.Name = "txtPart3";
            this.txtPart3.Size = new System.Drawing.Size(100, 22);
            this.txtPart3.TabIndex = 12;
            this.txtPart3.Visible = false;
            // 
            // txtPart4
            // 
            this.txtPart4.Location = new System.Drawing.Point(314, 317);
            this.txtPart4.Name = "txtPart4";
            this.txtPart4.Size = new System.Drawing.Size(100, 22);
            this.txtPart4.TabIndex = 13;
            this.txtPart4.Visible = false;
            // 
            // txtPart5
            // 
            this.txtPart5.Location = new System.Drawing.Point(314, 350);
            this.txtPart5.Name = "txtPart5";
            this.txtPart5.Size = new System.Drawing.Size(100, 22);
            this.txtPart5.TabIndex = 14;
            this.txtPart5.Visible = false;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(252, 388);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(103, 34);
            this.btnAsignar.TabIndex = 15;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Visible = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // frmMochadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txtPart5);
            this.Controls.Add(this.txtPart4);
            this.Controls.Add(this.txtPart3);
            this.Controls.Add(this.txtPart2);
            this.Controls.Add(this.txtPart1);
            this.Controls.Add(this.txtTamanio);
            this.Controls.Add(this.lbl_p5);
            this.Controls.Add(this.lbl_p4);
            this.Controls.Add(this.lbl_p3);
            this.Controls.Add(this.lbl_p2);
            this.Controls.Add(this.lbl_p1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtPartituras);
            this.Controls.Add(this.label1);
            this.Name = "frmMochadas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPartituras;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_p1;
        private System.Windows.Forms.Label lbl_p3;
        private System.Windows.Forms.Label lbl_p2;
        private System.Windows.Forms.Label lbl_p4;
        private System.Windows.Forms.Label lbl_p5;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.TextBox txtPart1;
        private System.Windows.Forms.TextBox txtPart2;
        private System.Windows.Forms.TextBox txtPart3;
        private System.Windows.Forms.TextBox txtPart4;
        private System.Windows.Forms.TextBox txtPart5;
        private System.Windows.Forms.Button btnAsignar;
    }
}

