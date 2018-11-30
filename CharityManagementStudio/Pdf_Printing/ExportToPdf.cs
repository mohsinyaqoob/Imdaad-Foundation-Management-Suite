using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharityManagementStudio.Pdf_Printing
{
    class ExportToPdf
    {

        string fileLocationPath;
        
        public void ExportPDFDocument(DataGridView grid)
        {
            try
            {
                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(grid.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.DefaultCell.BorderWidth = 1;

                //Adding Header row
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    //cell.BackgroundColor = new BaseColor(Color.LightGreen);

                    pdfTable.AddCell(cell);
                }

                //Adding DataRow
                foreach (DataGridViewRow row in grid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }

                //Choosing File Location
                

                FolderBrowserDialog dlg = new FolderBrowserDialog();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    fileLocationPath = (dlg.SelectedPath)+"\\";

                    if (!Directory.Exists(fileLocationPath))
                    {
                        Directory.CreateDirectory(fileLocationPath);
                    }
                }

                Random rd = new Random();
                using (FileStream stream = new FileStream(fileLocationPath + "Imdaad_Print_"+rd.Next(1000)+".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 30f, 30f, 30f, 30f);
                    
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("PDF Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception Ex)
            {
                //MessageBox.Show("Somthing Went Wrong. PLease Try Again","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
