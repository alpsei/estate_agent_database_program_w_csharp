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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\EmlakVeriTabani.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();
        public string site;
        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.ev' table. You can move, or remove it, as needed.
            this.evTableAdapter.Fill(this.emlakVeriTabaniDataSet.ev);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * from ev where kayitno=@kayitno", baglan);
            komut.Parameters.AddWithValue("@kayitno", textBox1.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);

            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                button3.Visible = true;
                button2.Visible = false;
                label1.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
                lblevtip.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                lblnetm2.Visible = true;
                lbloda.Visible = true;
                lblbrut.Visible = true;
                lblbanyo.Visible = true;
                lblbkat.Visible = true;
                lblkat.Visible = true;
                lblcephe.Visible = true;
                lblisi.Visible = true;
                lbladres.Visible = true;
                lblfiyat.Visible = true;
                lblres.Visible = true;
                lblrsyol.Visible = true;
                lblarsa.Visible = true;
                lblyas.Visible = true;
                lblkul.Visible = true;
                lblsite.Visible = true;
                cmbevtip.Visible = true;
                txtnetm2.Visible = true;
                cmboda.Visible = true;
                txtbrutm2.Visible = true;
                cmbbanyo.Visible = true;
                cmbbulkat.Visible = true;
                cmbbinakat.Visible = true;
                cmbcephe.Visible = true;
                cmbisi.Visible = true;
                rtxtadres.Visible = true;
                txtfiyat.Visible = true;
                txtresim.Visible = true;
                txtarsahak.Visible = true;
                cmbyas.Visible = true;
                cmbkullan.Visible = true;
                btnres.Visible = true;
                pictureBox1.Visible = true;
                cmbevtip.Text = dr["evtipi"].ToString();
                txtnetm2.Text = dr["netm2"].ToString();
                cmboda.Text = dr["odasayisi"].ToString();
                txtbrutm2.Text = dr["brutm2"].ToString();
                cmbbanyo.Text = dr["banyosayisi"].ToString();
                cmbbulkat.Text = dr["kat"].ToString();
                cmbbinakat.Text = dr["binakatsayisi"].ToString();
                cmbcephe.Text = dr["cephe"].ToString();
                cmbisi.Text = dr["isinmatipi"].ToString();
                rtxtadres.Text = dr["adres"].ToString();
                txtfiyat.Text = dr["fiyat"].ToString();
                txtresim.Text = dr["resim"].ToString();
                txtarsahak.Text = dr["arsahakki"].ToString();
                cmbyas.Text = dr["binayasi"].ToString();
                cmbkullan.Text = dr["kullanimdurumu"].ToString();

            }
            else

                MessageBox.Show("Ev Kaydı Bulunamadı");
            baglan.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = ("update ev set evtipi=@evtipi,netm2=@odasayisi,brutm2=@brutm2,banyosayisi=@banyosayisi,kat=@kat,binakatsayisi=@binakatsayisi,cephe=@cephe,isinmatipi=@isinmatipi,adres=@adres,fiyat=@fiyat,resim=@resim,arsahakki=@arsahakki,binayasi=@binayasi,kullanimdurumu=@kullanimdurumu,siteicerisi=@siteicerisi where kayitno=@kayitno");
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
            komut.Parameters.AddWithValue("@kayitno", textBox1.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Başarıyla Güncellendi");
            this.evTableAdapter.Fill(this.emlakVeriTabaniDataSet.ev);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            site = "Evet";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            site = "Hayır";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                komut = new OleDbCommand();
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "Delete from ev where kayitno=" + textBox1.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglan.Close();
                ds.Clear();
                this.evTableAdapter.Fill(this.emlakVeriTabaniDataSet.ev);
            }
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.png;*.gif | Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            txtresim.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
            this.evTableAdapter.Fill(this.emlakVeriTabaniDataSet.ev);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}