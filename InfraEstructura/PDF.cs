using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace InfraEstructura
{
    public class PDF
    {
        private string RUTA;
        private string rutaImagen;
        public PDF(string ruta)
        {
            RUTA = ruta + @"\PDF Facturas\";
            rutaImagen = ruta;
        }

        public void CrearPDF(Factura factura)
        {
            FileStream streamsource = new FileStream(RUTA + "Factura_" + factura.Numero + ".PDF", FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            PdfWriter pdfWriter = PdfWriter.GetInstance(document, streamsource);
            document.Open();
            Paragraph paragraph, paragrafph2;
            Image image = Image.GetInstance(rutaImagen + @"\Recursos\Ejemplo.png");
            image.ScaleToFit(100.0F, 130.0F);
            image.SpacingBefore = 20.0F;
            image.SpacingAfter = 10.0F;
            image.SetAbsolutePosition(220, 640);
            document.Add(image);
            paragraph = new Paragraph("Factura");
            paragraph.Alignment = Element.ALIGN_CENTER;
            paragraph.Alignment = Element.TITLE;
            paragraph.Font.Size = 20;
            paragraph.Font.Color = GrayColor.RED;
            paragraph.Font.SetStyle("bold");
            paragraph.Font.SetFamily("Times New Roman");
            Phrase pharase, pharase2;
            document.Add(paragraph);
            document.Add(Chunk.NEWLINE);
            pharase = new Phrase("Fecha: " + factura.Fecha.ToString());
            paragraph.Alignment = Element.ALIGN_LEFT;
            pharase.Font.Size = 12;
            pharase.Font.Color = GrayColor.BLACK;
            pharase.Font.SetFamily("Times New Roman");
            pharase2 = new Phrase("Codigo: " + factura.Numero);
            paragrafph2 = new Paragraph();

            paragrafph2.Add(pharase);
            paragrafph2.Add(Chunk.TABBING);
            paragrafph2.Add(Chunk.TABBING);
            paragrafph2.Add(Chunk.TABBING);
            paragrafph2.Add(Chunk.TABBING);
            paragrafph2.Add(Chunk.TABBING);
            paragrafph2.Add(Chunk.TABBING);
            paragrafph2.Add(Chunk.TABBING);
            pharase2.Font.Size = 12;
            pharase2.Font.Color = GrayColor.BLACK;
            pharase2.Font.SetFamily("Times New Roman");
            paragrafph2.Add(pharase2);
            document.Add(paragrafph2);

            Paragraph paragraph3 = new Paragraph();
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);

            paragrafph2 = new Paragraph("Gulfo Musical Store");
            paragrafph2.Alignment = Element.ALIGN_CENTER;
            document.Add(paragrafph2);
            document.Add(Chunk.NEWLINE);
            paragraph = new Paragraph("----------------------------------------------------------------------------------------------------------------");
            document.Add(paragraph);
            document.Add(Chunk.NEWLINE);
            pharase = new Phrase("Datos Vendedor: ");
            paragrafph2 = new Paragraph();
            document.Add(pharase);
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);
            pharase = new Phrase("Cedula: 4555548");
            paragrafph2.Add(pharase);
            paragrafph2.Add(Chunk.TABBING);
            paragrafph2.Add(Chunk.TABBING);
            pharase = new Phrase("Nombre: Carlos");
            paragrafph2.Add(pharase);
            paragrafph2.Add(Chunk.TABBING);
            paragrafph2.Add(Chunk.TABBING);
            pharase = new Phrase("Sexo: Masculino ");
            paragrafph2.Add(pharase);
            paragrafph2.Add(Chunk.TABBING);
            paragrafph2.Add(Chunk.TABBING);
            pharase = new Phrase("Correo Electronico: GulfoMusicalStore@gmail.com");
            document.Add(paragrafph2);
            document.Add(Chunk.NEWLINE);
            paragrafph2 = new Paragraph();
            paragrafph2.Add(pharase);
            paragrafph2.Add(Chunk.TABBING);
            paragrafph2.Add(Chunk.TABBING);
            pharase = new Phrase("Ciudad Factura: " + factura.Lugar.Ciudad);
            paragrafph2.Add(pharase);
            document.Add(paragrafph2);
            document.Add(Chunk.NEWLINE);
            document.Add(paragraph);
            document.Add(Chunk.NEWLINE);


            pharase = new Phrase("Datos Cliente: ");
            document.Add(pharase);
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);
            pharase = new Phrase("Cedula: " + factura.Cliente.Cedula);
            paragraph3 = new Paragraph();
            paragraph3.Add(pharase);
            paragraph3.Add(Chunk.TABBING);
            paragraph3.Add(Chunk.TABBING);
            pharase = new Phrase("Nombres: " + factura.Cliente.PrimerNombre + " " + factura.Cliente.SegundoNombre);
            paragraph3.Add(pharase);
            paragraph3.Add(Chunk.TABBING);
            paragraph3.Add(Chunk.TABBING);
            pharase = new Phrase("Apellidos: " + factura.Cliente.PrimerApellido + " " + factura.Cliente.SegundoApellido);
            paragraph3.Add(pharase);
            paragraph3.Add(Chunk.TABBING);
            paragraph3.Add(Chunk.TABBING);
            pharase = new Phrase("Correo: " + factura.Cliente.Correo);
            document.Add(paragraph3);
            document.Add(Chunk.NEWLINE);
            paragraph3 = new Paragraph();
            paragraph3.Add(pharase);
            paragraph3.Add(Chunk.TABBING);
            paragraph3.Add(Chunk.TABBING);
            pharase = new Phrase("Telefono: " + factura.Cliente.Telefono);
            document.Add(paragraph3);
            document.Add(Chunk.NEWLINE);

            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);

            document.Add(paragraph);
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);
            pharase = new Phrase("Datos Factura: ");
            document.Add(pharase);
            document.Add(Chunk.NEWLINE);
            document.Add(Chunk.NEWLINE);

            pharase = new Phrase("Estado: " + factura.Estado);
            paragraph3 = new Paragraph();
            paragraph3.Add(Chunk.SPACETABBING);
            paragraph3.Add(Chunk.SPACETABBING);

            pharase = new Phrase("Cantidad Productos: " + factura.Cantidad);
            
            paragraph3.Add(pharase);
            paragraph3.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph3);
            document.Add(Chunk.NEWLINE);

            pharase = new Phrase("Iva: " + factura.Iva);
            paragraph3 = new Paragraph();
            paragraph3.Add(pharase);
            paragraph3.Add(Chunk.SPACETABBING);
            paragraph3.Add(Chunk.SPACETABBING);
            pharase = new Phrase("Sub Total: " + factura.SubTotal);
            paragraph3.Add(pharase);
            paragraph3.Add(Chunk.SPACETABBING);
            paragraph3.Add(Chunk.SPACETABBING);
            pharase = new Phrase("Total: " + factura.Total);
            paragraph3.Add(pharase);
            paragraph3.Alignment = Element.ALIGN_CENTER;
            document.Add(paragraph3);
            document.Add(Chunk.NEWLINE);

            int tablacolumnas = 5;

            PdfPTable tabla = new PdfPTable(tablacolumnas);
            PdfPCell codigocell = new PdfPCell(new Phrase("Codigo "));
            codigocell.BorderWidth = 0.75f;
            codigocell.BorderWidthBottom = 0.75f;
            codigocell.BackgroundColor = GrayColor.GRAYWHITE;
            tabla.AddCell(codigocell);
            PdfPCell productocell = new PdfPCell(new Phrase("Prodcuto "));
            codigocell.BorderWidth = 0.75f;
            codigocell.BorderWidthBottom = 0.75f;
            codigocell.BackgroundColor = GrayColor.GRAYWHITE;
            tabla.AddCell(productocell);
            PdfPCell marcacell = new PdfPCell(new Phrase("Marca "));
            codigocell.BorderWidth = 0.75f;
            codigocell.BorderWidthBottom = 0.75f;
            codigocell.BackgroundColor = GrayColor.GRAYWHITE;
            tabla.AddCell(marcacell);
            PdfPCell cantidadcell = new PdfPCell(new Phrase("Cantidad "));
            codigocell.BorderWidth = 0.75f;
            codigocell.BorderWidthBottom = 0.75f;
            codigocell.BackgroundColor = GrayColor.GRAYWHITE;
            tabla.AddCell(cantidadcell);
            PdfPCell preciocell = new PdfPCell(new Phrase("Precio "));
            codigocell.BorderWidth = 0.75f;
            codigocell.BorderWidthBottom = 0.75f;
            codigocell.BackgroundColor = GrayColor.GRAYWHITE;
            tabla.AddCell(preciocell);


            foreach (var item in factura.VerListaProductos())
            {
                codigocell = new PdfPCell(new Phrase(item.Producto.Codigo));
                codigocell.BorderWidth = 0.75f;
                productocell = new PdfPCell(new Phrase(item.Producto.Nombre));
                productocell.BorderWidth = 0.75f;
                marcacell = new PdfPCell(new Phrase(item.Producto.Marca.Nombre));
                marcacell.BorderWidth = 0.75f;
                cantidadcell = new PdfPCell(new Phrase(item.Unidades.ToString()));
                cantidadcell.BorderWidth = 0.75f;
                preciocell = new PdfPCell(new Phrase(item.PrecioProducto.ToString()));
                preciocell.BorderWidth = 0.75f;
                tabla.AddCell(codigocell);
                tabla.AddCell(productocell);
                tabla.AddCell(marcacell);
                tabla.AddCell(cantidadcell);
                tabla.AddCell(preciocell);
            }

            foreach (var item in factura.VerListaCursos())
            {
                codigocell = new PdfPCell(new Phrase(item.Curso.Codigo));
                codigocell.BorderWidth = 0.75f;
                productocell = new PdfPCell(new Phrase(item.Curso.Nombre));
                productocell.BorderWidth = 0.75f;
                marcacell = new PdfPCell(new Phrase("Curso"));
                marcacell.BorderWidth = 0.75f;
                cantidadcell = new PdfPCell(new Phrase(item.Unidades.ToString()));
                cantidadcell.BorderWidth = 0.75f;
                preciocell = new PdfPCell(new Phrase(item.Precio.ToString()));
                preciocell.BorderWidth = 0.75f;
                tabla.AddCell(codigocell);
                tabla.AddCell(productocell);
                tabla.AddCell(marcacell);
                tabla.AddCell(cantidadcell);
                tabla.AddCell(preciocell);
            }

            document.Add(tabla);
            document.Close();
            streamsource.Close();
        }
    }
}
