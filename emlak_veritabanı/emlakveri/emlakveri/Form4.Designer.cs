namespace emlakveri
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsatisiyapan = new System.Windows.Forms.TextBox();
            this.txtalankisi = new System.Windows.Forms.TextBox();
            this.txtsatisfiyat = new System.Windows.Forms.TextBox();
            this.txtkdv = new System.Windows.Forms.TextBox();
            this.alimtar = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.satisnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisiyapanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alankisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimtarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evsatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emlakVeriTabaniDataSet = new emlakveri.EmlakVeriTabaniDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtkayitno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.evsatisTableAdapter = new emlakveri.EmlakVeriTabaniDataSetTableAdapters.evsatisTableAdapter();
            this.tableAdapterManager = new emlakveri.EmlakVeriTabaniDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evsatisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satışı Yapan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 390);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alan Kişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Satış Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 336);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Satış Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 390);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "KDV";
            // 
            // txtsatisiyapan
            // 
            this.txtsatisiyapan.Location = new System.Drawing.Point(176, 386);
            this.txtsatisiyapan.Margin = new System.Windows.Forms.Padding(4);
            this.txtsatisiyapan.Name = "txtsatisiyapan";
            this.txtsatisiyapan.Size = new System.Drawing.Size(148, 22);
            this.txtsatisiyapan.TabIndex = 6;
            // 
            // txtalankisi
            // 
            this.txtalankisi.Location = new System.Drawing.Point(414, 386);
            this.txtalankisi.Margin = new System.Windows.Forms.Padding(4);
            this.txtalankisi.Name = "txtalankisi";
            this.txtalankisi.Size = new System.Drawing.Size(148, 22);
            this.txtalankisi.TabIndex = 7;
            // 
            // txtsatisfiyat
            // 
            this.txtsatisfiyat.Enabled = false;
            this.txtsatisfiyat.Location = new System.Drawing.Point(735, 332);
            this.txtsatisfiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtsatisfiyat.Name = "txtsatisfiyat";
            this.txtsatisfiyat.Size = new System.Drawing.Size(148, 22);
            this.txtsatisfiyat.TabIndex = 8;
            // 
            // txtkdv
            // 
            this.txtkdv.Location = new System.Drawing.Point(717, 386);
            this.txtkdv.Margin = new System.Windows.Forms.Padding(4);
            this.txtkdv.Name = "txtkdv";
            this.txtkdv.Size = new System.Drawing.Size(148, 22);
            this.txtkdv.TabIndex = 9;
            // 
            // alimtar
            // 
            this.alimtar.Location = new System.Drawing.Point(433, 306);
            this.alimtar.Margin = new System.Windows.Forms.Padding(4);
            this.alimtar.Name = "alimtar";
            this.alimtar.Size = new System.Drawing.Size(146, 22);
            this.alimtar.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satisnoDataGridViewTextBoxColumn,
            this.kayitnoDataGridViewTextBoxColumn,
            this.satisiyapanDataGridViewTextBoxColumn,
            this.alankisiDataGridViewTextBoxColumn,
            this.alimtarDataGridViewTextBoxColumn,
            this.satisfiyatDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.evsatisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(105, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 185);
            this.dataGridView1.TabIndex = 12;
            // 
            // satisnoDataGridViewTextBoxColumn
            // 
            this.satisnoDataGridViewTextBoxColumn.DataPropertyName = "satisno";
            this.satisnoDataGridViewTextBoxColumn.HeaderText = "Satış No";
            this.satisnoDataGridViewTextBoxColumn.Name = "satisnoDataGridViewTextBoxColumn";
            // 
            // kayitnoDataGridViewTextBoxColumn
            // 
            this.kayitnoDataGridViewTextBoxColumn.DataPropertyName = "kayitno";
            this.kayitnoDataGridViewTextBoxColumn.HeaderText = "Kayıt No";
            this.kayitnoDataGridViewTextBoxColumn.Name = "kayitnoDataGridViewTextBoxColumn";
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
            // evsatisBindingSource
            // 
            this.evsatisBindingSource.DataMember = "evsatis";
            this.evsatisBindingSource.DataSource = this.emlakVeriTabaniDataSet;
            // 
            // emlakVeriTabaniDataSet
            // 
            this.emlakVeriTabaniDataSet.DataSetName = "EmlakVeriTabaniDataSet";
            this.emlakVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Satış Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 452);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Satış Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(696, 452);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "Satış Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(302, 587);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(360, 185);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kayıt No";
            // 
            // txtkayitno
            // 
            this.txtkayitno.Enabled = false;
            this.txtkayitno.Location = new System.Drawing.Point(176, 308);
            this.txtkayitno.Margin = new System.Windows.Forms.Padding(4);
            this.txtkayitno.Name = "txtkayitno";
            this.txtkayitno.Size = new System.Drawing.Size(148, 22);
            this.txtkayitno.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 28);
            this.label8.TabIndex = 28;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(979, 476);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 28);
            this.button5.TabIndex = 22;
            this.button5.Text = "Ana Menüye Dön";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(658, 273);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(146, 20);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Satış Bilgisi Getir";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(765, 270);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 22);
            this.textBox2.TabIndex = 25;
            this.textBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(670, 274);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Satış No";
            this.label9.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(938, 266);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 28);
            this.button6.TabIndex = 27;
            this.button6.Text = "Kayıt Getir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(981, 332);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 22);
            this.textBox3.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(896, 336);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Son Fiyat";
            // 
            // evsatisTableAdapter
            // 
            this.evsatisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.arsasatisTableAdapter = null;
            this.tableAdapterManager.arsaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.evsatisTableAdapter = this.evsatisTableAdapter;
            this.tableAdapterManager.evTableAdapter = null;
            this.tableAdapterManager.kullanicigirisTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = emlakveri.EmlakVeriTabaniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1140, 544);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtkayitno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evsatisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsatisiyapan;
        private System.Windows.Forms.TextBox txtalankisi;
        private System.Windows.Forms.TextBox txtsatisfiyat;
        private System.Windows.Forms.TextBox txtkdv;
        private System.Windows.Forms.DateTimePicker alimtar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtkayitno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private EmlakVeriTabaniDataSet emlakVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource evsatisBindingSource;
        private EmlakVeriTabaniDataSetTableAdapters.evsatisTableAdapter evsatisTableAdapter;
        private EmlakVeriTabaniDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisiyapanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alankisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimtarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
    }
}