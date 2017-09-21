namespace House
{
    partial class Tui_fang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tui_fang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dingdan1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseDataSet4 = new House.houseDataSet4();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.xinxi1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseDataSet6 = new House.houseDataSet6();
            this.ding_dan1TableAdapter = new House.houseDataSet4TableAdapters.Ding_dan1TableAdapter();
            this.xin_xi1TableAdapter = new House.houseDataSet6TableAdapters.Xin_xi1TableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dingdan1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xinxi1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "要退房人的身份证号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "要退房人的房间号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dingdan1BindingSource;
            this.comboBox1.DisplayMember = "Number";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(488, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 20);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Number";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dingdan1BindingSource
            // 
            this.dingdan1BindingSource.DataMember = "Ding_dan1";
            this.dingdan1BindingSource.DataSource = this.houseDataSet4;
            // 
            // houseDataSet4
            // 
            this.houseDataSet4.DataSetName = "houseDataSet4";
            this.houseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.dingdan1BindingSource;
            this.comboBox2.DisplayMember = "Kefanghao";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(488, 198);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(259, 20);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "Kefanghao";
            // 
            // xinxi1BindingSource
            // 
            this.xinxi1BindingSource.DataMember = "Xin_xi1";
            this.xinxi1BindingSource.DataSource = this.houseDataSet6;
            // 
            // houseDataSet6
            // 
            this.houseDataSet6.DataSetName = "houseDataSet6";
            this.houseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ding_dan1TableAdapter
            // 
            this.ding_dan1TableAdapter.ClearBeforeFill = true;
            // 
            // xin_xi1TableAdapter
            // 
            this.xin_xi1TableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1103, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Tui_fang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 501);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Tui_fang";
            this.Text = "退房界面";
            this.Load += new System.EventHandler(this.Tui_fang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dingdan1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xinxi1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
      
        private houseDataSet4 houseDataSet4;
        private System.Windows.Forms.BindingSource dingdan1BindingSource;
        private houseDataSet4TableAdapters.Ding_dan1TableAdapter ding_dan1TableAdapter;
        private houseDataSet6 houseDataSet6;
        private System.Windows.Forms.BindingSource xinxi1BindingSource;
        private houseDataSet6TableAdapters.Xin_xi1TableAdapter xin_xi1TableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}