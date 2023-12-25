namespace stokproje
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.open_bttn = new System.Windows.Forms.Button();
            this.close_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.send_txt = new System.Windows.Forms.TextBox();
            this.receive_txt = new System.Windows.Forms.TextBox();
            this.receive_bttn = new System.Windows.Forms.Button();
            this.send_bttn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ports_box = new System.Windows.Forms.ComboBox();
            this.baudrates_box = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.toda = new System.Windows.Forms.TextBox();
            this.garantibaslangic_txt = new System.Windows.Forms.TextBox();
            this.garantibitis_txt = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.garantiay = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.modulid_txt = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.yenimodul_txt = new MaterialSkin.Controls.MaterialFlatButton();
            this.garantilistele_txt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.toplumac_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(883, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // open_bttn
            // 
            this.open_bttn.Location = new System.Drawing.Point(407, 72);
            this.open_bttn.Name = "open_bttn";
            this.open_bttn.Size = new System.Drawing.Size(128, 23);
            this.open_bttn.TabIndex = 1;
            this.open_bttn.Text = "BAĞLANTIYI AÇ";
            this.open_bttn.UseVisualStyleBackColor = true;
            this.open_bttn.Click += new System.EventHandler(this.open_bttn_Click);
            // 
            // close_bttn
            // 
            this.close_bttn.Location = new System.Drawing.Point(407, 101);
            this.close_bttn.Name = "close_bttn";
            this.close_bttn.Size = new System.Drawing.Size(128, 23);
            this.close_bttn.TabIndex = 2;
            this.close_bttn.Text = "BAĞLANTIYI KES";
            this.close_bttn.UseVisualStyleBackColor = true;
            this.close_bttn.Click += new System.EventHandler(this.close_bttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(9, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port";
            // 
            // send_txt
            // 
            this.send_txt.Location = new System.Drawing.Point(17, 205);
            this.send_txt.Multiline = true;
            this.send_txt.Name = "send_txt";
            this.send_txt.Size = new System.Drawing.Size(294, 141);
            this.send_txt.TabIndex = 5;
            // 
            // receive_txt
            // 
            this.receive_txt.Location = new System.Drawing.Point(320, 205);
            this.receive_txt.Multiline = true;
            this.receive_txt.Name = "receive_txt";
            this.receive_txt.Size = new System.Drawing.Size(306, 141);
            this.receive_txt.TabIndex = 6;
            // 
            // receive_bttn
            // 
            this.receive_bttn.Location = new System.Drawing.Point(320, 171);
            this.receive_bttn.Name = "receive_bttn";
            this.receive_bttn.Size = new System.Drawing.Size(122, 28);
            this.receive_bttn.TabIndex = 7;
            this.receive_bttn.Text = "KARŞILA";
            this.receive_bttn.UseVisualStyleBackColor = true;
            this.receive_bttn.Click += new System.EventHandler(this.receive_bttn_Click);
            // 
            // send_bttn
            // 
            this.send_bttn.Location = new System.Drawing.Point(17, 171);
            this.send_bttn.Name = "send_bttn";
            this.send_bttn.Size = new System.Drawing.Size(122, 28);
            this.send_bttn.TabIndex = 8;
            this.send_bttn.Text = "GÖNDER";
            this.send_bttn.UseVisualStyleBackColor = true;
            this.send_bttn.Click += new System.EventHandler(this.send_bttn_Click);
            // 
            // ports_box
            // 
            this.ports_box.FormattingEnabled = true;
            this.ports_box.Location = new System.Drawing.Point(58, 87);
            this.ports_box.Name = "ports_box";
            this.ports_box.Size = new System.Drawing.Size(140, 21);
            this.ports_box.TabIndex = 9;
            // 
            // baudrates_box
            // 
            this.baudrates_box.FormattingEnabled = true;
            this.baudrates_box.Items.AddRange(new object[] {
            "115200",
            "57600",
            "38400",
            "19200",
            "9600",
            "1200",
            "300",
            "921600",
            "460800",
            "230400",
            "4800",
            "2400",
            "150",
            "110"});
            this.baudrates_box.Location = new System.Drawing.Point(314, 87);
            this.baudrates_box.Name = "baudrates_box";
            this.baudrates_box.Size = new System.Drawing.Size(86, 21);
            this.baudrates_box.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(553, 96);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(203, 23);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(212, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Baud Rate";
            // 
            // toda
            // 
            this.toda.Location = new System.Drawing.Point(752, 70);
            this.toda.Name = "toda";
            this.toda.Size = new System.Drawing.Size(116, 20);
            this.toda.TabIndex = 13;
            this.toda.TextChanged += new System.EventHandler(this.toda_TextChanged);
            // 
            // garantibaslangic_txt
            // 
            this.garantibaslangic_txt.Location = new System.Drawing.Point(660, 155);
            this.garantibaslangic_txt.Name = "garantibaslangic_txt";
            this.garantibaslangic_txt.Size = new System.Drawing.Size(188, 20);
            this.garantibaslangic_txt.TabIndex = 15;
            // 
            // garantibitis_txt
            // 
            this.garantibitis_txt.Location = new System.Drawing.Point(660, 205);
            this.garantibitis_txt.Name = "garantibitis_txt";
            this.garantibitis_txt.Size = new System.Drawing.Size(188, 20);
            this.garantibitis_txt.TabIndex = 16;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(656, 133);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(126, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Garanti Baslangıç";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(660, 185);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(91, 19);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "Garanti Bitiş";
            // 
            // garantiay
            // 
            this.garantiay.Location = new System.Drawing.Point(507, 160);
            this.garantiay.Name = "garantiay";
            this.garantiay.Size = new System.Drawing.Size(77, 20);
            this.garantiay.TabIndex = 19;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(467, 138);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(137, 19);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "Toplam Garanti Ayı";
            // 
            // modulid_txt
            // 
            this.modulid_txt.Location = new System.Drawing.Point(665, 269);
            this.modulid_txt.Name = "modulid_txt";
            this.modulid_txt.Size = new System.Drawing.Size(152, 20);
            this.modulid_txt.TabIndex = 21;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(660, 247);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 19);
            this.materialLabel4.TabIndex = 22;
            this.materialLabel4.Text = "Modül ID";
            // 
            // yenimodul_txt
            // 
            this.yenimodul_txt.AutoSize = true;
            this.yenimodul_txt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yenimodul_txt.Depth = 0;
            this.yenimodul_txt.Icon = null;
            this.yenimodul_txt.Location = new System.Drawing.Point(660, 25);
            this.yenimodul_txt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.yenimodul_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.yenimodul_txt.Name = "yenimodul_txt";
            this.yenimodul_txt.Primary = false;
            this.yenimodul_txt.Size = new System.Drawing.Size(143, 36);
            this.yenimodul_txt.TabIndex = 23;
            this.yenimodul_txt.Text = "Yeni Modül Kaydı";
            this.yenimodul_txt.UseVisualStyleBackColor = true;
            this.yenimodul_txt.Click += new System.EventHandler(this.yenimodul_txt_Click);
            // 
            // garantilistele_txt
            // 
            this.garantilistele_txt.AutoSize = true;
            this.garantilistele_txt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.garantilistele_txt.Depth = 0;
            this.garantilistele_txt.Icon = null;
            this.garantilistele_txt.Location = new System.Drawing.Point(665, 310);
            this.garantilistele_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.garantilistele_txt.Name = "garantilistele_txt";
            this.garantilistele_txt.Primary = true;
            this.garantilistele_txt.Size = new System.Drawing.Size(161, 36);
            this.garantilistele_txt.TabIndex = 24;
            this.garantilistele_txt.Text = "Garantileri Listele";
            this.garantilistele_txt.UseVisualStyleBackColor = true;
            this.garantilistele_txt.Click += new System.EventHandler(this.garantilistele_txt_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(633, 123);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(238, 181);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // toplumac_btn
            // 
            this.toplumac_btn.AutoSize = true;
            this.toplumac_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.toplumac_btn.Depth = 0;
            this.toplumac_btn.Icon = null;
            this.toplumac_btn.Location = new System.Drawing.Point(139, 130);
            this.toplumac_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.toplumac_btn.Name = "toplumac_btn";
            this.toplumac_btn.Primary = true;
            this.toplumac_btn.Size = new System.Drawing.Size(150, 36);
            this.toplumac_btn.TabIndex = 26;
            this.toplumac_btn.Text = "Get Mac Adresses  ";
            this.toplumac_btn.UseVisualStyleBackColor = true;
            this.toplumac_btn.Click += new System.EventHandler(this.toplumac_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 565);
            this.Controls.Add(this.toplumac_btn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.garantilistele_txt);
            this.Controls.Add(this.yenimodul_txt);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.modulid_txt);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.garantiay);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.garantibitis_txt);
            this.Controls.Add(this.garantibaslangic_txt);
            this.Controls.Add(this.toda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.baudrates_box);
            this.Controls.Add(this.ports_box);
            this.Controls.Add(this.send_bttn);
            this.Controls.Add(this.receive_bttn);
            this.Controls.Add(this.receive_txt);
            this.Controls.Add(this.send_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_bttn);
            this.Controls.Add(this.open_bttn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button open_bttn;
        private System.Windows.Forms.Button close_bttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox send_txt;
        private System.Windows.Forms.TextBox receive_txt;
        private System.Windows.Forms.Button receive_bttn;
        private System.Windows.Forms.Button send_bttn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox ports_box;
        private System.Windows.Forms.ComboBox baudrates_box;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toda;
        private System.Windows.Forms.TextBox garantibaslangic_txt;
        private System.Windows.Forms.TextBox garantibitis_txt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox garantiay;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox modulid_txt;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFlatButton yenimodul_txt;
        private MaterialSkin.Controls.MaterialRaisedButton garantilistele_txt;
        private System.Windows.Forms.ListView listView1;
        private MaterialSkin.Controls.MaterialRaisedButton toplumac_btn;
    }
}