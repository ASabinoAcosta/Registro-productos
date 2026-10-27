namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            txtStock = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMarca = new TextBox();
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnNuevo = new Button();
            label6 = new Label();
            txtPrecio = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 30);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(92, 33);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(122, 23);
            txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 36);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Código";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(122, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(92, 171);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(122, 23);
            txtStock.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 219);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 8;
            label5.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 78);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 174);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Stock";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(92, 216);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(122, 23);
            txtMarca.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnInsertar);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Location = new Point(103, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(633, 344);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Producto";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(82, 245);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(132, 54);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(397, 153);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 47);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(440, 78);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 23);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(326, 75);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(108, 23);
            btnInsertar.TabIndex = 11;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(440, 32);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(99, 23);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(326, 32);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(108, 23);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 122);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 16;
            label6.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(92, 119);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(122, 23);
            txtPrecio.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtStock;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox txtMarca;
        private GroupBox groupBox1;
        private Button btnNuevo;
        private Button btnBuscar;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnInsertar;
        private Button btnActualizar;
        private Label label6;
        private TextBox txtPrecio;
    }
}
