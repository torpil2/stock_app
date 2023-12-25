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
    public partial class login : MaterialForm
    {
        static string connstring = "Server=localhost;Port=5432;" +
             "User Id=postgres;Password=buqra4kaan;Database=postgres;";
        NpgsqlConnection conn = new NpgsqlConnection(connstring);
        public login()
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


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            conn.Open();

            try
            {

                string usernamed = username_txt.Text;
                string passwordd = pass_txt.Text;

                NpgsqlCommand sorgu = new NpgsqlCommand("SELECT * from user2  where username='" + username_txt.Text + "' AND password='" + pass_txt.Text + "'", conn);
                NpgsqlDataReader verification = sorgu.ExecuteReader();
                if (username_txt.Text == "" && pass_txt.Text == "")
                { MessageBox.Show("Kullanıcı Adı ve Şifre Satırı Doldurulmalı!!"); }
                else
                {

                    if (verification.Read())
                    {
                        MessageBox.Show("Gİriş Başarılı!");
                        this.Hide();
                        Form1 anaekran = new Form1();
                        anaekran.Show();
                    }

                    else
                    {
                        MessageBox.Show("Böyle Bir Kayıtlı Kullanıcı Yok ya da HATALI ŞİFRE!");
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                materialRaisedButton1.PerformClick();
            }
        }

        private void pass_txt_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                materialRaisedButton1.PerformClick();
            }
        }
    }

    } 

