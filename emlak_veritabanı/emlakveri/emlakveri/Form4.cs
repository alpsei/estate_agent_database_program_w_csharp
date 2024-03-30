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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\EmlakVeriTabani.accdb");
        OleDbCommand komut;
        DataSet ds = new DataSet();
        public double fiyat, kdv, tt;
        
        private void Form4_Load(object sender, EventArgs e)
        {

            txtkayitno.Text = Form3.id;
            txtsatisfiyat.Text = Form3.fiyat;
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.evsatis' table. You can move, or remove it, as needed.
            this.evsatisTableAdapter.Fill(this.emlakVeriTabaniDataSet.evsatis);
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.evsatis' table. You can move, or remove it, as needed.
            this.evsatisTableAdapter.Fill(this.emlakVeriTabaniDataSet.evsatis);
   
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fiyat = double.Parse(txtsatisfiyat.Text);
            kdv = double.Parse(txtkdv.Text);
            tt = fiyat + fiyat * kdv / 100;
            textBox3.Text = tt.ToString();
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "insert into evsatis (kayitno,satisiyapan,alankisi,alimtar,satisfiyat,kdv)values(@kayitno,@satisiyapan,@alankisi,@alimtar,@satisfiyat,@kdv)";
            komut.Parameters.AddWithValue("@kayitno", txtkayitno.Text);
            komut.Parameters.AddWithValue("@satisiyapan", txtsatisiyapan.Text);
            komut.Parameters.AddWithValue("@alankisi",txtalankisi.Text);
            komut.Parameters.AddWithValue("@alimtar", alimtar.Value.ToShortDateString());
            komut.Parameters.AddWithValue("@satisfiyat", textBox3.Text);
            komut.Parameters.AddWithValue("@kdv", txtkdv.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Ev Satıldı","Satış Bilgi");
            this.evsatisTableAdapter.Fill(this.emlakVeriTabaniDataSet.evsatis);

     
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = ("update evsatis set kayitno=@kayitno,satisiyapan=@satisiyapan,alankisi=@alankisi,alimtar=@alimtar,satisfiyat=@satisfiyat,kdv=@kdv where satisno=@satisno");
            komut.Parameters.AddWithValue("@kayitno", txtkayitno.Text);
            komut.Parameters.AddWithValue("@satisiyapan", txtsatisiyapan.Text);
            komut.Parameters.AddWithValue("@alankisi", txtalankisi.Text);
            komut.Parameters.AddWithValue("@alimtar", alimtar.Value.ToShortDateString());
            komut.Parameters.AddWithValue("@satisfiyat", txtsatisfiyat.Text);
            komut.Parameters.AddWithValue("@kdv", txtkdv.Text);

            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Başarıyla Güncellendi");
            this.evsatisTableAdapter.Fill(this.emlakVeriTabaniDataSet.evsatis);
        }

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

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            label9.Visible = false;
            button6.Visible = false;
            checkBox1.Visible = true;
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * from evsatis where satisno=@satisno", baglan);
            komut.Parameters.AddWithValue("@satisno", textBox2.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Satış Bulundu", "Satış Bilgisi");
                txtkayitno.Text = dr["kayitno"].ToString();
                txtsatisiyapan.Text = dr["satisiyapan"].ToString();
                txtalankisi.Text = dr["alankisi"].ToString();
                txtsatisfiyat.Text = dr["satisfiyat"].ToString();
                txtkdv.Text = dr["kdv"].ToString();
            }
            else
                MessageBox.Show("Satış Bulunamadı", "Satış Bilgisi");
            baglan.Close();

        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
