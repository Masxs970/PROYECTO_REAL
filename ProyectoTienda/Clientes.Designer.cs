namespace ProyectoTienda
{
    partial class ViewClientes
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
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ApellidoBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dniBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telBox = new System.Windows.Forms.TextBox();
            this.FacturacionClientes = new System.Windows.Forms.Button();
            this.SalirClientes = new System.Windows.Forms.Button();
            this.ClientesGrid = new System.Windows.Forms.DataGridView();
            this.MostrarClientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DireccionBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(462, 12);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(238, 20);
            this.NombreBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // ApellidoBox
            // 
            this.ApellidoBox.Location = new System.Drawing.Point(462, 66);
            this.ApellidoBox.Name = "ApellidoBox";
            this.ApellidoBox.Size = new System.Drawing.Size(238, 20);
            this.ApellidoBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI";
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(462, 124);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(238, 20);
            this.dniBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono";
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(462, 291);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(238, 20);
            this.telBox.TabIndex = 8;
            // 
            // FacturacionClientes
            // 
            this.FacturacionClientes.Location = new System.Drawing.Point(210, 254);
            this.FacturacionClientes.Name = "FacturacionClientes";
            this.FacturacionClientes.Size = new System.Drawing.Size(92, 23);
            this.FacturacionClientes.TabIndex = 9;
            this.FacturacionClientes.Text = "Facturación";
            this.FacturacionClientes.UseVisualStyleBackColor = true;
            this.FacturacionClientes.Click += new System.EventHandler(this.FacturacionClientes_Click);
            // 
            // SalirClientes
            // 
            this.SalirClientes.Location = new System.Drawing.Point(210, 298);
            this.SalirClientes.Name = "SalirClientes";
            this.SalirClientes.Size = new System.Drawing.Size(92, 23);
            this.SalirClientes.TabIndex = 10;
            this.SalirClientes.Text = "Salir";
            this.SalirClientes.UseVisualStyleBackColor = true;
            this.SalirClientes.Click += new System.EventHandler(this.SalirClientes_Click);
            // 
            // ClientesGrid
            // 
            this.ClientesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesGrid.Location = new System.Drawing.Point(12, 12);
            this.ClientesGrid.Name = "ClientesGrid";
            this.ClientesGrid.ReadOnly = true;
            this.ClientesGrid.Size = new System.Drawing.Size(382, 226);
            this.ClientesGrid.TabIndex = 12;
            // 
            // MostrarClientes
            // 
            this.MostrarClientes.Location = new System.Drawing.Point(66, 298);
            this.MostrarClientes.Name = "MostrarClientes";
            this.MostrarClientes.Size = new System.Drawing.Size(91, 23);
            this.MostrarClientes.TabIndex = 13;
            this.MostrarClientes.Text = "Mostrar Clientes";
            this.MostrarClientes.UseVisualStyleBackColor = true;
            this.MostrarClientes.Click += new System.EventHandler(this.MostrarClientes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Nuevo Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DireccionBox
            // 
            this.DireccionBox.Location = new System.Drawing.Point(462, 181);
            this.DireccionBox.Name = "DireccionBox";
            this.DireccionBox.Size = new System.Drawing.Size(238, 20);
            this.DireccionBox.TabIndex = 15;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(462, 237);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(238, 20);
            this.EmailBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email";
            // 
            // ViewClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 333);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.DireccionBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MostrarClientes);
            this.Controls.Add(this.ClientesGrid);
            this.Controls.Add(this.SalirClientes);
            this.Controls.Add(this.FacturacionClientes);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dniBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ApellidoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreBox);
            this.Controls.Add(this.label1);
            this.Name = "ViewClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ApellidoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.Button FacturacionClientes;
        private System.Windows.Forms.Button SalirClientes;
        private System.Windows.Forms.DataGridView ClientesGrid;
        private System.Windows.Forms.Button MostrarClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DireccionBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}