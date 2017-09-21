namespace House
{
    partial class Ke_Xinxi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ke_Xinxi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kefanghaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biaozhunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhuangtaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danjiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xinxi1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseDataSet17 = new House.houseDataSet17();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.xin_xi1TableAdapter = new House.houseDataSet17TableAdapters.Xin_xi1TableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xinxi1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kefanghaoDataGridViewTextBoxColumn,
            this.biaozhunDataGridViewTextBoxColumn,
            this.zhuangtaiDataGridViewTextBoxColumn,
            this.danjiaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.xinxi1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(74, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(441, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // kefanghaoDataGridViewTextBoxColumn
            // 
            this.kefanghaoDataGridViewTextBoxColumn.DataPropertyName = "Kefanghao";
            this.kefanghaoDataGridViewTextBoxColumn.HeaderText = "客房号";
            this.kefanghaoDataGridViewTextBoxColumn.Name = "kefanghaoDataGridViewTextBoxColumn";
            // 
            // biaozhunDataGridViewTextBoxColumn
            // 
            this.biaozhunDataGridViewTextBoxColumn.DataPropertyName = "Biaozhun";
            this.biaozhunDataGridViewTextBoxColumn.HeaderText = "客房标准";
            this.biaozhunDataGridViewTextBoxColumn.Name = "biaozhunDataGridViewTextBoxColumn";
            // 
            // zhuangtaiDataGridViewTextBoxColumn
            // 
            this.zhuangtaiDataGridViewTextBoxColumn.DataPropertyName = "Zhuangtai";
            this.zhuangtaiDataGridViewTextBoxColumn.HeaderText = "客房状态";
            this.zhuangtaiDataGridViewTextBoxColumn.Name = "zhuangtaiDataGridViewTextBoxColumn";
            // 
            // danjiaDataGridViewTextBoxColumn
            // 
            this.danjiaDataGridViewTextBoxColumn.DataPropertyName = "Danjia";
            this.danjiaDataGridViewTextBoxColumn.HeaderText = "单价（元/天）";
            this.danjiaDataGridViewTextBoxColumn.Name = "danjiaDataGridViewTextBoxColumn";
            // 
            // xinxi1BindingSource
            // 
            this.xinxi1BindingSource.DataMember = "Xin_xi1";
            this.xinxi1BindingSource.DataSource = this.houseDataSet17;
            // 
            // houseDataSet17
            // 
            this.houseDataSet17.DataSetName = "houseDataSet17";
            this.houseDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "身份证号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "身份证地址";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(853, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(763, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 21);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(763, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 21);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(763, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 21);
            this.textBox3.TabIndex = 8;
            // 
            // xin_xi1TableAdapter
            // 
            this.xin_xi1TableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1087, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Ke_Xinxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 437);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ke_Xinxi";
            this.Text = "客房信息页面";
            this.Load += new System.EventHandler(this.Ke_Xinxi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xinxi1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
       // private System.Windows.Forms.DataGridViewTextBoxColumn kefanghaoDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn biaozhunDataGridViewTextBoxColumn;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn zhuangtaiDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn danjiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private houseDataSet17 houseDataSet17;
        private System.Windows.Forms.BindingSource xinxi1BindingSource;
        private houseDataSet17TableAdapters.Xin_xi1TableAdapter xin_xi1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kefanghaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biaozhunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhuangtaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danjiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}