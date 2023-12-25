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
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Office.Interop.Excel;
using MaterialSkin;
using MaterialSkin.Controls;




namespace stokproje
{
    public partial class yenikayitform : MaterialForm
    {
        public yenikayitform()
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
        static string connstring = "Server=localhost;Port=5432;" +
                 "User Id=postgres;Password=buqra4kaan;Database=postgres;";

        NpgsqlConnection conn = new NpgsqlConnection(connstring);
        private void yenikayitform_Load(object sender, EventArgs e)
        {

        }

      
        private void button2_Click(object sender, EventArgs e)
        {
           
            Form.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "image files|*.jpg;*.png;*.gif";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.Cancel)
                return;
            pictureBox1.Image = Image.FromFile(ofd.FileName);
            textBox7.Text = ofd.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void kaydet_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (conn.State == ConnectionState.Closed)
                    conn.Open();



                NpgsqlCommand dbcmd = new NpgsqlCommand("insert into urun(urunad,urun_adet,kayit_tarihi,urunkodu,barkodno,kategoriadi,resimyolu,aciklama) values(@urunad,@urun_adet,@kayit_tarihi,@urunkodu,@barkodno,@kategoriadi,@resimyolu,@urunaciklama)", conn);


                dbcmd.Parameters.AddWithValue("@urunad", textBox1.Text);
                dbcmd.Parameters.AddWithValue("@urun_adet", textBox2.Text);
                dbcmd.Parameters.AddWithValue("@kayit_tarihi", dateTimePicker1.Text);
                dbcmd.Parameters.AddWithValue("@urunkodu", textBox4.Text);
                dbcmd.Parameters.AddWithValue("@barkodno", textBox5.Text);
                dbcmd.Parameters.AddWithValue("@kategoriadi", textBox6.Text);
                dbcmd.Parameters.AddWithValue("@resimyolu", textBox7.Text);
                dbcmd.Parameters.AddWithValue("@urunaciklama", kayitaciklamatxt.Text);

                dbcmd.ExecuteNonQuery();
                dbcmd.Parameters.Clear();

          
                conn.Close();
                MessageBox.Show("Ürün Kaydedildi!");
                             
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    
}
