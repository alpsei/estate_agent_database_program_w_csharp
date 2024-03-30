using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace emlakveri
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\EmlakVeriTabani.accdb");
        OleDbCommand komut=new OleDbCommand();
        DataSet ds = new DataSet();
        string site;
        public static string id,fiyat;
        
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.ev' table. You can move, or remove it, as needed.
            this.evTableAdapter.Fill(this.emlakVeriTabaniDataSet.ev);
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.ev' table. You can move, or remove it, as needed.
            this.evTableAdapter.Fill(this.emlakVeriTabaniDataSet.ev);
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.ev' table. You can move, or remove it, as needed.
            this.evTableAdapter.Fill(this.emlakVeriTabaniDataSet.ev);
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.ev' table. You can move, or remove it, as needed.
            this.evTableAdapter.Fill(this.emlakVeriTabaniDataSet.ev);
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.ev' table. You can move, or remove it, as needed.
            this.evTableAdapter.Fill(this.emlakVeriTabaniDataSet.ev);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "insert into ev (evtipi,netm2,odasayisi,brutm2,banyosayisi,kat,binakatsayisi,cephe,isinmatipi,adres,fiyat,resim,arsahakki,binayasi,kullanimdurumu,siteicerisi)values(@evtipi,@netm2,@odasayisi,@brutm2,@banyosayisi,@kat,@binakatsayisi,@cephe,@isinmatipi,@adres,@fiyat,@resim,@arsahakki,@binayasi,@kullanimdurumu,@siteicerisi)";
            komut.Parameters.AddWithValue("@evtipi", cmbevtip.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@netm2", txtnetm2.Text);
            komut.Parameters.AddWithValue("@odasayisi", cmboda.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@brutm2", txtbrutm2.Text);
            komut.Parameters.AddWithValue("@banyosayisi", cmbbanyo.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@kat", cmbbulkat.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@binakatsayisi", cmbbinakat.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@cephe", cmbcephe.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@isinmatipi", cmbisi.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@adres", rtxtadres.Text);
            komut.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
            komut.Parameters.AddWithValue("@resim", txtresim.Text);
            komut.Parameters.AddWithValue("@arsahakki", txtarsahak.Text);
            komut.Parameters.AddWithValue("@binayasi", cmbyas.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@kullanimdurumu", cmbkullan.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@siteicerisi", site);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Tamamlandı.");
            this.evTableAdapter.Fill(this.emlakVeriTabaniDataSet.ev);
            cmbbanyo.Text = "";
            txtnetm2.Clear();
            txtfiyat.Clear();
            txtbrutm2.Clear();
            txtarsahak.Clear();
            cmbevtip.Text = "";
            cmboda.Text = "";
            cmbbulkat.Text = "";
            cmbbinakat.Text = "";
            cmbcephe.Text = "";
            cmbisi.Text = "";
            rtxtadres.Clear();
            txtfiyat.Clear();
            txtresim.Clear();
            txtarsahak.Clear();
            label18.Visible = true;
            textBox1.Visible = true;
            button2.Visible = true;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.png;*.gif | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            txtresim.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
            this.evTableAdapter.Fill(this.emlakVeriTabaniDataSet.ev);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Kayıt No Giriniz!!");
            }
            else
            {
                Form4 f = new Form4();
                f.Show();
                this.Hide();
            }
            button2.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            site = "Evet";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            site = "Hayır";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * from ev where kayitno=@kayitno", baglan);
            komut.Parameters.AddWithValue("@kayitno", textBox1.Text);
            komut.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Gönderildi");
                textBox1.Text = dr["kayitno"].ToString();
                txtfiyat.Text = dr["fiyat"].ToString();
                button2.Visible = false;
            }
            else
            {
                MessageBox.Show("Gönderilemedi Tekrar Deneyiniz");
                button2.Visible = true;
            }
            baglan.Close();
            id = textBox1.Text;
            fiyat = txtfiyat.Text;
            textBox1.Visible = false;
            label18.Visible = false;
            button5.Enabled = true;
            

        }

        private void cmbevtip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbevtip.SelectedItem == "Müstakil Ev")
            {
                cmbbulkat.Enabled = false;
                cmbbulkat.SelectedItem = "Müstakil";
                cmbbinakat.Items.Remove("3");
                cmbbinakat.Items.Remove("4");
                cmbbinakat.Items.Remove("5");
                cmbbinakat.Items.Remove("6");
                cmbbinakat.Items.Remove("7");
                cmbbinakat.Items.Remove("8");
                cmbbinakat.Items.Remove("9");
                cmbbinakat.Items.Remove("10");
                cmbbinakat.Items.Remove("11");
                cmbbinakat.Items.Remove("12");
                cmbbinakat.Items.Remove("13");
                cmbbinakat.Items.Remove("14");
                cmbbinakat.Items.Remove("15");
                cmbbinakat.Items.Remove("16");
                cmbbinakat.Items.Remove("17");
                cmbbinakat.Items.Remove("18");
                cmbbinakat.Items.Remove("19");
                cmbbinakat.Items.Remove("20");
                cmbbinakat.Items.Remove("20 ve üzeri");
                cmbbinakat.Items.Add("1");
                cmbbinakat.Items.Add("2");
                cmbbinakat.Items.Add("3");
                cmbbinakat.Items.Add("4");
                
            }
            else if (cmbevtip.SelectedItem == "Yazlık")
            {
                cmbbulkat.Enabled = false;
                cmbbulkat.SelectedItem = "Müstakil";
                cmbbinakat.Items.Remove("3");
                cmbbinakat.Items.Remove("4");
                cmbbinakat.Items.Remove("5");
                cmbbinakat.Items.Remove("6");
                cmbbinakat.Items.Remove("7");
                cmbbinakat.Items.Remove("8");
                cmbbinakat.Items.Remove("9");
                cmbbinakat.Items.Remove("10");
                cmbbinakat.Items.Remove("11");
                cmbbinakat.Items.Remove("12");
                cmbbinakat.Items.Remove("13");
                cmbbinakat.Items.Remove("14");
                cmbbinakat.Items.Remove("15");
                cmbbinakat.Items.Remove("16");
                cmbbinakat.Items.Remove("17");
                cmbbinakat.Items.Remove("18");
                cmbbinakat.Items.Remove("19");
                cmbbinakat.Items.Remove("20");
                cmbbinakat.Items.Remove("20 ve üzeri");
                cmbbinakat.Items.Add("1");
                cmbbinakat.Items.Add("2");
                cmbbinakat.Items.Add("3");
                cmbbinakat.Items.Add("4");
            }
            else if (cmbevtip.SelectedItem == "Daire")
            {
                cmbbinakat.Items.Remove("1");
                cmbbinakat.Items.Remove("2");
                cmbbinakat.Items.Remove("3");
                cmbbinakat.Items.Remove("4");
                cmbbinakat.Items.Add("3");
                cmbbinakat.Items.Add("4");
                cmbbinakat.Items.Add("5");
                cmbbinakat.Items.Add("6");
                cmbbinakat.Items.Add("7");
                cmbbinakat.Items.Add("8");
                cmbbinakat.Items.Add("9");
                cmbbinakat.Items.Add("10");
                cmbbinakat.Items.Add("11");
                cmbbinakat.Items.Add("12");
                cmbbinakat.Items.Add("13");
                cmbbinakat.Items.Add("14");
                cmbbinakat.Items.Add("15");
                cmbbinakat.Items.Add("16");
                cmbbinakat.Items.Add("17");
                cmbbinakat.Items.Add("18");
                cmbbinakat.Items.Add("19");
                cmbbinakat.Items.Add("20");
                cmbbinakat.Items.Add("20 ve üzeri");
            }
            else if (cmbevtip.SelectedItem == "Villa")
            {
                cmbbulkat.Enabled = false;
                cmbbulkat.SelectedItem = "Müstakil";
                cmbbinakat.Items.Remove("3");
                cmbbinakat.Items.Remove("4");
                cmbbinakat.Items.Remove("5");
                cmbbinakat.Items.Remove("6");
                cmbbinakat.Items.Remove("7");
                cmbbinakat.Items.Remove("8");
                cmbbinakat.Items.Remove("9");
                cmbbinakat.Items.Remove("10");
                cmbbinakat.Items.Remove("11");
                cmbbinakat.Items.Remove("12");
                cmbbinakat.Items.Remove("13");
                cmbbinakat.Items.Remove("14");
                cmbbinakat.Items.Remove("15");
                cmbbinakat.Items.Remove("16");
                cmbbinakat.Items.Remove("17");
                cmbbinakat.Items.Remove("18");
                cmbbinakat.Items.Remove("19");
                cmbbinakat.Items.Remove("20");
                cmbbinakat.Items.Remove("20 ve üzeri");
                cmbbinakat.Items.Add("1");
                cmbbinakat.Items.Add("2");
                cmbbinakat.Items.Add("3");
                cmbbinakat.Items.Add("4");
            }
            else if (cmbevtip.SelectedItem == "Residence")
            {
                cmbbinakat.Items.Remove("1");
                cmbbinakat.Items.Remove("2");
                cmbbinakat.Items.Remove("3");
                cmbbinakat.Items.Remove("4");
                cmbbinakat.Items.Add("3");
                cmbbinakat.Items.Add("4");
                cmbbinakat.Items.Add("5");
                cmbbinakat.Items.Add("6");
                cmbbinakat.Items.Add("7");
                cmbbinakat.Items.Add("8");
                cmbbinakat.Items.Add("9");
                cmbbinakat.Items.Add("10");
                cmbbinakat.Items.Add("11");
                cmbbinakat.Items.Add("12");
                cmbbinakat.Items.Add("13");
                cmbbinakat.Items.Add("14");
                cmbbinakat.Items.Add("15");
                cmbbinakat.Items.Add("16");
                cmbbinakat.Items.Add("17");
                cmbbinakat.Items.Add("18");
                cmbbinakat.Items.Add("19");
                cmbbinakat.Items.Add("20");
                cmbbinakat.Items.Add("20 ve üzeri");
                
            }
            else if (cmbevtip.SelectedItem == "Çiftlik Evi")
            {
                cmbbulkat.Enabled = false;
                cmbbulkat.SelectedItem = "Müstakil";
                cmbbinakat.Items.Remove("3");
                cmbbinakat.Items.Remove("4");
                cmbbinakat.Items.Remove("5");
                cmbbinakat.Items.Remove("6");
                cmbbinakat.Items.Remove("7");
                cmbbinakat.Items.Remove("8");
                cmbbinakat.Items.Remove("9");
                cmbbinakat.Items.Remove("10");
                cmbbinakat.Items.Remove("11");
                cmbbinakat.Items.Remove("12");
                cmbbinakat.Items.Remove("13");
                cmbbinakat.Items.Remove("14");
                cmbbinakat.Items.Remove("15");
                cmbbinakat.Items.Remove("16");
                cmbbinakat.Items.Remove("17");
                cmbbinakat.Items.Remove("18");
                cmbbinakat.Items.Remove("19");
                cmbbinakat.Items.Remove("20");
                cmbbinakat.Items.Remove("20 ve üzeri");
                cmbbinakat.Items.Add("1");
                cmbbinakat.Items.Add("2");
                cmbbinakat.Items.Add("3");
                cmbbinakat.Items.Add("4");
            }
            else if (cmbevtip.SelectedItem == "Köşk & Konak")
            {
                cmbbulkat.Enabled = false;
                cmbbulkat.SelectedItem = "Müstakil";
                cmbbinakat.Items.Remove("3");
                cmbbinakat.Items.Remove("4");
                cmbbinakat.Items.Remove("5");
                cmbbinakat.Items.Remove("6");
                cmbbinakat.Items.Remove("7");
                cmbbinakat.Items.Remove("8");
                cmbbinakat.Items.Remove("9");
                cmbbinakat.Items.Remove("10");
                cmbbinakat.Items.Remove("11");
                cmbbinakat.Items.Remove("12");
                cmbbinakat.Items.Remove("13");
                cmbbinakat.Items.Remove("14");
                cmbbinakat.Items.Remove("15");
                cmbbinakat.Items.Remove("16");
                cmbbinakat.Items.Remove("17");
                cmbbinakat.Items.Remove("18");
                cmbbinakat.Items.Remove("19");
                cmbbinakat.Items.Remove("20");
                cmbbinakat.Items.Remove("20 ve üzeri");
                cmbbinakat.Items.Add("1");
                cmbbinakat.Items.Add("2");
                cmbbinakat.Items.Add("3");
                cmbbinakat.Items.Add("4");
            }
            else if (cmbevtip.SelectedItem == "Yalı")
            {
                cmbbulkat.Enabled = false;
                cmbbulkat.SelectedItem = "Müstakil";
                cmbbinakat.Items.Remove("3");
                cmbbinakat.Items.Remove("4");
                cmbbinakat.Items.Remove("5");
                cmbbinakat.Items.Remove("6");
                cmbbinakat.Items.Remove("7");
                cmbbinakat.Items.Remove("8");
                cmbbinakat.Items.Remove("9");
                cmbbinakat.Items.Remove("10");
                cmbbinakat.Items.Remove("11");
                cmbbinakat.Items.Remove("12");
                cmbbinakat.Items.Remove("13");
                cmbbinakat.Items.Remove("14");
                cmbbinakat.Items.Remove("15");
                cmbbinakat.Items.Remove("16");
                cmbbinakat.Items.Remove("17");
                cmbbinakat.Items.Remove("18");
                cmbbinakat.Items.Remove("19");
                cmbbinakat.Items.Remove("20");
                cmbbinakat.Items.Remove("20 ve üzeri");
                cmbbinakat.Items.Add("1");
                cmbbinakat.Items.Add("2");
                cmbbinakat.Items.Add("3");
                cmbbinakat.Items.Add("4");
            }
            else if (cmbevtip.SelectedItem == "Yalı Dairesi")
            {
                cmbbulkat.Enabled = false;
                cmbbulkat.SelectedItem = "Müstakil";
                cmbbinakat.Items.Remove("3");
                cmbbinakat.Items.Remove("4");
                cmbbinakat.Items.Remove("5");
                cmbbinakat.Items.Remove("6");
                cmbbinakat.Items.Remove("7");
                cmbbinakat.Items.Remove("8");
                cmbbinakat.Items.Remove("9");
                cmbbinakat.Items.Remove("10");
                cmbbinakat.Items.Remove("11");
                cmbbinakat.Items.Remove("12");
                cmbbinakat.Items.Remove("13");
                cmbbinakat.Items.Remove("14");
                cmbbinakat.Items.Remove("15");
                cmbbinakat.Items.Remove("16");
                cmbbinakat.Items.Remove("17");
                cmbbinakat.Items.Remove("18");
                cmbbinakat.Items.Remove("19");
                cmbbinakat.Items.Remove("20");
                cmbbinakat.Items.Remove("20 ve üzeri");
                cmbbinakat.Items.Add("1");
                cmbbinakat.Items.Add("2");
                cmbbinakat.Items.Add("3");
                cmbbinakat.Items.Add("4");
            }
            else if (cmbevtip.SelectedItem == "Prefabrik Ev")
            {
                cmbbulkat.Enabled = false;
                cmbbulkat.SelectedItem = "Müstakil";
                cmbbinakat.Items.Remove("3");
                cmbbinakat.Items.Remove("4");
                cmbbinakat.Items.Remove("5");
                cmbbinakat.Items.Remove("6");
                cmbbinakat.Items.Remove("7");
                cmbbinakat.Items.Remove("8");
                cmbbinakat.Items.Remove("9");
                cmbbinakat.Items.Remove("10");
                cmbbinakat.Items.Remove("11");
                cmbbinakat.Items.Remove("12");
                cmbbinakat.Items.Remove("13");
                cmbbinakat.Items.Remove("14");
                cmbbinakat.Items.Remove("15");
                cmbbinakat.Items.Remove("16");
                cmbbinakat.Items.Remove("17");
                cmbbinakat.Items.Remove("18");
                cmbbinakat.Items.Remove("19");
                cmbbinakat.Items.Remove("20");
                cmbbinakat.Items.Remove("20 ve üzeri");
                cmbbinakat.Items.Add("1");
                cmbbinakat.Items.Add("2");
                cmbbinakat.Items.Add("3");
                cmbbinakat.Items.Add("4");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void cmbbanyo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button5.Visible = true;
            }
            else
                button5.Visible = false;

        }
    }
}
