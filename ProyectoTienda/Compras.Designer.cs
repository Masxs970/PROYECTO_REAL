namespace ProyectoTienda
{
    partial class ViewCompras
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
            this.ComprasGrid = new System.Windows.Forms.DataGridView();
            this.SalirCompras = new System.Windows.Forms.Button();
            this.ComprasButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DescripcionBox = new System.Windows.Forms.TextBox();
            this.PrecioBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaBox = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ComprasGrid
            // 
            this.ComprasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComprasGrid.Location = new System.Drawing.Point(12, 12);
            this.ComprasGrid.Name = "ComprasGrid";
            this.ComprasGrid.Size = new System.Drawing.Size(408, 234);
            this.ComprasGrid.TabIndex = 0;
            // 
            // SalirCompras
            // 
            this.SalirCompras.Location = new System.Drawing.Point(345, 262);
            this.SalirCompras.Name = "SalirCompras";
            this.SalirCompras.Size = new System.Drawing.Size(75, 23);
            this.SalirCompras.TabIndex = 5;
            this.SalirCompras.Text = "Salir";
            this.SalirCompras.UseVisualStyleBackColor = true;
            this.SalirCompras.Click += new System.EventHandler(this.SalirCompras_Click);
            // 
            // ComprasButton
            // 
            this.ComprasButton.Location = new System.Drawing.Point(12, 262);
            this.ComprasButton.Name = "ComprasButton";
            this.ComprasButton.Size = new System.Drawing.Size(97, 23);
            this.ComprasButton.TabIndex = 7;
            this.ComprasButton.Text = "Mostrar Compras";
            this.ComprasButton.UseVisualStyleBackColor = true;
            this.ComprasButton.Click += new System.EventHandler(this.ComprasButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Descripcion";
            // 
            // DescripcionBox
            // 
            this.DescripcionBox.Location = new System.Drawing.Point(499, 144);
            this.DescripcionBox.Name = "DescripcionBox";
            this.DescripcionBox.Size = new System.Drawing.Size(238, 20);
            this.DescripcionBox.TabIndex = 27;
            // 
            // PrecioBox
            // 
            this.PrecioBox.Location = new System.Drawing.Point(499, 98);
            this.PrecioBox.Name = "PrecioBox";
            this.PrecioBox.Size = new System.Drawing.Size(238, 20);
            this.PrecioBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Precio";
            // 
            // ProductoBox
            // 
            this.ProductoBox.Location = new System.Drawing.Point(499, 50);
            this.ProductoBox.Name = "ProductoBox";
            this.ProductoBox.Size = new System.Drawing.Size(238, 20);
            this.ProductoBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha";
            // 
            // FechaBox
            // 
            this.FechaBox.Location = new System.Drawing.Point(499, 15);
            this.FechaBox.Name = "FechaBox";
            this.FechaBox.Size = new System.Drawing.Size(238, 20);
            this.FechaBox.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Nueva Compra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 294);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FechaBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DescripcionBox);
            this.Controls.Add(this.PrecioBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComprasButton);
            this.Controls.Add(this.SalirCompras);
            this.Controls.Add(this.ComprasGrid);
            this.Name = "ViewCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.ViewCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ComprasGrid;
        private System.Windows.Forms.Button SalirCompras;
        private System.Windows.Forms.Button ComprasButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescripcionBox;
        private System.Windows.Forms.TextBox PrecioBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaBox;
        private System.Windows.Forms.Button button1;
    }
}