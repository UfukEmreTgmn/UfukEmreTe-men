using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UfukEmreTeğmen
{
    public partial class Form1 : Form
    {
        List<kaydet> kayit;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Ucak()
        {
            Ucak kaydet = new Ucak();
            kaydet.bilet = Uçak.Name;
            kaydet.kSehir = comboBox1.Text;
            kaydet.vSehir = comboBox2.Text;
            kaydet.kSaat = comboBox3.Text;
            kaydet.hSaat = (textBox2.Text + "." + textBox3.Text);
            if (checkBox1.Checked == true)
            {
                kaydet.bTip = checkBox1.Text;
            }
            else if (checkBox2.Checked == true)
            {
                kaydet.bTip = checkBox2.Text;
            }
            kaydet.fiyat = Convert.ToInt32(textBox1.Text);

            kayit.Add(kaydet);
              string[] listele = { kaydet.bilet, kaydet.kSehir, kaydet.vSehir, kaydet.kSaat, kaydet.hSaat,kaydet.bTip," ", kaydet.fiyat.ToString() };
            ListViewItem b = new ListViewItem(listele);
            listView1.Items.Add(b);

            

        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close(); 
            Application.Exit(); 
        }
		public class AutoClosingMessageBox 
                                           
		{
			System.Threading.Timer _timeoutTimer;
			string _caption;
			AutoClosingMessageBox(string text, string caption, int timeout)
			{
				_caption = caption;
				_timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
					null, timeout, System.Threading.Timeout.Infinite);
				using (_timeoutTimer)
					MessageBox.Show(text, caption);
			}
			public static void Show(string text, string caption, int timeout)
			{
				new AutoClosingMessageBox(text, caption, timeout);
			}
			void OnTimerElapsed(object state)
			{
				IntPtr mbWnd = FindWindow("#32770", _caption); 
				if (mbWnd != IntPtr.Zero)
					SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
				_timeoutTimer.Dispose();
			}
			const int WM_CLOSE = 0x0010;
			[System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
			static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
			[System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
			static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
		}
			private void Form1_Load(object sender, EventArgs e)
        {
            
            AutoClosingMessageBox.Show("<---HOŞGELDİNİZ--->", "Merhaba",2000);
            groupBox4.Enabled = false; 
            groupBox5.Enabled = false; 
            kayit = new List<kaydet>();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
			
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
			
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBox4.Enabled==false)
            {
				groupBox4.Enabled = true;
            }
            else
            {
                groupBox4.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBox5.Enabled==false)
            {
                groupBox5.Enabled = true;
            }
            else
            {
                groupBox5.Enabled = false;
            }
        }
        public void Otobus()
        {

            Otobus kaydet = new Otobus();
            kaydet.bilet = Otobüs.Name;
            kaydet.kSehir = comboBox1.Text;
            kaydet.vSehir = comboBox2.Text;
            kaydet.kSaat = comboBox3.Text;
            kaydet.hSaat = (textBox2.Text + "." + textBox3.Text);
            kaydet.dSayısıs = textBox5.Text;
            if (checkBox3.Checked == true)
            {
                kaydet.bTip = checkBox3.Text;
            }
            else if (checkBox4.Checked == true)
            {
                kaydet.bTip = checkBox4.Text;

            }
            kaydet.fiyat = Convert.ToInt32(textBox1.Text);
            kayit.Add(kaydet);
            string[] listele = { kaydet.bilet, kaydet.kSehir, kaydet.vSehir, kaydet.kSaat, kaydet.hSaat, kaydet.bTip, kaydet.dSayısıs, kaydet.fiyat.ToString() };
            ListViewItem b = new ListViewItem(listele);
            listView1.Items.Add(b);

        }
        public void Empty() // Bilet Bilgileri grubunun içerisinde doldurulması gereken alanlar boş mu kontrolü yaptım.
        {
            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 ||comboBox3.SelectedIndex<0 || textBox1.Text =="")
            {
                MessageBox.Show("!!!BİLGİLERİ EKSİKSİZ GİRİNİZ!!!", "Boş Alan Bıraktınız", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }
        public void ff()
        {

            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";


        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ff();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true || checkBox2.Checked==true)
            {
                Empty();
                Ucak();
            }
            else if (checkBox3.Checked==true || checkBox4.Checked==true)
            {
                Empty();
                Otobus();
            }
            
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void search()
        {

            listView1.Items.Clear();
            for (int i = 0; i < kayit.Count; i++)
            {
                string[] listele = kayit[i].liste();
                ListViewItem b = new ListViewItem(listele);
                listView1.Items.Add(b);
            }

        }
        public void search(int fiyat)
        {
            listView1.Items.Clear();
            for (int i = 0; i < kayit.Count; i++)
            {
                if (kayit[i].fiyat <= fiyat)
                {
                    string[] listele = kayit[i].liste();
                    ListViewItem b = new ListViewItem(listele);
                    listView1.Items.Add(b);
                }
                
            }



        }
        public void search(string kSehir)
        {
            listView1.Items.Clear();
            for (int i = 0; i < kayit.Count; i++)
            {
                if (kayit[i].kSehir.Contains(comboBox4.Text))
                {
                    string[] listele = kayit[i].liste();
                    ListViewItem b = new ListViewItem(listele);
                    listView1.Items.Add(b);
                }

            }


        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == -1 && textBox4.Text == "")
            {
                search();
            }
            else if (comboBox4.SelectedIndex != -1 && textBox4.Text == "")
            {
                string kSehir = comboBox4.Text;
                search(kSehir);
            }
            else if (comboBox4.SelectedIndex == -1 && textBox4.Text != "")
            {
                int fiyat = Convert.ToInt32(textBox4.Text);
                search(fiyat);
            }
            
        }
    }
}
