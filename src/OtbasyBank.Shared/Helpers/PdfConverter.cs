using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace OtbasyBank.Shared.Helpers
{
    public class PdfConverter
    {
        public static byte[] HtmlToPdf(string html)
        {
            byte[] bytes = new byte[0];
            Document pdfDoc = new Document(PageSize.A4, 55f, 30f, 40f, 20f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            StringReader reader = new StringReader(html);
            using(MemoryStream ms = new MemoryStream())
            {
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, ms);
                pdfDoc.Open();

                htmlparser.Parse(reader);
                pdfDoc.Close();
                 bytes = ms.ToArray();
                ms.Close();
            }
            return bytes;
        }
    }
}
