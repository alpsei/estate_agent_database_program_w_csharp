using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace emlakveri
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\EmlakVeriTabani.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();
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

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.arsa' table. You can move, or remove it, as needed.
            this.arsaTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           OleDbCommand komut=new OleDbCommand();
            baglan.Open();
            komut.Connection=baglan;
            komut.CommandText="update arsa set adano=@adano,parselno=@parselno,m2=@m2,adres=@adres,fiyat=@fiyat,imardurumu=@imardurumu,resim=@resim where akayitno=@akayitno";
            komut.Parameters.AddWithValue("@adano",txtadano.Text);
            komut.Parameters.AddWithValue("@parselno",txtparselno.Text);
            komut.Parameters.AddWithValue("@m2",txtm2.Text);
            komut.Parameters.AddWithValue("@adres",rtxtadres.Text);
            komut.Parameters.AddWithValue("@fiyat",txtfiyat.Text);
            komut.Parameters.AddWithValue("@imardurumu",cmbarsatip.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@resim",txtresim.Text);
            komut.Parameters.AddWithValue("@akayitno",textBox1.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Başarıyla Güncellendi");
            this.arsaTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsa);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * from arsa where akayitno=@akayitno", baglan);
            komut.Parameters.AddWithValue("@akayitno", textBox1.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Kayıt Bulundu", "Kayıt Bilgisi");
                rtxtadres.Visible = true;
                cmbarsatip.Visible = true;
                txtadano.Visible = true;
                txtfiyat.Visible = true;
                txtm2.Visible = true;
                txtparselno.Visible = true;
                txtresim.Visible = true;
                pictureBox1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label13.Visible = true;
                button4.Visible = true;
                label14.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                button5.Visible = true;
                button6.Visible = false;
                txtresim.Visible = true;
                txtadano.Text = dr["adano"].ToString();
                txtparselno.Text = dr["parselno"].ToString();
                txtm2.Text = dr["m2"].ToString();
                rtxtadres.Text = dr["adres"].ToString();
                txtfiyat.Text = dr["fiyat"].ToString();
                cmbarsatip.Text = dr["imardurumu"].ToString();
                txtresim.Text = dr["resim"].ToString();
                baglan.Close();
            }
            else
                MessageBox.Show("Kayıt Bulunamadı", "Kayıt Bilgisi");
            this.arsaTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsa);
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                komut = new OleDbCommand();
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "Delete from arsa where akayitno=" + textBox1.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglan.Close();
                ds.Clear();
                this.arsaTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsa);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}