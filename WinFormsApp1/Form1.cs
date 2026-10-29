using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp1;
using QuestPDF;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string conexionString = Conexion.Cadena;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(conexionString))
            {
                conexion.Open();
                string query = "INSERT INTO productos (nombre, precio, stock, marca) VALUES (@nombre, @precio, @stock, @marca)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Producto insertado con éxito.");
            Limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(conexionString))
            {
                conexion.Open();
                string query = "UPDATE productos SET nombre = @nombre, precio = @precio, stock = @stock, marca = @marca WHERE codigo = @codigo";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@codigo", Convert.ToInt32(txtCodigo.Text));
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Producto actualizado con éxito.");
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(conexionString))
            {
                conexion.Open();
                string query = "DELETE FROM productos WHERE codigo = @codigo";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@codigo", Convert.ToInt32(txtCodigo.Text));
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Producto eliminado.");
            Limpiar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Abre el formulario de búsqueda pasándole la referencia actual
            FrmBuscarProductos frm = new FrmBuscarProductos(this);
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtMarca.Clear();
            txtCodigo.Focus();
        }

        public void CargarProducto(string codigo, string nombre, string precio, string stock, string marca)
        {
            txtCodigo.Text = codigo;
            txtNombre.Text = nombre;
            txtPrecio.Text = precio;
            txtStock.Text = stock;
            txtMarca.Text = marca;
        }
    }
}