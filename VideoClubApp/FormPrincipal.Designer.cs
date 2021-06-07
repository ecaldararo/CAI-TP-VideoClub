
namespace VideoClubApp
{
    partial class FormPrincipal
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
            this.botonPeliculas = new System.Windows.Forms.Button();
            this.botonPrestamos = new System.Windows.Forms.Button();
            this.botonClientes = new System.Windows.Forms.Button();
            this.botonReportes = new System.Windows.Forms.Button();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.tituloPrincipal = new System.Windows.Forms.Label();
            this.panelInteraccion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIzquierdo.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonPeliculas
            // 
            this.botonPeliculas.BackColor = System.Drawing.SystemColors.Control;
            this.botonPeliculas.Font = new System.Drawing.Font("Oswald", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPeliculas.Location = new System.Drawing.Point(3, 92);
            this.botonPeliculas.Margin = new System.Windows.Forms.Padding(4);
            this.botonPeliculas.Name = "botonPeliculas";
            this.botonPeliculas.Size = new System.Drawing.Size(212, 64);
            this.botonPeliculas.TabIndex = 17;
            this.botonPeliculas.Text = "Películas";
            this.botonPeliculas.UseVisualStyleBackColor = true;
            this.botonPeliculas.Click += new System.EventHandler(this.botonPeliculas_Click);
            // 
            // botonPrestamos
            // 
            this.botonPrestamos.Font = new System.Drawing.Font("Oswald", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPrestamos.Location = new System.Drawing.Point(3, 164);
            this.botonPrestamos.Margin = new System.Windows.Forms.Padding(4);
            this.botonPrestamos.Name = "botonPrestamos";
            this.botonPrestamos.Size = new System.Drawing.Size(212, 62);
            this.botonPrestamos.TabIndex = 18;
            this.botonPrestamos.Text = "Préstamos";
            this.botonPrestamos.UseVisualStyleBackColor = true;
            this.botonPrestamos.Click += new System.EventHandler(this.botonPrestamos_Click);
            // 
            // botonClientes
            // 
            this.botonClientes.Font = new System.Drawing.Font("Oswald", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonClientes.Location = new System.Drawing.Point(3, 234);
            this.botonClientes.Margin = new System.Windows.Forms.Padding(4);
            this.botonClientes.Name = "botonClientes";
            this.botonClientes.Size = new System.Drawing.Size(212, 62);
            this.botonClientes.TabIndex = 21;
            this.botonClientes.Text = "Clientes";
            this.botonClientes.UseVisualStyleBackColor = true;
            this.botonClientes.Click += new System.EventHandler(this.botonClientes_Click);
            // 
            // botonReportes
            // 
            this.botonReportes.Font = new System.Drawing.Font("Oswald", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReportes.Location = new System.Drawing.Point(3, 304);
            this.botonReportes.Margin = new System.Windows.Forms.Padding(4);
            this.botonReportes.Name = "botonReportes";
            this.botonReportes.Size = new System.Drawing.Size(212, 62);
            this.botonReportes.TabIndex = 20;
            this.botonReportes.Text = "Reportes";
            this.botonReportes.UseVisualStyleBackColor = true;
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.SystemColors.Window;
            this.panelIzquierdo.Controls.Add(this.label1);
            this.panelIzquierdo.Controls.Add(this.botonPrestamos);
            this.panelIzquierdo.Controls.Add(this.botonPeliculas);
            this.panelIzquierdo.Controls.Add(this.botonClientes);
            this.panelIzquierdo.Controls.Add(this.botonReportes);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(222, 625);
            this.panelIzquierdo.TabIndex = 22;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.SystemColors.Window;
            this.panelSuperior.Controls.Add(this.tituloPrincipal);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(222, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(994, 69);
            this.panelSuperior.TabIndex = 23;
            // 
            // tituloPrincipal
            // 
            this.tituloPrincipal.AutoSize = true;
            this.tituloPrincipal.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloPrincipal.Location = new System.Drawing.Point(392, 19);
            this.tituloPrincipal.Name = "tituloPrincipal";
            this.tituloPrincipal.Size = new System.Drawing.Size(0, 41);
            this.tituloPrincipal.TabIndex = 0;
            // 
            // panelInteraccion
            // 
            this.panelInteraccion.BackColor = System.Drawing.SystemColors.Window;
            this.panelInteraccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInteraccion.Location = new System.Drawing.Point(222, 69);
            this.panelInteraccion.Name = "panelInteraccion";
            this.panelInteraccion.Size = new System.Drawing.Size(994, 556);
            this.panelInteraccion.TabIndex = 24;
            this.panelInteraccion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInteraccion_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 51);
            this.label1.TabIndex = 22;
            this.label1.Text = "VideoClub";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 625);
            this.Controls.Add(this.panelInteraccion);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelIzquierdo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.panelIzquierdo.ResumeLayout(false);
            this.panelIzquierdo.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonPeliculas;
        private System.Windows.Forms.Button botonPrestamos;
        private System.Windows.Forms.Button botonClientes;
        private System.Windows.Forms.Button botonReportes;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label tituloPrincipal;
        private System.Windows.Forms.Panel panelInteraccion;
        private System.Windows.Forms.Label label1;
    }
}

