using Npgsql;
using QuestPDF.Fluent;
using System;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp1.Reportes;

namespace WinFormsApp1
{
    public partial class FrmBuscarProductos : Form
    {
        string conexionString = Conexion.Cadena;
        private Form1 formPrincipal;

        public FrmBuscarProductos(Form1 principal)
        {
            InitializeComponent();
            formPrincipal = principal;
        }

        private void FrmBuscarProductos_Load(object sender, EventArgs e)
        {
            cmbFiltro.Items.Add("NOMBRE");
            cmbFiltro.Items.Add("MARCA");
            cmbFiltro.SelectedIndex = 0;
            CargarDatos("SELECT * FROM productos");

            //Estilos datagrid
            dgvResultados.BorderStyle = BorderStyle.None;
            dgvResultados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 243, 246); // Efecto cebra suave
            dgvResultados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvResultados.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Azul al seleccionar
            dgvResultados.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvResultados.BackgroundColor = Color.White;
            dgvResultados.EnableHeadersVisualStyles = false;

            // Estilo de los encabezados de la tabla
            dgvResultados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvResultados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvResultados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvResultados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void CargarDatos(string query)
        {
            using (NpgsqlConnection conexion = new NpgsqlConnection(conexionString))
            {
                conexion.Open();
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conexion))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvResultados.DataSource = dt;
                    txtTotal.Text = dt.Rows.Count.ToString();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string campo = cmbFiltro.SelectedItem.ToString().ToLower();
            string valor = txtFiltro.Text;
            string query = $"SELECT * FROM productos WHERE {campo} ILIKE '%{valor}%'";
            CargarDatos(query);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dgvResultados.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvResultados.SelectedRows[0];

                // Envía los datos seleccionados de vuelta al Form1
                formPrincipal.CargarProducto(
                    fila.Cells["codigo"].Value?.ToString() ?? string.Empty,
                    fila.Cells["nombre"].Value?.ToString() ?? string.Empty,
                    fila.Cells["precio"].Value?.ToString() ?? string.Empty,
                    fila.Cells["stock"].Value?.ToString() ?? string.Empty,
                    fila.Cells["marca"].Value?.ToString() ?? string.Empty);

                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.");
            }
        }

        private async void btnGenerarPdf_Click(object sender, EventArgs e)
        {
            using var dialogo = new SaveFileDialog
            {
                Title = "Guardar reporte de inventario",
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                DefaultExt = "pdf",
                AddExtension = true,
                FileName = $"Inventario_{DateTime.Now:yyyyMMdd_HHmm}.pdf"
            };

            if (dialogo.ShowDialog() != DialogResult.OK)
                return;

            btnGenerarPdf.Enabled = false;

            try
            {
                // Reemplaza esta expresión por la cadena
                // que ya utiliza tu aplicación.
                string connectionString = conexionString;

                var repositorio = new InventarioRepository(connectionString);

                var productos = await repositorio.ObtenerProductosAsync();

                if (productos.Count == 0)
                {
                    MessageBox.Show(
                        "No hay productos para incluir en el reporte.",
                        "Inventario vacío",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                var documento = new InventarioPdf(productos);

                documento.GeneratePdf(dialogo.FileName);

                MessageBox.Show(
                    "El reporte se generó correctamente.",
                    "Reporte PDF",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo generar el reporte:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnGenerarPdf.Enabled = true;
            }
        }
    }
}
