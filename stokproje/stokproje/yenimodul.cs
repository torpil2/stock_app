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
using MaterialSkin;
using MaterialSkin.Controls;


namespace stokproje
{
    public partial class yenimodul : MaterialForm
    {
        public DataSet ds = new DataSet();
        public System.Data.DataTable dt = new System.Data.DataTable();
        static string connstring = "Server=localhost;Port=5432;" +
                 "User Id=postgres;Password=buqra4kaan;Database=postgres;";
        NpgsqlConnection conn = new NpgsqlConnection(connstring);
        public yenimodul()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Amber600, Primary.Amber800,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.BLACK
            );
        }

        private void kayit_bttn_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
                conn.Open();


            NpgsqlCommand dbcmd = new NpgsqlCommand("insert into urun(garantisuresiay,modulid) values(@garantisuresiay,@modulid)", conn);


            dbcmd.Parameters.AddWithValue("@garantisuresiay", modul_txt.Text);
            dbcmd.Parameters.AddWithValue("@modulid", garantisuresi_txt.Text);


            dbcmd.ExecuteNonQuery();
            dbcmd.Parameters.Clear();
        }

        private void yenimodul_Load(object sender, EventArgs e)
        {
            modul_txt.Text = Form2.modulidtext;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();


            NpgsqlCommand dbcmd = new NpgsqlCommand("insert into urun(garantisuresiay,modulid) values(@garantisuresiay,@modulid)", conn);


            dbcmd.Parameters.AddWithValue("@garantisuresiay", modul_txt.Text);
            dbcmd.Parameters.AddWithValue("@modulid", garantisuresi_txt.Text);


            dbcmd.ExecuteNonQuery();
            dbcmd.Parameters.Clear();
        }
    }
}
