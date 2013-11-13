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

            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, true);
            iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.Color.LIGHT_GRAY);


            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(textBox1.Text, FileMode.Create));

            doc.Open();

            Paragraph heading = new Paragraph("Page Heading", new iTextSharp.text.Font(iTextSharp.text.Font.HELVETICA, 28f, iTextSharp.text.Font.BOLD));
            heading.SpacingAfter = 18f;
            doc.Add(heading);

            MultiColumnText columns = new MultiColumnText();
            //float left, float right, float gutterwidth, int numcolumns
            columns.AddRegularColumns(36f, doc.PageSize.Width - 36f, 24f, 10);
            
            
            Paragraph para = new Paragraph("qr code", times);
            para.SpacingAfter = 9f;
            para.Alignment = Element.ALIGN_JUSTIFIED;


            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(pictureBox1.Image, iTextSharp.text.Color.RED);
            jpg.ScaleToFit(30f, 30f);
            jpg.SpacingAfter = 12f;
            jpg.SpacingBefore = 12f;


            for (int i = 0; i < 40; i++)
            {
                columns.AddElement(jpg);
                columns.AddElement(para);

            }

            doc.Add(columns);

            doc.Close();

        }
    }
}
