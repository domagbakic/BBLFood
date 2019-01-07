using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BibliotekaPDF
{
    public class PDF
    {
        public static void KreirajPDF(ReportViewer mojReport)
        {
            SaveFileDialog saveFileDialogPDF = new SaveFileDialog();
            saveFileDialogPDF.Filter = "PDF|*.pdf";
            saveFileDialogPDF.Title = "Pohrana izvještaja u PDF";
            saveFileDialogPDF.ShowDialog();

            if (saveFileDialogPDF.FileName != "")
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string filenameExtension;
                byte[] bytes = mojReport.LocalReport.Render(
                           "PDF", null, out mimeType, out encoding, out filenameExtension,
                           out streamids, out warnings);
                using (FileStream fs = new FileStream(saveFileDialogPDF.FileName, FileMode.Create))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
        }
    }
}
