namespace emlakveri
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtresim = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbarsatip = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.akayitnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parselnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imardurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arsaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emlakVeriTabaniDataSet = new emlakveri.EmlakVeriTabaniDataSet();
            this.txtparselno = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.rtxtadres = new System.Windows.Forms.RichTextBox();
            this.txtadano = new System.Windows.Forms.TextBox();
            this.txtm2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arsaTableAdapter = new emlakveri.EmlakVeriTabaniDataSetTableAdapters.arsaTableAdapter();
            this.tableAdapterManager = new emlakveri.EmlakVeriTabaniDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1143, 569);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 28);
            this.button5.TabIndex = 89;
            this.button5.Text = "Ana Menüye Dön";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1084, 480);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 28);
            this.button4.TabIndex = 88;
            this.button4.Text = "Resim Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1089, 375);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 87;
            this.label14.Text = "Resim Yolu";
            // 
            // txtresim
            // 
            this.txtresim.Enabled = false;
            this.txtresim.Location = new System.Drawing.Point(1088, 399);
            this.txtresim.Margin = new System.Windows.Forms.Padding(4);
            this.txtresim.Name = "txtresim";
            this.txtresim.Size = new System.Drawing.Size(148, 22);
            this.txtresim.TabIndex = 86;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 522);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 85;
            this.button1.Text = "Kayıt Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "İmar Durumu";
            // 
            // cmbarsatip
            // 
            this.cmbarsatip.FormattingEnabled = true;
            this.cmbarsatip.Items.AddRange(new object[] {
            "Ada",
            "A-Lejantlı",
            "Arazi",
            "Bağ & Bahçe",
            "Depo & Antrepo",
            "Eğitim",
            "Enerji Depolama",
            "Konut",
            "Muhtelif",
            "Özel Kullanım",
            "Sağlık",
            "Sanayi",
            "Sera",
            "Sit Alanı",
            "Spor Alanı",
            "Tarla",
            "Ticari",
            "Ticari Konut",
            "Toplu Konut",
            "Turizm",
            "Villa",
            "Zeytinlik"});
            this.cmbarsatip.Location = new System.Drawing.Point(280, 267);
            this.cmbarsatip.Margin = new System.Windows.Forms.Padding(4);
            this.cmbarsatip.Name = "cmbarsatip";
            this.cmbarsatip.Size = new System.Drawing.Size(133, 24);
            this.cmbarsatip.TabIndex = 97;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tomato;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.akayitnoDataGridViewTextBoxColumn,
            this.adanoDataGridViewTextBoxColumn,
            this.parselnoDataGridViewTextBoxColumn,
            this.m2DataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.imardurumuDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.arsaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(289, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 185);
            this.dataGridView1.TabIndex = 84;
            // 
            // akayitnoDataGridViewTextBoxColumn
            // 
            this.akayitnoDataGridViewTextBoxColumn.DataPropertyName = "akayitno";
            this.akayitnoDataGridViewTextBoxColumn.HeaderText = "Arsa Kayıt No";
            this.akayitnoDataGridViewTextBoxColumn.Name = "akayitnoDataGridViewTextBoxColumn";
            // 
            // adanoDataGridViewTextBoxColumn
            // 
            this.adanoDataGridViewTextBoxColumn.DataPropertyName = "adano";
            this.adanoDataGridViewTextBoxColumn.HeaderText = "Ada No";
            this.adanoDataGridViewTextBoxColumn.Name = "adanoDataGridViewTextBoxColumn";
            // 
            // parselnoDataGridViewTextBoxColumn
            // 
            this.parselnoDataGridViewTextBoxColumn.DataPropertyName = "parselno";
            this.parselnoDataGridViewTextBoxColumn.HeaderText = "Parsel No";
            this.parselnoDataGridViewTextBoxColumn.Name = "parselnoDataGridViewTextBoxColumn";
            // 
            // m2DataGridViewTextBoxColumn
            // 
            this.m2DataGridViewTextBoxColumn.DataPropertyName = "m2";
            this.m2DataGridViewTextBoxColumn.HeaderText = "m2";
            this.m2DataGridViewTextBoxColumn.Name = "m2DataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // imardurumuDataGridViewTextBoxColumn
            // 
            this.imardurumuDataGridViewTextBoxColumn.DataPropertyName = "imardurumu";
            this.imardurumuDataGridViewTextBoxColumn.HeaderText = "İmar Durumu";
            this.imardurumuDataGridViewTextBoxColumn.Name = "imardurumuDataGridViewTextBoxColumn";
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "Resim";
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            // 
            // arsaBindingSource
            // 
            this.arsaBindingSource.DataMember = "arsa";
            this.arsaBindingSource.DataSource = this.emlakVeriTabaniDataSet;
            // 
            // emlakVeriTabaniDataSet
            // 
            this.emlakVeriTabaniDataSet.DataSetName = "EmlakVeriTabaniDataSet";
            this.emlakVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtparselno
            // 
            this.txtparselno.Location = new System.Drawing.Point(285, 465);
            this.txtparselno.Margin = new System.Windows.Forms.Padding(4);
            this.txtparselno.Name = "txtparselno";
            this.txtparselno.Size = new System.Drawing.Size(128, 22);
            this.txtparselno.TabIndex = 83;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(812, 327);
            this.txtfiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(130, 22);
            this.txtfiyat.TabIndex = 81;
            // 
            // rtxtadres
            // 
            this.rtxtadres.Location = new System.Drawing.Point(810, 267);
            this.rtxtadres.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtadres.Name = "rtxtadres";
            this.rtxtadres.Size = new System.Drawing.Size(132, 24);
            this.rtxtadres.TabIndex = 80;
            this.rtxtadres.Text = "";
            // 
            // txtadano
            // 
            this.txtadano.Location = new System.Drawing.Point(280, 395);
            this.txtadano.Margin = new System.Windows.Forms.Padding(4);
            this.txtadano.Name = "txtadano";
            this.txtadano.Size = new System.Drawing.Size(130, 22);
            this.txtadano.TabIndex = 74;
            // 
            // txtm2
            // 
            this.txtm2.Location = new System.Drawing.Point(282, 325);
            this.txtm2.Margin = new System.Windows.Forms.Padding(4);
            this.txtm2.Name = "txtm2";
            this.txtm2.Size = new System.Drawing.Size(132, 22);
            this.txtm2.TabIndex = 73;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(748, 375);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 70;
            this.label12.Text = "Resim";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(171, 469);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 71;
            this.label13.Text = "Parsel No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(752, 331);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 69;
            this.label11.Text = "Fiyat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(750, 271);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 68;
            this.label10.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 399);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "Ada No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "m2";
            // 
            // arsaTableAdapter
            // 
            this.arsaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.arsasatisTableAdapter = null;
            this.tableAdapterManager.arsaTableAdapter = this.arsaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.evsatisTableAdapter = null;
            this.tableAdapterManager.evTableAdapter = null;
            this.tableAdapterManager.kullanicigirisTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = emlakveri.EmlakVeriTabaniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(812, 375);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 132);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(946, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 98;
            this.button2.Text = "Gönder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(840, 526);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 99;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(768, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 100;
            this.label3.Text = "Kayıt No";
            this.label3.Visible = false;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(867, 575);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 101;
            this.button3.Text = "Satışa Git";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1312, 610);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtresim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbarsatip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtparselno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.rtxtadres);
            this.Controls.Add(this.txtadano);
            this.Controls.Add(this.txtm2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtresim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbarsatip;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtparselno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.RichTextBox rtxtadres;
        private System.Windows.Forms.TextBox txtadano;
        private System.Windows.Forms.TextBox txtm2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private EmlakVeriTabaniDataSet emlakVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource arsaBindingSource;
        private EmlakVeriTabaniDataSetTableAdapters.arsaTableAdapter arsaTableAdapter;
        private EmlakVeriTabaniDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn akayitnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parselnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imardurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}