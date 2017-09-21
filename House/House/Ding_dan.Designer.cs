namespace House
{
    partial class Ding_dan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ding_dan));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kefanghaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dingdan1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseDataSet7 = new House.houseDataSet7();
            this.button1 = new System.Windows.Forms.Button();
            this.ding_dan1TableAdapter = new House.houseDataSet7TableAdapters.Ding_dan1TableAdapter();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dingdan1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.kefanghaoDataGridViewTextBoxColumn,
            this.time1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dingdan1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(116, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(342, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "身份证号";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // kefanghaoDataGridViewTextBoxColumn
            // 
            this.kefanghaoDataGridViewTextBoxColumn.DataPropertyName = "Kefanghao";
            this.kefanghaoDataGridViewTextBoxColumn.HeaderText = "客房号";
            this.kefanghaoDataGridViewTextBoxColumn.Name = "kefanghaoDataGridViewTextBoxColumn";
            // 
            // time1DataGridViewTextBoxColumn
            // 
            this.time1DataGridViewTextBoxColumn.DataPropertyName = "Time1";
            this.time1DataGridViewTextBoxColumn.HeaderText = "订房时间";
            this.time1DataGridViewTextBoxColumn.Name = "time1DataGridViewTextBoxColumn";
            // 
            // dingdan1BindingSource
            // 
            this.dingdan1BindingSource.DataMember = "Ding_dan1";
            this.dingdan1BindingSource.DataSource = this.houseDataSet7;
            // 
            // houseDataSet7
            // 
            this.houseDataSet7.DataSetName = "houseDataSet7";
            this.houseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ding_dan1TableAdapter
            // 
            this.ding_dan1TableAdapter.ClearBeforeFill = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(722, 82);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1089, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Ding_dan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 435);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ding_dan";
            this.Text = "订单页面";
            this.Load += new System.EventHandler(this.Ding_dan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dingdan1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
     
       // private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
  
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private houseDataSet7 houseDataSet7;
        private System.Windows.Forms.BindingSource dingdan1BindingSource;
        private houseDataSet7TableAdapters.Ding_dan1TableAdapter ding_dan1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kefanghaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn time1DataGridViewTextBoxColumn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}