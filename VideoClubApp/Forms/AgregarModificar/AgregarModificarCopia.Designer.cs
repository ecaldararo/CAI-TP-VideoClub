namespace VideoClubApp.Forms.AgregarModificar
{
    partial class AgregarModificarCopia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregarCopias = new System.Windows.Forms.Button();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Película";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(303, 308);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(134, 48);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarCopias
            // 
            this.btnAgregarCopias.Location = new System.Drawing.Point(303, 254);
            this.btnAgregarCopias.Name = "btnAgregarCopias";
            this.btnAgregarCopias.Size = new System.Drawing.Size(134, 48);
            this.btnAgregarCopias.TabIndex = 2;
            this.btnAgregarCopias.Text = "Agregar Copias";
            this.btnAgregarCopias.UseVisualStyleBackColor = true;
            this.btnAgregarCopias.Click += new System.EventHandler(this.btnAgregarCopias_Click);
            // 
            // txtPelicula
            // 
            this.txtPelicula.Enabled = false;
            this.txtPelicula.Location = new System.Drawing.Point(303, 86);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(134, 22);
            this.txtPelicula.TabIndex = 3;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(303, 148);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(134, 22);
            this.txtObservaciones.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Observaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de Copias";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(303, 209);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(134, 22);
            this.txtCantidad.TabIndex = 6;
            // 
            // AgregarModificarCopia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtPelicula);
            this.Controls.Add(this.btnAgregarCopias);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Name = "AgregarModificarCopia";
            this.Text = "Agregar/Modificar Copia";
            this.Load += new System.EventHandler(this.AgregarModificarCopia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarCopias;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}