using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing.Layout;

namespace WindowsFormsApplication2
{
    public class PDF : Base
    {
        internal static PdfDocument document;
        public PDF()
        {
            Begin();
        }
        private void Begin()
        {
            String filename = "test.pdf";
            String text;
            XRect rect;
            XFont font;
            document = new PdfDocument();
            document.Info.Title = "Title test";
            document.Info.Author = "Author Test";
            document.Info.Subject = "Subject test";
            document.Info.Keywords = "keyword test";

            PdfPage page = document.AddPage();
            page.Orientation = PageOrientation.Landscape;
            page.Size = PageSize.Letter;
            XGraphics gfx = XGraphics.FromPdfPage(page);

            double x1 = 16; // page.Width.Point * 0.02;
            double x2 = 40; // page.Width.Point * 0.055;

            double y1 = 80; // page.Height.Point * 0.115;
            double y2 = 9; // page.Height.Point * 0.015;

            double[] columnWidth = { 40, 40, 30, 80, 80, 90 };
            double[] columnWidth2 = { 40, 70, 80, 40, 40, 90 };
            string[] columnTitle = { "No. de orden", "Ceramica", "Cant.", "Descripción", "Parte impresa", "No. parte del sensor"};
            string[] columnTitle2 = { "Proceso", "Op de impresora Fecha/Hora", "Operador Descarga de Horno", "Impresora", "Pasta a utlizar", "No. parte de la pasta utilizada" };


            text = "Etiquetas Kanban para identificación de Material P-155";
            //rect = new XRect(16, page.Height.Point * 0.06, page.Width.Point * 0.46, page.Height.Point * 0.04);
            rect = new XRect(16, 40, 360, 25);
            font = new XFont("Verdana", 12, XFontStyle.Regular);
            drawTitle(gfx, page, rect, font, text, XBrushes.Yellow);

            font = new XFont("Arial", 5.3, XFontStyle.Regular);

            for (int i=0; i < columnTitle.GetLength(0); i++)
            {
                text = columnTitle[i];
                x2 = columnWidth[i];
                rect = new XRect(x1, y1, x2, y2);
                drawBox(gfx, page, rect, font, text, XBrushes.LightGray);
                x1 += x2;
            }

            x1 = 16;
            y1 = 105;
            y2 = 25;

            for (int i = 0; i < columnTitle2.GetLength(0); i++)
            {
                text = columnTitle2[i];
                x2 = columnWidth2[i];
                rect = new XRect(x1, y1, x2, y2);
                drawSecondBox(gfx, page, rect, font, text, XBrushes.LightGray);
                x1 += x2;
            }
            // Save the s_document...
            document.Save(filename);
            // ...and start a viewer
            Process.Start(filename);
        }

        /*
         * You can use Text to identify which column is (to generate the report with SQL values)
         */
        private void drawSecondBox(XGraphics gfx, PdfPage page, XRect rect, XFont font, String text, XBrush color)
        {
            string[] categories = { "Oro detras", "Oro", "Conductor", "Glass", "Pink Glass", "Frit" };

            gfx.DrawRectangle(color, rect);
            gfx.DrawString(text, font, XBrushes.Black, rect, XStringFormats.Center);

            //Having the XRect (a rectangle) this block draws the border
            //new XPEN color and width This can be improved (creating an object every time)
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Top, rect.Right, rect.Top);
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Bottom, rect.Right, rect.Bottom);
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Top, rect.Left, rect.Bottom);
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Right, rect.Top, rect.Right, rect.Bottom);

            //gfx.DrawRectangle(XBrushes.Transparent, rect);
            //gfx.DrawString(text, font, XBrushes.Black, rect, XStringFormats.Center);

            for (int i = 0; i < categories.GetLength(0); i++)
            {
                rect.Offset(0, rect.Height);
                if (text.Equals("Proceso")){
                    //tf.DrawString(categories[i], font, XBrushes.Black, rect, XStringFormats.TopLeft );
                    gfx.DrawString(categories[i], font, XBrushes.Black, rect, XStringFormats.Center);
                }
                
                gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Top, rect.Right, rect.Top);
                gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Bottom, rect.Right, rect.Bottom);
                gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Top, rect.Left, rect.Bottom);
                gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Right, rect.Top, rect.Right, rect.Bottom);
                
            }
        }

        private void drawBox(XGraphics gfx, PdfPage page, XRect rect, XFont font, String text, XBrush color)
        {
            gfx.DrawRectangle(color, rect);
            gfx.DrawString(text, font, XBrushes.Black, rect, XStringFormats.Center);

            //Having the XRect (a rectangle) this block draws the border
            //new XPEN color and width This can be improved (creating an object every time)
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Top, rect.Right, rect.Top);
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Bottom, rect.Right, rect.Bottom);
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Top, rect.Left, rect.Bottom);
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Right, rect.Top, rect.Right, rect.Bottom);

            //gfx.DrawRectangle(XBrushes.Transparent, rect);
            //gfx.DrawString(text, font, XBrushes.Black, rect, XStringFormats.Center);
            rect.Offset(0, rect.Height);
            if(text.Equals("No. de orden"))
            {
                gfx.DrawString("testing :)", font, XBrushes.Black, rect, XStringFormats.Center);
            }

            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Top, rect.Right, rect.Top);
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Bottom, rect.Right, rect.Bottom);
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Top, rect.Left, rect.Bottom);
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Right, rect.Top, rect.Right, rect.Bottom);
        }

        void drawTitle(XGraphics gfx, PdfPage page, XRect rect, XFont font, String text, XBrush color)
        {
            gfx.DrawRectangle(color, rect);
            gfx.DrawString(text, font, XBrushes.Black, rect, XStringFormats.Center);

            //Having the XRect (a rectangle) this block draws the border
            //new XPEN color and width This can be improved (creating an object every time)
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Top, rect.Right, rect.Top);
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Bottom, rect.Right, rect.Bottom);
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Left, rect.Top, rect.Left, rect.Bottom);
            gfx.DrawLine((new XPen(XColors.Black, 0.3)), rect.Right, rect.Top, rect.Right, rect.Bottom);
        }
    }
}
