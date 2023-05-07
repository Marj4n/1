using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodXYZ.pdf
{
    public class HeaderFooter : PdfPageEventHelper
    {
        private string _title;

        public HeaderFooter(string title)
        {
            _title = title;
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);
            PdfPTable table = new PdfPTable(1);
            table.WidthPercentage = 100;
            PdfPCell cell = new PdfPCell(new Phrase(_title));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);
            table.WriteSelectedRows(0, -1, 0, document.Top, writer.DirectContent);
        }
    }
}
