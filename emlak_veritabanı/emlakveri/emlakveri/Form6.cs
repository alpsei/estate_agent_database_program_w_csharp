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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\EmlakVeriTabani.accdb");
        OleDbCommand komut;
        DataSet ds = new DataSet();
        public double sonfiyat;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.Visible = true;
                label9.Visible = true;
                button6.Visible = true;
                checkBox1.Visible = false;
            }
            else
            {
                textBox2.Visible = false;
                label9.Visible = false;
                button6.Visible = false;
            }
        }
        public double fiyat, kdv, tt;
        private void button1_Click(object sender, EventArgs e)
        {
            fiyat = double.Parse(txtsatisfiyat.Text);
            kdv = double.Parse(txtkdv.Text);
            tt = fiyat + fiyat * kdv / 100;
            textBox3.Text = tt.ToString();
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "insert into arsasatis (akayitno,satisiyapan,alankisi,alimtar,satisfiyat,kdv)values(@kayitno,@satisiyapan,@alankisi,@alimtar,@satisfiyat,@kdv)";
            komut.Parameters.AddWithValue("@kayitno", txtkayitno.Text);
            komut.Parameters.AddWithValue("@satisiyapan", txtsatisiyapan.Text);
            komut.Parameters.AddWithValue("@alankisi", txtalankisi.Text);
            komut.Parameters.AddWithValue("@alimtar", alimtar.Value.ToShortDateString());
            komut.Parameters.AddWithValue("@satisfiyat", textBox3.Text);
            komut.Parameters.AddWithValue("@kdv", txtkdv.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Arsa Satıldı", "Satış Bilgi");
            this.arsasatisTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsasatis);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            txtsatisfiyat.Text = Form5.fiyat;
            txtkayitno.Text = Form5.id;
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.arsa' table. You can move, or remove it, as needed.
            this.arsaTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsa);
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.arsasatis' table. You can move, or remove it, as needed.
            this.arsasatisTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsasatis);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = ("update arsasatis set akayitno=@akayitno,satisiyapan=@satisiyapan,alankisi=@alankisi,alimtar=@alimtar,satisfiyat=@satisfiyat,kdv=@kdv where satisno=@satisno");
            komut.Parameters.AddWithValue("@akayitno", txtkayitno.Text);
            komut.Parameters.AddWithValue("@satisiyapan", txtsatisiyapan.Text);
            komut.Parameters.AddWithValue("@alankisi", txtalankisi.Text);
            komut.Parameters.AddWithValue("@alimtar", alimtar.Value.ToShortDateString());
            komut.Parameters.AddWithValue("@satisfiyat", txtsatisfiyat.Text);
            komut.Parameters.AddWithValue("@kdv", txtkdv.Text);
            komut.Parameters.AddWithValue("@satisno", textBox2.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Başarıyla Güncellendi");
            this.arsasatisTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsasatis);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek İstediğinizden Emin Misiniz ?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                komut = new OleDbCommand();
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "Delete from arsa where satisno=" + textBox2.Text + "";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglan.Close();
                ds.Clear();
                this.arsasatisTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsasatis);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * from arsasatis where satisno=@satisno", baglan);
            komut.Parameters.AddWithValue("@satisno", textBox2.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Satış Bulundu", "Satış Bilgisi");
                txtsatisfiyat.Text = dr["fiyat"].ToString();
                txtalankisi.Text = dr["alankisi"].ToString();
                txtsatisiyapan.Text = dr["satisiyapan"].ToString();
                txtkdv.Text = dr["kdv"].ToString();
            }
            else
                MessageBox.Show("Satış Bulunamadı", "Satış Bilgisi");
            baglan.Close();
        }
    }
}