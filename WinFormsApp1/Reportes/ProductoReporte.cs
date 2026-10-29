using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Reportes
{
    public class ProductoReporte
    {
        //Datos del inventario

        public int Codigo { get; set; }
        public string Nombre { get; set; } = "";
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Marca { get; set; } = "";
    }
}
