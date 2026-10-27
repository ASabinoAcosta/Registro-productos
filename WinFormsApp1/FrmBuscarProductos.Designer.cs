namespace WinFormsApp1
{
    partial class FrmBuscarProductos
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
            cmbFiltro = new ComboBox();
            txtFiltro = new TextBox();
            btnEnviar = new Button();
            btnBuscar = new Button();
            dgvResultados = new DataGridView();
            txtTotal = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // cmbFiltro
            // 
            cmbFiltro.BackColor = Color.White;
            cmbFiltro.FlatStyle = FlatStyle.Flat;
            cmbFiltro.ForeColor = Color.FromArgb(0, 0, 64);
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(88, 50);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(231, 23);
            cmbFiltro.TabIndex = 0;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(370, 50);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(168, 23);
            txtFiltro.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(643, 50);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(102, 42);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(643, 109);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(102, 36);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(88, 100);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(538, 297);
            dgvResultados.TabIndex = 4;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(533, 415);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(158, 23);
            txtTotal.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 418);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 6;
            label1.Text = "Total de Registros Encontrados";
            // 
            // FrmBuscarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(dgvResultados);
            Controls.Add(btnBuscar);
            Controls.Add(btnEnviar);
            Controls.Add(txtFiltro);
            Controls.Add(cmbFiltro);
            Name = "FrmBuscarProductos";
            Text = "FrmBuscarProductos";
            Load += FrmBuscarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFiltro;
        private TextBox txtFiltro;
        private Button btnEnviar;
        private Button btnBuscar;
        private DataGridView dgvResultados;
        private TextBox txtTotal;
        private Label label1;
    }
}