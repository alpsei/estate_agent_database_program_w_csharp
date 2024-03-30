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
   
    public partial class Form11 : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\giris.accdb");
        OleDbCommand komut;
        DataSet dtst = new DataSet();
        public Form11()
        {
            InitializeComponent();
        }
        public string kuladi, sifre;
        private void button1_Click(object sender, EventArgs e)
        {
            kuladi = Convert.ToString(textBox1.Text);
            sifre = Convert.ToString(textBox2.Text);
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "insert into giris (kullanicigiris,sifre)values(@kullanicigiris,@sifre)";
            komut.Parameters.AddWithValue("@kullanicigiris", textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Başarıyla Kaydedildi!", "Bilgi");
            DialogResult dg = MessageBox.Show("Giriş Ekranına Dönülüyor...","Bilgi", MessageBoxButtons.OK);
            if (dg == DialogResult.OK)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else { }
           

        }
    }
}
