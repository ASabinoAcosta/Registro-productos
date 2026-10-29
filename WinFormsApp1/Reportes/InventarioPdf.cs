using System;
using System.Collections.Generic;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace WinFormsApp1.Reportes
{
    public class InventarioPdf : IDocument
    {
        private readonly IReadOnlyList<ProductoReporte> _productos;

        public InventarioPdf(IReadOnlyList<ProductoReporte> productos)
        {
            _productos = productos;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.MarginHorizontal(35);
                page.MarginVertical(30);
                page.PageColor(Colors.White);

                page.DefaultTextStyle(style => style.FontSize(9));

                page.Header().Column(header =>
                {
                    header.Item()
                        .Text("INVENTARIO")
                        .FontSize(22)
                        .Bold()
                        .FontColor(Colors.Blue.Darken2);

                    header.Item()
                        .PaddingTop(5)
                        .Text($"Generado el {DateTime.Now:dd/MM/yyyy HH:mm}")
                        .FontColor(Colors.Grey.Darken1);

                    header.Item()
                        .PaddingTop(12)
                        .LineHorizontal(1)
                        .LineColor(Colors.Grey.Lighten2);
                });

                page.Content().PaddingVertical(18).Column(content =>
                {
                    content.Spacing(12);

                    content.Item()
                        .Text($"Productos registrados: {_productos.Count}")
                        .FontSize(12)
                        .Bold();

                    content.Item().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn(1);
                            columns.RelativeColumn(2.5f);
                            columns.RelativeColumn(1.5f);
                            columns.RelativeColumn(1.5f);
                            columns.RelativeColumn(1);
                        });

                        table.Header(header =>
                        {
                            header.Cell().Element(EstiloCabecera).Text("Código");
                            header.Cell().Element(EstiloCabecera).Text("Producto");
                            header.Cell().Element(EstiloCabecera).Text("Marca");
                            header.Cell().Element(EstiloCabecera)
                                .AlignRight().Text("Precio");
                            header.Cell().Element(EstiloCabecera)
                                .AlignRight().Text("Stock");
                        });

                        foreach (var producto in _productos)
                        {
                            table.Cell().Element(EstiloCelda)
                                .Text(producto.Codigo.ToString());

                            table.Cell().Element(EstiloCelda)
                                .Text(producto.Nombre);

                            table.Cell().Element(EstiloCelda)
                                .Text(producto.Marca);

                            table.Cell().Element(EstiloCelda)
                                .AlignRight()
                                .Text(producto.Precio.ToString("N2"));

                            table.Cell().Element(EstiloCelda)
                                .AlignRight()
                                .Text(producto.Stock.ToString());
                        }
                    });
                });

                page.Footer()
                .AlignRight()
                .Text(text =>
                {
                    text.Span("Página ")
                        .FontSize(9)
                        .FontColor(Colors.Grey.Darken1);

                    text.CurrentPageNumber()
                        .FontSize(9)
                        .FontColor(Colors.Grey.Darken1);

                    text.Span(" de ")
                        .FontSize(9)
                        .FontColor(Colors.Grey.Darken1);

                    text.TotalPages()
                        .FontSize(9)
                        .FontColor(Colors.Grey.Darken1);
                });
            });
        }

        private static IContainer EstiloCabecera(IContainer container)
        {
            return container
                .Background(Colors.Blue.Darken2)
                .PaddingVertical(9)
                .PaddingHorizontal(6)
                .DefaultTextStyle(style => style
                    .FontColor(Colors.White)
                    .Bold());
        }

        private static IContainer EstiloCelda(IContainer container)
        {
            return container
                .BorderBottom(1)
                .BorderColor(Colors.Grey.Lighten2)
                .PaddingVertical(8)
                .PaddingHorizontal(6);
        }
    }
}
