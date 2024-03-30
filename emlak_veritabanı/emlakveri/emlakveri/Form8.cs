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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\EmlakVeriTabani.accdb");
        OleDbCommand komut=new OleDbCommand();
        DataSet ds = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakVeriTabaniDataSet.evsatis' table. You can move, or remove it, as needed.
            this.evsatisTableAdapter.Fill(this.emlakVeriTabaniDataSet.evsatis);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "select * from evsatis where alimtar=@alimtar";
            komut.Parameters.AddWithValue("@alimtar", dateTimePicker1.Value.ToShortDateString());
            adtr = new OleDbDataAdapter(komut);
            ds = new DataSet();
            adtr.Fill(ds, "evsatis");
            dataGridView1.DataSource = ds.Tables["evsatis"];
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Tamamlandı");
            baglan.Close();
            this.evsatisTableAdapter.Fill(this.emlakVeriTabaniDataSet.evsatis);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = " Select sum(satisfiyat) from evsatis where alimtar=@alimtar";
            komut.Parameters.AddWithValue("@alimtar", dateTimePicker1.Value.ToShortDateString());
            textBox2.Text = komut.ExecuteScalar().ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
