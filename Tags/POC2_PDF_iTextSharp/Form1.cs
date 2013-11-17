using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace POC2_PDF_iTextSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "out.pdf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text))
            {
                if (DialogResult.No == MessageBox.Show("Output file exists, delete?", "Outch!", MessageBoxButtons.YesNo))
                    return;

                File.Delete(textBox1.Text);
            }

            // in general: 72 pixel == 2.54cm

            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, true);

            iTextSharp.text.Font font_title = new iTextSharp.text.Font(
                bf,
                11,
                iTextSharp.text.Font.BOLD + iTextSharp.text.Font.UNDERLINE,
                iTextSharp.text.Color.DARK_GRAY);

            iTextSharp.text.Font font_description = new iTextSharp.text.Font(
                            bf,
                            11,
                            iTextSharp.text.Font.NORMAL,
                            iTextSharp.text.Color.DARK_GRAY);

            iTextSharp.text.Font font_meta = new iTextSharp.text.Font(
                            bf,
                            8,
                            iTextSharp.text.Font.NORMAL,
                            iTextSharp.text.Color.DARK_GRAY);

            iTextSharp.text.Font font_sn = new iTextSharp.text.Font(
                            bf,
                            8,
                            iTextSharp.text.Font.NORMAL,
                            iTextSharp.text.Color.DARK_GRAY);

            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(textBox1.Text, FileMode.Create));

            doc.Open();

            doc.SetMargins(30.0f, 30.0f, 0.0f, 0.0f);

            Paragraph header = new Paragraph();
            header.SpacingBefore = 0.0f;
            header.SpacingAfter = 0.0f;
            header.Add(new Chunk("Pixformance Membership Tags", font_title));
            header.Add(Chunk.NEWLINE);
            header.Add(new Chunk("Bitte vor der ersten Benutzung aktivieren.", font_description));
            doc.Add(header);

            Paragraph meta = new Paragraph();
            meta.SpacingBefore = 0.0f;
            meta.SetAlignment("Right");
            meta.Add(new Chunk("70 Tags | 32 | 213404 - 213473 | Version 234", font_meta));
            doc.Add(meta);

            iTextSharp.text.Image qr_image = iTextSharp.text.Image.GetInstance(pictureBox1.Image, iTextSharp.text.Color.RED);
            qr_image.ScaleAbsolute(50f, 50f);
            //jpg.SpacingAfter = 12f;
            //jpg.SpacingBefore = 12f;


            PdfPTable qr_table = new PdfPTable(7);
            qr_table.TotalWidth = 7.0f * 72.0f;
            qr_table.SpacingBefore = 72.0f;
            qr_table.LockedWidth = true;

            Phrase phr = new Phrase();
            phr.Add(new Chunk(qr_image, 0, 0));
            phr.Add(Chunk.NEWLINE);
            phr.Add(new Chunk("test", font_sn));

            PdfPCell cell = new PdfPCell(phr);
            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            cell.MinimumHeight = 72.0f;
            cell.BorderWidth = 0.0f;

            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);

            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);

            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);

            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);

            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);

            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);

            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);

            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);

            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);
            qr_table.AddCell(cell);

            
            doc.Add(qr_table);

            doc.Close();

        }
    }
}
