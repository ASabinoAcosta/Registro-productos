using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Reportes
{
    internal class InventarioRepository
    {
        private readonly string _connectionString;

        public InventarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<ProductoReporte>> ObtenerProductosAsync()
        {
            var productos = new List<ProductoReporte>();

            const string sql = """
        SELECT codigo, nombre, precio, stock, marca
        FROM productos
        ORDER BY codigo;
        """;

            await using var conexion =
                new NpgsqlConnection(_connectionString);

            await conexion.OpenAsync();

            await using var comando =
                new NpgsqlCommand(sql, conexion);

            await using var lector =
                await comando.ExecuteReaderAsync();

            while (await lector.ReadAsync())
            {
                productos.Add(new ProductoReporte
                {
                    Codigo = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Precio = lector.GetDecimal(2),
                    Stock = lector.GetInt32(3),
                    Marca = lector.GetString(4)
                });
            }

            return productos;
        }
    }
}
