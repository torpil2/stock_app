using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Office.Interop.Excel;
using MaterialSkin;
using MaterialSkin.Controls;


namespace stokproje
    

{
    public partial class Form1 : MaterialForm

    {
        public DataSet ds = new DataSet();
        public System.Data.DataTable dt = new System.Data.DataTable();
        static string connstring = "Server=localhost;Port=5432;" +
                 "User Id=postgres;Password=buqra4kaan;Database=postgres;";
        NpgsqlConnection conn = new NpgsqlConnection(connstring);
        public NpgsqlCommand da;

        
        public Form1()
        {

            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;


            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Amber600, Primary.Amber700,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.BLACK
            );
        }
                               
        private void Form1_Load(object sender, EventArgs e)
        {
            KisiListele();
            txt_id.Visible = false;
            textBox8.Visible = false;
        }
        void KisiListele()
        {
            string sql = ("SELECT urunid,urunad,urun_adet,urunkodu,kayit_tarihi,kategoriadi,barkodno,resimyolu,aciklama FROM urun");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);


            ds.Reset();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;

            da.Fill(ds);

            dt = ds.Tables[0];

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            KisiListele();


            conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "urunad Like'" + textBox5.Text + "%' ";


            //dv.RowFilter = string.Format("Ad LIKE '{0}%'", textBox5.Text);
            dataGridView1.DataSource = dv;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                try
                {

                    txt_id.Text = row.Cells[0].Value.ToString();
                    textBox1.Text = row.Cells[1].Value.ToString();
                    textBox2.Text = row.Cells[2].Value.ToString();
                    textBox3.Text = row.Cells[3].Value.ToString();
                    dateTimePicker1.Text = row.Cells[4].Value.ToString();
                    textBox4.Text = row.Cells[6].Value.ToString();
                    textBox7.Text = row.Cells[5].Value.ToString();
                    textBox8.Text = row.Cells[7].Value.ToString();
                    pictureBox2.ImageLocation = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    aciklama_txt.Text = row.Cells[8].Value.ToString();
                    // MessageBox.Show(Convert.ToString(row));

                }
                catch
                {
                    MessageBox.Show("Boş Kayıt");
                }
            }
                        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.votec.com.tr");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            barkodform barkod = new barkodform();
            barkod.ShowDialog();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {
                
                string query = "update urun set  urunad=@urunad ,urun_adet=@urun_adet,kayit_tarihi=@kayit_tarihi ,urunkodu=@urunkodu,barkodno=@barkodno ,kategoriadi=@kategoriadi ,aciklama=@urunaciklama where urunid=@urunid ";
                NpgsqlCommand dbcmd = new NpgsqlCommand(query, conn);
                
                dbcmd.Parameters.AddWithValue("@urunid", int.Parse(txt_id.Text));
                dbcmd.Parameters.AddWithValue("@urunad", textBox1.Text);
                dbcmd.Parameters.AddWithValue("@urun_adet", textBox2.Text);
                dbcmd.Parameters.AddWithValue("@kayit_tarihi", dateTimePicker1.Text);
                dbcmd.Parameters.AddWithValue("@urunkodu", textBox3.Text);
                dbcmd.Parameters.AddWithValue("@barkodno", textBox4.Text);
                dbcmd.Parameters.AddWithValue("@kategoriadi", textBox7.Text);
                dbcmd.Parameters.AddWithValue("@urunaciklama", aciklama_txt.Text);

                
                dbcmd.ExecuteNonQuery();
                KisiListele();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yenikayitform yenikayit = new yenikayitform();
            yenikayit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand del = new NpgsqlCommand("DELETE from urun WHERE urunid = @urunid ", conn);
            del.Parameters.AddWithValue("@urunid", int.Parse(txt_id.Text));

            try
            {
                del.ExecuteNonQuery();
                del.Parameters.Clear();
                MessageBox.Show("Seçili Satır Silindi!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            KisiListele();
            conn.Close();
            
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_excel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;
            
            ws.Cells[1, 2] = "Ürün Adı";
            ws.Cells[1, 3] = "Ürün Adet";
            ws.Cells[1, 4] = "Ürün Kodu";
            ws.Cells[1, 5] = "Kayıt Tarihi";
            ws.Cells[1, 6] = "Kategori";
            ws.Cells[1, 7] = "Barkod No";


            for (int j = 1; j <= dataGridView1.Rows.Count; j++)
            {
                for (int i = 2; i <= 7; i++)
                {
                    ws.Cells[j, i] = dataGridView1.Rows[j - 1].Cells[i - 1].Value;
                }

            }
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)

                conn.Open();

            DataView dv = ds.Tables[0].DefaultView;

            dv.RowFilter = "barkodno Like '" + textBox6.Text + "%' ";

            int satirsayisi = dataGridView1.Rows.Count;
         

         
                if (satirsayisi <= 0)
                {



                    if (MessageBox.Show("Kayıt Bulunamadı Yeni Kayıt Girmek İster Misiniz? ", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        yenikayitform yenikayit = new yenikayitform();
                        yenikayit.Show();
                    }

                    //dv.RowFilter = string.Format("Ad LIKE '{0}%'", textBox5.Text);
                    dataGridView1.DataSource = dv;
                }
            }
        

        private void resimgoster_buton_Click(object sender, EventArgs e)
        {
                    
        }
                                     
                       

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            yenikayitform yenikayit = new yenikayitform();
            yenikayit.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            barkodform barkod = new barkodform();
            barkod.ShowDialog();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

                Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet ws = (Worksheet)Excel.ActiveSheet;
                Excel.Visible = true;


                ws.Cells[1, 2] = "Ürün Adı";
                ws.Cells[1, 3] = "Ürün Adet";
                ws.Cells[1, 4] = "Ürün Kodu";
                ws.Cells[1, 5] = "Kayıt Tarihi";
                ws.Cells[1, 6] = "Kategori";
                ws.Cells[1, 7] = "Barkod No";


                for (int j = 2; j - 1 <= dataGridView1.Rows.Count; j++)
                {
                    for (int i = 2; i <= 7; i++)
                    {
                        ws.Cells[j, i] = dataGridView1.Rows[j - 2].Cells[i - 1].Value;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hata! Daha Sonra Tekrar Deneyin!");
            }
        }

        private void grnti_bttn_Click(object sender, EventArgs e)
        {
           
            Form2 sistem = new Form2();
            sistem.Show();
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                grnti_bttn.PerformClick();
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            KisiListele();


            conn.Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            try
            {

                string query = "update urun set  urunad=@urunad ,urun_adet=@urun_adet,kayit_tarihi=@kayit_tarihi ,urunkodu=@urunkodu,barkodno=@barkodno ,kategoriadi=@kategoriadi, aciklama=@urunaciklama where urunid=@urunid ";
                NpgsqlCommand dbcmd = new NpgsqlCommand(query, conn);

                dbcmd.Parameters.AddWithValue("@urunid", int.Parse(txt_id.Text));
                dbcmd.Parameters.AddWithValue("@urunad", textBox1.Text);
                dbcmd.Parameters.AddWithValue("@urun_adet", textBox2.Text);
                dbcmd.Parameters.AddWithValue("@kayit_tarihi", dateTimePicker1.Text);
                dbcmd.Parameters.AddWithValue("@urunkodu", textBox3.Text);
                dbcmd.Parameters.AddWithValue("@barkodno", textBox4.Text);
                dbcmd.Parameters.AddWithValue("@kategoriadi", textBox7.Text);
                dbcmd.Parameters.AddWithValue("urunaciklama", aciklama_txt.Text);


                dbcmd.ExecuteNonQuery();
                KisiListele();
                conn.Close();
                MessageBox.Show("Güncelleme Başarılı!");

            }
            catch 
            {
                MessageBox.Show("Güncellenicek Sütunu Seçin!");
            }

        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.Clear();
        }
    }
}
