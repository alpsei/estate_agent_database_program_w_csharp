namespace emlakveri
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.satisnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akayitnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisiyapanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alankisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimtarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arsasatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emlakVeriTabaniDataSet = new emlakveri.EmlakVeriTabaniDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.akayitnoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parselnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imardurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arsaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.arsasatisTableAdapter = new emlakveri.EmlakVeriTabaniDataSetTableAdapters.arsasatisTableAdapter();
            this.tableAdapterManager = new emlakveri.EmlakVeriTabaniDataSetTableAdapters.TableAdapterManager();
            this.arsaTableAdapter = new emlakveri.EmlakVeriTabaniDataSetTableAdapters.arsaTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtkayitno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.alimtar = new System.Windows.Forms.DateTimePicker();
            this.txtkdv = new System.Windows.Forms.TextBox();
            this.txtsatisfiyat = new System.Windows.Forms.TextBox();
            this.txtalankisi = new System.Windows.Forms.TextBox();
            this.txtsatisiyapan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsasatisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(966, 460);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 28);
            this.button5.TabIndex = 49;
            this.button5.Text = "Ana Menüye Dön";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satisnoDataGridViewTextBoxColumn,
            this.akayitnoDataGridViewTextBoxColumn,
            this.satisiyapanDataGridViewTextBoxColumn,
            this.alankisiDataGridViewTextBoxColumn,
            this.alimtarDataGridViewTextBoxColumn,
            this.satisfiyatDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.arsasatisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(146, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 185);
            this.dataGridView1.TabIndex = 39;
            // 
            // satisnoDataGridViewTextBoxColumn
            // 
            this.satisnoDataGridViewTextBoxColumn.DataPropertyName = "satisno";
            this.satisnoDataGridViewTextBoxColumn.HeaderText = "Satış No";
            this.satisnoDataGridViewTextBoxColumn.Name = "satisnoDataGridViewTextBoxColumn";
            // 
            // akayitnoDataGridViewTextBoxColumn
            // 
            this.akayitnoDataGridViewTextBoxColumn.DataPropertyName = "akayitno";
            this.akayitnoDataGridViewTextBoxColumn.HeaderText = "Arsa Kayıt No";
            this.akayitnoDataGridViewTextBoxColumn.Name = "akayitnoDataGridViewTextBoxColumn";
            // 
            // satisiyapanDataGridViewTextBoxColumn
            // 
            this.satisiyapanDataGridViewTextBoxColumn.DataPropertyName = "satisiyapan";
            this.satisiyapanDataGridViewTextBoxColumn.HeaderText = "Satışı Yapan";
            this.satisiyapanDataGridViewTextBoxColumn.Name = "satisiyapanDataGridViewTextBoxColumn";
            // 
            // alankisiDataGridViewTextBoxColumn
            // 
            this.alankisiDataGridViewTextBoxColumn.DataPropertyName = "alankisi";
            this.alankisiDataGridViewTextBoxColumn.HeaderText = "Alan Kişi";
            this.alankisiDataGridViewTextBoxColumn.Name = "alankisiDataGridViewTextBoxColumn";
            // 
            // alimtarDataGridViewTextBoxColumn
            // 
            this.alimtarDataGridViewTextBoxColumn.DataPropertyName = "alimtar";
            this.alimtarDataGridViewTextBoxColumn.HeaderText = "Alım Tarihi";
            this.alimtarDataGridViewTextBoxColumn.Name = "alimtarDataGridViewTextBoxColumn";
            // 
            // satisfiyatDataGridViewTextBoxColumn
            // 
            this.satisfiyatDataGridViewTextBoxColumn.DataPropertyName = "satisfiyat";
            this.satisfiyatDataGridViewTextBoxColumn.HeaderText = "Satış Fiyatı";
            this.satisfiyatDataGridViewTextBoxColumn.Name = "satisfiyatDataGridViewTextBoxColumn";
            // 
            // kdvDataGridViewTextBoxColumn
            // 
            this.kdvDataGridViewTextBoxColumn.DataPropertyName = "kdv";
            this.kdvDataGridViewTextBoxColumn.HeaderText = "KDV";
            this.kdvDataGridViewTextBoxColumn.Name = "kdvDataGridViewTextBoxColumn";
            // 
            // arsasatisBindingSource
            // 
            this.arsasatisBindingSource.DataMember = "arsasatis";
            this.arsasatisBindingSource.DataSource = this.emlakVeriTabaniDataSet;
            // 
            // emlakVeriTabaniDataSet
            // 
            this.emlakVeriTabaniDataSet.DataSetName = "EmlakVeriTabaniDataSet";
            this.emlakVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.akayitnoDataGridViewTextBoxColumn1,
            this.adanoDataGridViewTextBoxColumn,
            this.parselnoDataGridViewTextBoxColumn,
            this.m2DataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.imardurumuDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.arsaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(294, 566);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(360, 185);
            this.dataGridView2.TabIndex = 43;
            this.dataGridView2.Visible = false;
            // 
            // akayitnoDataGridViewTextBoxColumn1
            // 
            this.akayitnoDataGridViewTextBoxColumn1.DataPropertyName = "akayitno";
            this.akayitnoDataGridViewTextBoxColumn1.HeaderText = "akayitno";
            this.akayitnoDataGridViewTextBoxColumn1.Name = "akayitnoDataGridViewTextBoxColumn1";
            // 
            // adanoDataGridViewTextBoxColumn
            // 
            this.adanoDataGridViewTextBoxColumn.DataPropertyName = "adano";
            this.adanoDataGridViewTextBoxColumn.HeaderText = "adano";
            this.adanoDataGridViewTextBoxColumn.Name = "adanoDataGridViewTextBoxColumn";
            // 
            // parselnoDataGridViewTextBoxColumn
            // 
            this.parselnoDataGridViewTextBoxColumn.DataPropertyName = "parselno";
            this.parselnoDataGridViewTextBoxColumn.HeaderText = "parselno";
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
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // imardurumuDataGridViewTextBoxColumn
            // 
            this.imardurumuDataGridViewTextBoxColumn.DataPropertyName = "imardurumu";
            this.imardurumuDataGridViewTextBoxColumn.HeaderText = "imardurumu";
            this.imardurumuDataGridViewTextBoxColumn.Name = "imardurumuDataGridViewTextBoxColumn";
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "resim";
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            // 
            // arsaBindingSource
            // 
            this.arsaBindingSource.DataMember = "arsa";
            this.arsaBindingSource.DataSource = this.emlakVeriTabaniDataSet;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(688, 431);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 28);
            this.button3.TabIndex = 42;
            this.button3.Text = "Satış Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(489, 431);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 28);
            this.button2.TabIndex = 41;
            this.button2.Text = "Satış Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 40;
            this.button1.Text = "Satış Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // arsasatisTableAdapter
            // 
            this.arsasatisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.arsasatisTableAdapter = this.arsasatisTableAdapter;
            this.tableAdapterManager.arsaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.evsatisTableAdapter = null;
            this.tableAdapterManager.evTableAdapter = null;
            this.tableAdapterManager.kullanicigirisTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = emlakveri.EmlakVeriTabaniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // arsaTableAdapter
            // 
            this.arsaTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(876, 341);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 70;
            this.label10.Text = "Son Fiyat";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(961, 337);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 22);
            this.textBox3.TabIndex = 69;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(918, 271);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 28);
            this.button6.TabIndex = 67;
            this.button6.Text = "Kayıt Getir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(650, 279);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 66;
            this.label9.Text = "Satış No";
            this.label9.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(745, 275);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 22);
            this.textBox2.TabIndex = 65;
            this.textBox2.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(638, 278);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(146, 20);
            this.checkBox1.TabIndex = 64;
            this.checkBox1.Text = "Satış Bilgisi Getir";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtkayitno
            // 
            this.txtkayitno.Enabled = false;
            this.txtkayitno.Location = new System.Drawing.Point(156, 293);
            this.txtkayitno.Margin = new System.Windows.Forms.Padding(4);
            this.txtkayitno.Name = "txtkayitno";
            this.txtkayitno.Size = new System.Drawing.Size(148, 22);
            this.txtkayitno.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 298);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "Kayıt No";
            // 
            // alimtar
            // 
            this.alimtar.Location = new System.Drawing.Point(409, 292);
            this.alimtar.Margin = new System.Windows.Forms.Padding(4);
            this.alimtar.Name = "alimtar";
            this.alimtar.Size = new System.Drawing.Size(146, 22);
            this.alimtar.TabIndex = 59;
            // 
            // txtkdv
            // 
            this.txtkdv.Location = new System.Drawing.Point(697, 391);
            this.txtkdv.Margin = new System.Windows.Forms.Padding(4);
            this.txtkdv.Name = "txtkdv";
            this.txtkdv.Size = new System.Drawing.Size(148, 22);
            this.txtkdv.TabIndex = 58;
            // 
            // txtsatisfiyat
            // 
            this.txtsatisfiyat.Enabled = false;
            this.txtsatisfiyat.Location = new System.Drawing.Point(715, 337);
            this.txtsatisfiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtsatisfiyat.Name = "txtsatisfiyat";
            this.txtsatisfiyat.Size = new System.Drawing.Size(148, 22);
            this.txtsatisfiyat.TabIndex = 57;
            // 
            // txtalankisi
            // 
            this.txtalankisi.Location = new System.Drawing.Point(407, 354);
            this.txtalankisi.Margin = new System.Windows.Forms.Padding(4);
            this.txtalankisi.Name = "txtalankisi";
            this.txtalankisi.Size = new System.Drawing.Size(148, 22);
            this.txtalankisi.TabIndex = 56;
            // 
            // txtsatisiyapan
            // 
            this.txtsatisiyapan.Location = new System.Drawing.Point(169, 354);
            this.txtsatisiyapan.Margin = new System.Windows.Forms.Padding(4);
            this.txtsatisiyapan.Name = "txtsatisiyapan";
            this.txtsatisiyapan.Size = new System.Drawing.Size(148, 22);
            this.txtsatisiyapan.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "KDV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Satış Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Satış Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Alan Kişi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Satışı Yapan";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1140, 498);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtkayitno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.alimtar);
            this.Controls.Add(this.txtkdv);
            this.Controls.Add(this.txtsatisfiyat);
            this.Controls.Add(this.txtalankisi);
            this.Controls.Add(this.txtsatisiyapan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsasatisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private EmlakVeriTabaniDataSet emlakVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource arsasatisBindingSource;
        private EmlakVeriTabaniDataSetTableAdapters.arsasatisTableAdapter arsasatisTableAdapter;
        private EmlakVeriTabaniDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource arsaBindingSource;
        private EmlakVeriTabaniDataSetTableAdapters.arsaTableAdapter arsaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn akayitnoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parselnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imardurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtkayitno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker alimtar;
        private System.Windows.Forms.TextBox txtkdv;
        private System.Windows.Forms.TextBox txtsatisfiyat;
        private System.Windows.Forms.TextBox txtalankisi;
        private System.Windows.Forms.TextBox txtsatisiyapan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akayitnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisiyapanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alankisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimtarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
    }
}