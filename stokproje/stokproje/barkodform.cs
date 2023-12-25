using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing.Printing;

namespace stokproje
{
    public partial class barkodform : MaterialForm
    {
        public barkodform()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Amber600, Primary.Amber700,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.BLACK
            );
            
        }

        private void barkodform_Load(object sender, EventArgs e)
        {

        }

        private void btnbarcode_Click(object sender, EventArgs e)
        {
        
           
            Zen.Barcode.Code128BarcodeDraw barcode2 = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode2.Draw(textbarcode.Text, 50);
        }

        private void btnqr_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(textqr.Text, 50);
        }

        private void btyazdir_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if(pd.ShowDialog()==DialogResult.OK)
                doc.Print();
                     
                    }
        private void Doc_PrintPage(object sender ,PrintPageEventArgs e)
        {
            Bitmap printdoc = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(printdoc, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(printdoc, 0, 0);
            printdoc.Dispose();
           


               
        }

        private void textbarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Zen.Barcode.Code128BarcodeDraw barcode2 = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = barcode2.Draw(textbarcode.Text, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textqr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pictureBox1.Image = qrcode.Draw(textqr.Text, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }
    }
}
