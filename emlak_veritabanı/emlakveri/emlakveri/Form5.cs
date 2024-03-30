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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\EmlakVeriTabani.accdb");
        OleDbCommand komut;
        DataSet ds = new DataSet();
        public double sonfiyat;
        public static string id, fiyat;
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "insert into arsa (adano,parselno,m2,adres,fiyat,imardurumu,resim)values(@adano,@parselno,@m2,@adres,@fiyat,@imardurumu,@resim)";
            komut.Parameters.AddWithValue("@adano", txtadano.Text);
            komut.Parameters.AddWithValue("@parselno", txtparselno.Text);
            komut.Parameters.AddWithValue("@m2", txtm2.Text);
            komut.Parameters.AddWithValue("@adres", rtxtadres.Text);
            komut.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
            komut.Parameters.AddWithValue("@imardurumu", cmbarsatip.Text);
            komut.Parameters.AddWithValue("@resim", txtresim.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Arsa Eklendi", "Kayıt Bilgi");
            this.arsaTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsa);
            label3.Visible = true;
            textBox1.Visible = true;
            button2.Visible = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.arsa' table. You can move, or remove it, as needed.
            this.arsaTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsa);
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.png;*.gif | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            txtresim.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
            this.arsaTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * from arsa where akayitno=@akayitno", baglan);
            komut.Parameters.AddWithValue("@akayitno", textBox1.Text);
            komut.Parameters.AddWithValue("@fiyat", txtfiyat.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Gönderildi");
                textBox1.Text = dr["akayitno"].ToString();
                txtfiyat.Text = dr["fiyat"].ToString();
            }
            else
                MessageBox.Show("Gönderilemedi");
            baglan.Close();
            id = textBox1.Text;
            fiyat = txtfiyat.Text;
            label3.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button3.Visible = true;
            }
            else
                button3.Visible = false;
        }
    }
}
