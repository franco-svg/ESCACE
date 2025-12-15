using BE;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;

namespace UI
{
    public static class UIPdfGenerator
    {
        public static void DescargarContratoPdf(BEContrato contrato, string rutaArchivo)
        {
            using (PdfWriter writer = new PdfWriter(rutaArchivo))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document doc = new Document(pdf))
            {
                PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                PdfFont fontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                // Encabezado centrado
                doc.Add(new Paragraph("CONTRATO")
                    .SetFont(fontBold)
                    .SetFontSize(16)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetMarginBottom(20));

                // Contenido
                doc.Add(new Paragraph($"ID: {contrato.Id}").SetFont(fontNormal));
                doc.Add(new Paragraph($"Título: {contrato.Titulo}").SetFont(fontNormal));
                doc.Add(new Paragraph($"Descripción: {contrato.Descripcion}").SetFont(fontNormal));
                doc.Add(new Paragraph($"Términos y Condiciones: {contrato.TerminosCondiciones}").SetFont(fontNormal));
                doc.Add(new Paragraph($"Cliente: {contrato.Cliente}").SetFont(fontNormal));
                doc.Add(new Paragraph($"Fecha de firma: {contrato.FechaFirma:d}").SetFont(fontNormal));//shortdate
                doc.Add(new Paragraph($"Fecha de inicio de vigencia: {contrato.FechaInicio:d}").SetFont(fontNormal));//shortdate
                doc.Add(new Paragraph($"Estado: {contrato.Estado}").SetFont(fontNormal));
                doc.Add(new Paragraph($"Monto (USD): {contrato.Monto:F2}").SetFont(fontNormal));//2 decimales
            } 
        }
    }
}
