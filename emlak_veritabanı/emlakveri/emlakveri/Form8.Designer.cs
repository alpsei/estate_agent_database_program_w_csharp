namespace emlakveri
{
    partial class Form8
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
            this.evsatisTableAdapter = new emlakveri.EmlakVeriTabaniDataSetTableAdapters.evsatisTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evsatisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakVeriTabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
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
            this.dataGridView1.Location = new System.Drawing.Point(102, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 165);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.satisfiyatDataGridViewTextBoxColumn.HeaderText = "Satışı Fiyatı";
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
            // evsatisTableAdapter
            // 
            this.evsatisTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Toplam Kazanç";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(358, 245);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(358, 308);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Satışları Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 305);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Kazanç Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(818, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 31);
            this.button3.TabIndex = 9;
            this.button3.Text = "Ana Menüye Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1006, 446);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evsatisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakVeriTabaniDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EmlakVeriTabaniDataSet emlakVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource evsatisBindingSource;
        private EmlakVeriTabaniDataSetTableAdapters.evsatisTableAdapter evsatisTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisiyapanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alankisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimtarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}