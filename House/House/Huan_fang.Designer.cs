﻿namespace House
{
    partial class Huan_fang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Huan_fang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dingdan1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseDataSet10 = new House.houseDataSet10();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.xinxi1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.houseDataSet9 = new House.houseDataSet9();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xin_xi1TableAdapter = new House.houseDataSet9TableAdapters.Xin_xi1TableAdapter();
            this.ding_dan1TableAdapter = new House.houseDataSet10TableAdapters.Ding_dan1TableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dingdan1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xinxi1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户身份证号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "想 换 房 号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "想 换 日 期";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dingdan1BindingSource;
            this.comboBox1.DisplayMember = "Number";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(746, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 20);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Number";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dingdan1BindingSource
            // 
            this.dingdan1BindingSource.DataMember = "Ding_dan1";
            this.dingdan1BindingSource.DataSource = this.houseDataSet10;
            // 
            // houseDataSet10
            // 
            this.houseDataSet10.DataSetName = "houseDataSet10";
            this.houseDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.xinxi1BindingSource2;
            this.comboBox2.DisplayMember = "Kefanghao";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(747, 194);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(305, 20);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "Kefanghao";
            // 
            // xinxi1BindingSource2
            // 
            this.xinxi1BindingSource2.DataMember = "Xin_xi1";
            this.xinxi1BindingSource2.DataSource = this.houseDataSet9;
            // 
            // houseDataSet9
            // 
            this.houseDataSet9.DataSetName = "houseDataSet9";
            this.houseDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(928, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(747, 283);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(306, 21);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.xinxi1BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(54, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(445, 274);
            this.dataGridView1.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Kefanghao";
            this.dataGridViewTextBoxColumn1.HeaderText = "客房号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Biaozhun";
            this.dataGridViewTextBoxColumn2.HeaderText = "客房标准";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Zhuangtai";
            this.dataGridViewTextBoxColumn3.HeaderText = "客房状态";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Danjia";
            this.dataGridViewTextBoxColumn4.HeaderText = "单价（元/天）";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // xin_xi1TableAdapter
            // 
            this.xin_xi1TableAdapter.ClearBeforeFill = true;
            // 
            // ding_dan1TableAdapter
            // 
            this.ding_dan1TableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1086, 505);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Huan_fang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Huan_fang";
            this.Text = "换房界面";
            this.Load += new System.EventHandler(this.Huan_fang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dingdan1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xinxi1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
      
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
      
       
        private System.Windows.Forms.DataGridView dataGridView1;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn kefanghaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biaozhunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhuangtaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danjiaDataGridViewTextBoxColumn;
        private houseDataSet9 houseDataSet9;
        private System.Windows.Forms.BindingSource xinxi1BindingSource2;
        private houseDataSet9TableAdapters.Xin_xi1TableAdapter xin_xi1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private houseDataSet10 houseDataSet10;
        private System.Windows.Forms.BindingSource dingdan1BindingSource;
        private houseDataSet10TableAdapters.Ding_dan1TableAdapter ding_dan1TableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}