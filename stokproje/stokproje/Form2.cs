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
using System.IO.Ports;

namespace stokproje
{
    public partial class Form2 : MaterialForm
    {
        public static string modulidtext;

        public DataSet ds = new DataSet();
        public System.Data.DataTable dt = new System.Data.DataTable();
        static string connstring = "Server=localhost;Port=5432;" +
                 "User Id=postgres;Password=buqra4kaan;Database=postgres;";
        NpgsqlConnection conn = new NpgsqlConnection(connstring);
        public Form2()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;


            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Amber600, Primary.Amber800,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.BLACK
            );

        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            //int i;
            //for (i = 0; i < ports.Length;++)
            //{
            //    if(ports[i] == null)
            //}
            ports_box.Items.AddRange(ports);
            close_bttn.Enabled = false;
            open_bttn.Enabled = true;



            DateTime dt = DateTime.Now;
            int yil = dt.Year;
            int ay = dt.Month;
            int gun = dt.Day;
            toda.Text = dt.ToString("dd/MM/yyyy");



        }
        void garantilistele()
        {
            string sql = ("SELECT garantisuresiay,garantibaslangic,modulid,garantibitis from garantitakip ");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);


            ds.Reset();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.AllowUserToAddRows = false;

            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }

        private void open_bttn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = ports_box.Text;
                serialPort1.Open();
                progressBar1.Value = 100;
                close_bttn.Enabled = true;
                open_bttn.Enabled = false;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_bttn_Click(object sender, EventArgs e)
        {
            open_bttn.Enabled = true;
            close_bttn.Enabled = false;
            try
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void send_bttn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(send_txt.Text + Environment.NewLine);
                send_txt.Clear();
            }
        }

        private void receive_bttn_Click(object sender, EventArgs e)
        {
            //  if (serialPort1.IsOpen)

            try
            {

                serialPort1.BaudRate = Convert.ToInt32(baudrates_box.Text);
                receive_txt.Text = (serialPort1.ReadExisting());
                string text = receive_txt.Text;
                // File.WriteAllText(@"c:\deneme\deneme.txt", text);
                int satirlar = receive_txt.Lines.Length;
                if (satirlar > 1)
                {
                    ListViewItem macler = listView1.Items.Add(ports_box.Text + "=" + receive_txt.Lines[4]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try { serialPort1.Close(); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toda_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                garantilistele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // HER SATIRA DÖNGÜ {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)

                {
                    DataGridViewRow row = dataGridView1.Rows[i];

                    //row.Cells[3].Value = true;
                
                    try
                    {
                        garantiay.Text = row.Cells[0].Value.ToString();
                        garantibaslangic_txt.Text = row.Cells[1].Value.ToString();
                        modulid_txt.Text = row.Cells[2].Value.ToString();
                        string baslangicay = garantibaslangic_txt.Text;
                        //   DateTime dt = new DateTime(long.Parse( baslangicay));
                        //  int yil3 = dt.Year;
                        //  int ay3 = dt.Month;
                        //  int gun3 = dt.Day;
                        //HER SATIRA DÖNGÜ {            
                        //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        //{
                        //    DataGridViewRow Row  = dataGridView1.Rows[i];
                        //   row.Cells[2].Value = true;
                        //}
                        //}

                        string query = "update garantitakip set  garantibitis=@garantibitis  where modulid=@modulid ";
                        NpgsqlCommand dbcmd = new NpgsqlCommand(query, conn);
                        int toplamay = Convert.ToInt32(garantiay.Text);
                        DateTime hesaplananay = Convert.ToDateTime(garantibaslangic_txt.Text);
                        DateTime garantibitis = hesaplananay.AddMonths(toplamay);
                        garantibitis_txt.Text = Convert.ToString(garantibitis);
                        dbcmd.Parameters.AddWithValue("@garantibitis", DateTime.Parse(garantibitis_txt.Text));

                        dbcmd.Parameters.AddWithValue("@modulid", modulid_txt.Text);

                        if (conn.State == ConnectionState.Closed)
                            conn.Open();

                        dbcmd.ExecuteNonQuery();
                        garantilistele();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //garantibaslangic_txt.Text = Convert.ToDateTime(garantibaslangic_txt.Text).ToString("MM/dd/yyyy");

                    // DateTime baslangicaytarih = DateTime.Parse(baslangicay);
                    //DateTime baslangicislem = 
                }
                //}
                //catch
                //{
                //    MessageBox.Show("Boş Kayıt");
                //}
            }
        }

        private void yenimodul_txt_Click(object sender, EventArgs e)
        {
            modulidtext = receive_txt.Text;
            yenimodul sistema = new yenimodul();
            sistema.Show();

        }

        private void garantilistele_txt_Click(object sender, EventArgs e)
        {
            try
            {
                garantilistele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toplumac_btn_Click(object sender, EventArgs e)
        {
            int i;
            int portlar = ports_box.ItemHeight ;
            
            for (i = 0; i <= portlar; i++)
            {
                try
                {                   
                    serialPort1.Open();
                    serialPort1.WriteLine(send_txt.Text + Environment.NewLine);
                    send_txt.Clear();
                    serialPort1.BaudRate = Convert.ToInt32(baudrates_box.Text);
                    receive_txt.Text = (serialPort1.ReadExisting());
                    string text = receive_txt.Text;
                    // File.WriteAllText(@"c:\deneme\deneme.txt", text);
                    int satirlar = receive_txt.Lines.Length;
                    if (satirlar > 1)
                    {
                        ListViewItem macler = listView1.Items.Add(ports_box.Text + "=" + receive_txt.Lines[4]);
                        receive_txt.Clear();
                    }
                    serialPort1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
