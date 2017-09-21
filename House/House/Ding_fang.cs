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
    public partial class Ding_fang : Form
    {
        public Ding_fang()
        {
            InitializeComponent();
        }

        private void Ding_fang_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“houseDataSet3.Yong_hu1”中。您可以根据需要移动或删除它。
            this.yong_hu1TableAdapter.Fill(this.houseDataSet3.Yong_hu1);
            // TODO: 这行代码将数据加载到表“houseDataSet2.Xin_xi1”中。您可以根据需要移动或删除它。
            this.xin_xi1TableAdapter.Fill(this.houseDataSet2.Xin_xi1);



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

        private void button1_Click(object sender, EventArgs e)
        {
              List<string> list1 = new List<string>();
              List<string> list2 = new List<string>();
              List<string> list3 = new List<string>();
              string strConn = @"server=DESKTOP-7MDE3B1;uid=sa;pwd=1234567890;database=house";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
              SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
              ConnSql.Open();//打开数据库
              string strSQL = "select * from Ding_dan1";//要执行的SQL语句
              SqlDataAdapter da = new SqlDataAdapter(strSQL, ConnSql);//创建DataAdapter数据适配器实例
              SqlConnection mycon = new SqlConnection(strConn);
              // mycon.Open();
              DataTable dt = new DataTable();
              da.Fill(dt);//填充数据到dt
              foreach (DataRow row in dt.Rows)
              {
                  list1.Add(row["Number"].ToString());
                  list2.Add(row["Kefanghao"].ToString());
                  list3.Add(row["Time1"].ToString());
              }
              String[] s1 = list1.ToArray();
              String[] s2 = list2.ToArray();
              String[] s3 = list3.ToArray();

              int flag = 0;
              for (int i = 0; i < s1.Length; i++)
              {
                  if (s1[i].Equals(comboBox1.Text) && s2[i].Equals(comboBox2.Text) && s3[i].Equals(dateTimePicker1.Text))
                  {
                      flag = 1;
                      break;
                  }
              }
              ConnSql.Close();//关闭数据库
              if (flag == 1)
              {
                  MessageBox.Show("该用户已存在");
              }
              else if (flag == 0) 
              {
                  string conStr1 = @"server=DESKTOP-7MDE3B1;uid=sa;pwd=1234567890;database=house";
                  SqlConnection mycon1 = new SqlConnection(conStr1);
                  mycon1.Open();
                  if (comboBox1.Text != " " && comboBox2.Text != "" && dateTimePicker1.Text != "")
                  {
                      string sql4 = "insert into Ding_dan1 values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "')";
                      SqlCommand com = new SqlCommand(sql4, mycon1);
                      SqlDataReader dr = com.ExecuteReader();
                      dr.Close();
                    /*  string sql2 = "update  Xin_xi1 set Zhuangtai= '"+入住+"' where Kefanghao='"+comboBox2.Text+"'";
                      SqlCommand com2 = new SqlCommand(sql2, mycon1);
                      SqlDataReader dr2 = com.ExecuteReader();
                      dr2.Close();*/
                      MessageBox.Show("该用户订房成功");
                  }
                  else
                      MessageBox.Show("该用户订房失败");
                 this.Close();
              }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void fillBy1ToolStripButton1_Click(object sender, EventArgs e)
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

        private void fillByToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
     
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_5(object sender, EventArgs e)
        {
            try
            {
         
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public string 入住 { get; set; }

        private void fillByToolStripButton_Click_6(object sender, EventArgs e)
        {
            try
            {
                this.yong_hu1TableAdapter.FillBy(this.houseDataSet3.Yong_hu1);
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
                this.xin_xi1TableAdapter.FillBy(this.houseDataSet2.Xin_xi1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
