
namespace VideoClubApp.Forms
{
    partial class FormReportes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrestamosAbiertos = new System.Windows.Forms.TabPage();
            this.tabPeliculasDisponibles = new System.Windows.Forms.TabPage();
            this.lstPrestamosAbiertos = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPrestamosAbiertos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPrestamosAbiertos);
            this.tabControl1.Controls.Add(this.tabPeliculasDisponibles);
            this.tabControl1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(93, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 358);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPrestamosAbiertos
            // 
            this.tabPrestamosAbiertos.Controls.Add(this.lstPrestamosAbiertos);
            this.tabPrestamosAbiertos.Location = new System.Drawing.Point(4, 26);
            this.tabPrestamosAbiertos.Name = "tabPrestamosAbiertos";
            this.tabPrestamosAbiertos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrestamosAbiertos.Size = new System.Drawing.Size(708, 328);
            this.tabPrestamosAbiertos.TabIndex = 0;
            this.tabPrestamosAbiertos.Text = "Prestamos Abiertos";
            this.tabPrestamosAbiertos.UseVisualStyleBackColor = true;
            this.tabPrestamosAbiertos.Click += new System.EventHandler(this.tabPrestamosAbiertos_Click);
            // 
            // tabPeliculasDisponibles
            // 
            this.tabPeliculasDisponibles.Location = new System.Drawing.Point(4, 22);
            this.tabPeliculasDisponibles.Name = "tabPeliculasDisponibles";
            this.tabPeliculasDisponibles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPeliculasDisponibles.Size = new System.Drawing.Size(708, 332);
            this.tabPeliculasDisponibles.TabIndex = 1;
            this.tabPeliculasDisponibles.Text = "Peliculas Disponibles";
            this.tabPeliculasDisponibles.UseVisualStyleBackColor = true;
            this.tabPeliculasDisponibles.Click += new System.EventHandler(this.tabPeliculasDisponibles_Click);
            // 
            // lstPrestamosAbiertos
            // 
            this.lstPrestamosAbiertos.FormattingEnabled = true;
            this.lstPrestamosAbiertos.ItemHeight = 17;
            this.lstPrestamosAbiertos.Location = new System.Drawing.Point(6, 6);
            this.lstPrestamosAbiertos.Name = "lstPrestamosAbiertos";
            this.lstPrestamosAbiertos.Size = new System.Drawing.Size(696, 310);
            this.lstPrestamosAbiertos.TabIndex = 0;
            this.lstPrestamosAbiertos.SelectedIndexChanged += new System.EventHandler(this.lstPrestamosAbiertos_SelectedIndexChanged);
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(840, 423);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormReportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPrestamosAbiertos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrestamosAbiertos;
        private System.Windows.Forms.TabPage tabPeliculasDisponibles;
        private System.Windows.Forms.ListBox lstPrestamosAbiertos;
    }
}