
namespace UfukEmreTeğmen
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxUçakOtobüs = new System.Windows.Forms.GroupBox();
            this.Otobüs = new System.Windows.Forms.RadioButton();
            this.Uçak = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBoxUçakOtobüs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUçakOtobüs
            // 
            this.groupBoxUçakOtobüs.Controls.Add(this.Otobüs);
            this.groupBoxUçakOtobüs.Controls.Add(this.Uçak);
            this.groupBoxUçakOtobüs.Location = new System.Drawing.Point(26, 24);
            this.groupBoxUçakOtobüs.Name = "groupBoxUçakOtobüs";
            this.groupBoxUçakOtobüs.Size = new System.Drawing.Size(224, 145);
            this.groupBoxUçakOtobüs.TabIndex = 0;
            this.groupBoxUçakOtobüs.TabStop = false;
            this.groupBoxUçakOtobüs.Text = "Bilet Türleri";
            // 
            // Otobüs
            // 
            this.Otobüs.AutoSize = true;
            this.Otobüs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Otobüs.Location = new System.Drawing.Point(21, 39);
            this.Otobüs.Name = "Otobüs";
            this.Otobüs.Size = new System.Drawing.Size(101, 20);
            this.Otobüs.TabIndex = 1;
            this.Otobüs.TabStop = true;
            this.Otobüs.Text = "Otobüs Bileti";
            this.Otobüs.UseVisualStyleBackColor = true;
            this.Otobüs.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Uçak
            // 
            this.Uçak.AutoSize = true;
            this.Uçak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Uçak.Location = new System.Drawing.Point(99, 82);
            this.Uçak.Name = "Uçak";
            this.Uçak.Size = new System.Drawing.Size(90, 20);
            this.Uçak.TabIndex = 0;
            this.Uçak.TabStop = true;
            this.Uçak.Text = "Uçak Bileti";
            this.Uçak.UseVisualStyleBackColor = true;
            this.Uçak.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 304);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "dk";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 278);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(21, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "sa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(21, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hareket Süresi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiyat (TL) ";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "08.00",
            "09.00",
            "10.00",
            "11.00",
            "12.00",
            "13.00",
            "14.00",
            "15.00",
            "16.00",
            "17.00",
            "18.00",
            "19.00",
            "20.00",
            "21.00",
            "22.00",
            "23.00",
            "00.00"});
            this.comboBox3.Location = new System.Drawing.Point(51, 152);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kalkış Saatleri";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Adana",
            "Antalya",
            "Adıyaman",
            "Ankara",
            "Burdur",
            "Bolu",
            "Bartın",
            "Çanakkale",
            "Çorum",
            "Konya",
            "Kırşehir",
            "Isparta",
            "Mersin",
            "Hatay"});
            this.comboBox2.Location = new System.Drawing.Point(51, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Varış Şehirleri";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Adana",
            "Antalya",
            "Adıyaman",
            "Ankara",
            "Burdur",
            "Bolu",
            "Bartın",
            "Çanakkale",
            "Çorum",
            "Konya",
            "Kırşehir",
            "Isparta",
            "Mersin",
            "Hatay"});
            this.comboBox1.Location = new System.Drawing.Point(51, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkış Şehirleri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "TEMİZLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "KAYDET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(279, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 226);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlı Biletler";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(570, 195);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bilet";
            this.columnHeader1.Width = 41;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kalkış Şehri";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Varış Şehri";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kalkış Saati";
            this.columnHeader4.Width = 72;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Hareket Süresi";
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Bilet Tipi";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Durak Sayısı";
            this.columnHeader7.Width = 86;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fiyat(TL)";
            this.columnHeader8.Width = 63;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(643, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 216);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıt Arama";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Kayıt Ara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(53, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Fiyat (TL)";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Adana",
            "Antalya",
            "Adıyaman",
            "Ankara",
            "Burdur",
            "Bolu",
            "Bartın",
            "Çanakkale",
            "Çorum",
            "Konya",
            "Kırşehir",
            "Isparta",
            "Mersin",
            "Hatay"});
            this.comboBox4.Location = new System.Drawing.Point(42, 46);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kalkış Şehirleri";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(490, 384);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(147, 43);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "ÇIKIŞ";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(279, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 88);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Uçak Bileti Bilgileri";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(100, 50);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Tek Yön";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Gidiş-Dönüş";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.checkBox4);
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(279, 371);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Otobüs Bileti Bilgileri";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(86, 53);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(81, 20);
            this.textBox5.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Durak Sayısı";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(18, 59);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(44, 17);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "2+2";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(18, 25);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(44, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "2+1";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 502);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxUçakOtobüs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bilet Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUçakOtobüs.ResumeLayout(false);
            this.groupBoxUçakOtobüs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUçakOtobüs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Otobüs;
        private System.Windows.Forms.RadioButton Uçak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

