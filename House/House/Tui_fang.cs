using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace House
{
    public partial class Tui_fang : Form
    {
        public Tui_fang()
        {
            InitializeComponent();
        }

        private void Tui_fang_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“houseDataSet6.Xin_xi1”中。您可以根据需要移动或删除它。
            this.xin_xi1TableAdapter.Fill(this.houseDataSet6.Xin_xi1);
            // TODO: 这行代码将数据加载到表“houseDataSet4.Ding_dan1”中。您可以根据需要移动或删除它。
            this.ding_dan1TableAdapter.Fill(this.houseDataSet4.Ding_dan1);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
             
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string conStr1 = @"server=DESKTOP-7MDE3B1;uid=sa;pwd=1234567890;database=house";
                SqlConnection mycon1 = new SqlConnection(conStr1);
                mycon1.Open();
                string sql4 = "delete from Ding_dan1 where Number ='"+comboBox1.Text+"' And Kefanghao='"+comboBox2.Text+"'";
                SqlCommand com = new SqlCommand(sql4, mycon1);
                SqlDataReader dr = com.ExecuteReader();
                dr.Close();
                MessageBox.Show("退房成功");
                this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
              
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
           
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
             
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
                this.ding_dan1TableAdapter.FillBy(this.houseDataSet4.Ding_dan1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.xin_xi1TableAdapter.FillBy(this.houseDataSet6.Xin_xi1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.ding_dan1TableAdapter.FillBy1(this.houseDataSet4.Ding_dan1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
