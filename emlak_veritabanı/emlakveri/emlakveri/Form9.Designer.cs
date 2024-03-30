namespace emlakveri
{
    partial class Form9
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.arsasatisTableAdapter = new emlakveri.EmlakVeriTabaniDataSetTableAdapters.arsasatisTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsasatisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakVeriTabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(957, 436);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Kazanç Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(957, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Satışları Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(582, 439);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 22);
            this.textBox2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(582, 362);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 443);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Toplam Kazanç";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tarih";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
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
            this.dataGridView1.Location = new System.Drawing.Point(198, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1114, 203);
            this.dataGridView1.TabIndex = 9;
            // 
            // satisnoDataGridViewTextBoxColumn
            // 
            this.satisnoDataGridViewTextBoxColumn.DataPropertyName = "satisno";
            this.satisnoDataGridViewTextBoxColumn.HeaderText = "satisno";
            this.satisnoDataGridViewTextBoxColumn.Name = "satisnoDataGridViewTextBoxColumn";
            // 
            // akayitnoDataGridViewTextBoxColumn
            // 
            this.akayitnoDataGridViewTextBoxColumn.DataPropertyName = "akayitno";
            this.akayitnoDataGridViewTextBoxColumn.HeaderText = "akayitno";
            this.akayitnoDataGridViewTextBoxColumn.Name = "akayitnoDataGridViewTextBoxColumn";
            // 
            // satisiyapanDataGridViewTextBoxColumn
            // 
            this.satisiyapanDataGridViewTextBoxColumn.DataPropertyName = "satisiyapan";
            this.satisiyapanDataGridViewTextBoxColumn.HeaderText = "satisiyapan";
            this.satisiyapanDataGridViewTextBoxColumn.Name = "satisiyapanDataGridViewTextBoxColumn";
            // 
            // alankisiDataGridViewTextBoxColumn
            // 
            this.alankisiDataGridViewTextBoxColumn.DataPropertyName = "alankisi";
            this.alankisiDataGridViewTextBoxColumn.HeaderText = "alankisi";
            this.alankisiDataGridViewTextBoxColumn.Name = "alankisiDataGridViewTextBoxColumn";
            // 
            // alimtarDataGridViewTextBoxColumn
            // 
            this.alimtarDataGridViewTextBoxColumn.DataPropertyName = "alimtar";
            this.alimtarDataGridViewTextBoxColumn.HeaderText = "alimtar";
            this.alimtarDataGridViewTextBoxColumn.Name = "alimtarDataGridViewTextBoxColumn";
            // 
            // satisfiyatDataGridViewTextBoxColumn
            // 
            this.satisfiyatDataGridViewTextBoxColumn.DataPropertyName = "satisfiyat";
            this.satisfiyatDataGridViewTextBoxColumn.HeaderText = "satisfiyat";
            this.satisfiyatDataGridViewTextBoxColumn.Name = "satisfiyatDataGridViewTextBoxColumn";
            // 
            // kdvDataGridViewTextBoxColumn
            // 
            this.kdvDataGridViewTextBoxColumn.DataPropertyName = "kdv";
            this.kdvDataGridViewTextBoxColumn.HeaderText = "kdv";
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
            // arsasatisTableAdapter
            // 
            this.arsasatisTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1181, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = "Ana Menüye Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1364, 549);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arsasatisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakVeriTabaniDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmlakVeriTabaniDataSet emlakVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource arsasatisBindingSource;
        private EmlakVeriTabaniDataSetTableAdapters.arsasatisTableAdapter arsasatisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn akayitnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisiyapanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alankisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimtarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}