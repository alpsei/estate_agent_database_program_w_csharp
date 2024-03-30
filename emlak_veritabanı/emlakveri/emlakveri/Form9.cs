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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.arsasatis' table. You can move, or remove it, as needed.
            this.arsasatisTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsasatis);

        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\EmlakVeriTabani.accdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "select * from arsasatis where alimtar=@alimtar";
            komut.Parameters.AddWithValue("@alimtar", dateTimePicker1.Value.ToShortDateString());
            adtr = new OleDbDataAdapter(komut);
            ds = new DataSet();
            adtr.Fill(ds, "arsasatis");
            dataGridView1.DataSource = ds.Tables["arsasatis"];
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Tamamlandı");
            baglan.Close();
            this.arsasatisTableAdapter.Fill(this.emlakVeriTabaniDataSet.arsasatis);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = " Select sum(satisfiyat) from arsasatis where alimtar=@alimtar";
            komut.Parameters.AddWithValue("@alimtar", dateTimePicker1.Value.ToShortDateString());
            textBox2.Text = komut.ExecuteScalar().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
