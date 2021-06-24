namespace VideoClubApp.Forms
{
    partial class FormPrestamos
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAgregarPrestamo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.listPrestamos = new System.Windows.Forms.ListBox();
            this.btnId = new System.Windows.Forms.Button();
            this.btnTítulo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnRecibirPrestamo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(579, 48);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(51, 34);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Buscar";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(28, 225);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 45);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Préstamo";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(146, 53);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(101, 29);
            this.txtId.TabIndex = 6;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(28, 36);
            this.btnAgregarPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(91, 58);
            this.btnAgregarPrestamo.TabIndex = 3;
            this.btnAgregarPrestamo.Text = "Agregar Prestamo";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = true;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Título";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(309, 51);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(101, 29);
            this.txtTitulo.TabIndex = 12;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(475, 51);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(101, 29);
            this.txtCliente.TabIndex = 13;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // listPrestamos
            // 
            this.listPrestamos.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPrestamos.FormattingEnabled = true;
            this.listPrestamos.ItemHeight = 17;
            this.listPrestamos.Location = new System.Drawing.Point(147, 98);
            this.listPrestamos.Margin = new System.Windows.Forms.Padding(2);
            this.listPrestamos.Name = "listPrestamos";
            this.listPrestamos.Size = new System.Drawing.Size(607, 225);
            this.listPrestamos.TabIndex = 14;
            this.listPrestamos.SelectedIndexChanged += new System.EventHandler(this.listPrestamos_SelectedIndexChanged);
            // 
            // btnId
            // 
            this.btnId.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnId.Location = new System.Drawing.Point(250, 48);
            this.btnId.Margin = new System.Windows.Forms.Padding(2);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(51, 34);
            this.btnId.TabIndex = 15;
            this.btnId.Text = "Buscar";
            this.btnId.UseVisualStyleBackColor = true;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // btnTítulo
            // 
            this.btnTítulo.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTítulo.Location = new System.Drawing.Point(413, 48);
            this.btnTítulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTítulo.Name = "btnTítulo";
            this.btnTítulo.Size = new System.Drawing.Size(51, 34);
            this.btnTítulo.TabIndex = 16;
            this.btnTítulo.Text = "Buscar";
            this.btnTítulo.UseVisualStyleBackColor = true;
            this.btnTítulo.Click += new System.EventHandler(this.btnTitulo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(662, 26);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 30);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(28, 274);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 46);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(662, 61);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(91, 31);
            this.btnOrdenar.TabIndex = 19;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnRecibirPrestamo
            // 
            this.btnRecibirPrestamo.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibirPrestamo.Location = new System.Drawing.Point(28, 98);
            this.btnRecibirPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecibirPrestamo.Name = "btnRecibirPrestamo";
            this.btnRecibirPrestamo.Size = new System.Drawing.Size(91, 58);
            this.btnRecibirPrestamo.TabIndex = 20;
            this.btnRecibirPrestamo.Text = "Recibir Prestamo";
            this.btnRecibirPrestamo.UseVisualStyleBackColor = true;
            this.btnRecibirPrestamo.Click += new System.EventHandler(this.btnRecibirPrestamo_Click);
            // 
            // FormPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(788, 366);
            this.Controls.Add(this.btnRecibirPrestamo);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnTítulo);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.listPrestamos);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAgregarPrestamo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamos";
            this.Load += new System.EventHandler(this.FormPrestamos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAgregarPrestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ListBox listPrestamos;
        private System.Windows.Forms.Button btnId;
        private System.Windows.Forms.Button btnTítulo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnRecibirPrestamo;
    }
}