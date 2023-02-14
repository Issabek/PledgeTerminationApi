//using EvoPdf;

using Syncfusion.HtmlConverter;

namespace OtbasyBank.Infrastructure.Helpers
{
    public class PDFConverter
    {

        //HtmlToPdfConverter pdfConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
        //WebKitConverterSettings settings = new WebKitConverterSettings();
        //settings.WebKitPath = Server.MapPath("~/QtBinaries/");
        //pdfConverter.pdfdocumentoptions.pdfpagesize = pdfpagesize.a4;
        //    pdfconverter.pdfdocumentoptions.pdfcompressionlevel = pdfcompressionlevel.normal;
        //    pdfconverter.pdfdocumentoptions.bottommargin = 20;
        //    pdfconverter.pdfdocumentoptions.leftmargin = 55;
        //    pdfconverter.pdfdocumentoptions.rightmargin = 30;
        //    pdfconverter.pdfdocumentoptions.topmargin = 40;
        //    pdfconverter.pdfdocumentoptions.pdfpageorientation = pdfpageorientation.portrait;

        //    return pdfconverter.getpdfbytesfromhtmlstring(html);
        public PDFConverter()
        {

        }
        public static byte[] PdfFromString(string line)
        {
            //TODO: надо сделать конвертер из стринга в байт
            return new byte[0];
        }
    }
}
