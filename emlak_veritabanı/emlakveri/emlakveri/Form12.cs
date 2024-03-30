using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace emlakveri
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\giris.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();
        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'girisDataSet.giris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.girisTableAdapter.Fill(this.girisDataSet.giris);
           
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * from giris where sirano=@sirano", baglan);
            komut.Parameters.AddWithValue("@sirano", textBox1.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);

            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                label2.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                Size = new Size(447, 489);
                textBox2.Text = dr["kullanicigiris"].ToString();
                textBox3.Text = dr["sifre"].ToString();
                MessageBox.Show("Hesap Bulundu");
            }
            else
                MessageBox.Show("Hesap Bulunamadı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = ("update giris set kullanicigiris=@kullanicigiris, sifre=@sifre where sirano=@sirano");
            komut.Parameters.AddWithValue("@kullanicigiris", textBox2.Text);
            komut.Parameters.AddWithValue("@sifre", textBox3.Text);
            komut.Parameters.AddWithValue("@siranı", textBox1.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Başarıyla Güncellendi");
            this.girisTableAdapter.Fill(this.girisDataSet.giris);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogresults;
            dialogresults = MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresults == DialogResult.Yes)
            {
                komut = new OleDbCommand();
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "Delete from giris where sirano=" + textBox1.Text + "";
                komut.ExecuteNonQuery();
                baglan.Close();
                komut.Dispose();
                ds.Clear();
                this.girisTableAdapter.Fill(this.girisDataSet.giris);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
