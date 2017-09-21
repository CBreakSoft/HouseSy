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
    public partial class Ke_Xinxi : Form
    {
        public Ke_Xinxi()
        {
            InitializeComponent();
        }

        private void Ke_Xinxi_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“houseDataSet17.Xin_xi1”中。您可以根据需要移动或删除它。
            this.xin_xi1TableAdapter.Fill(this.houseDataSet17.Xin_xi1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            string strConn = @"server=DESKTOP-7MDE3B1;uid=sa;pwd=1234567890;database=house";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
            SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
            ConnSql.Open();//打开数据库
            string strSQL = "select * from Yong_hu1";//要执行的SQL语句
            SqlDataAdapter da = new SqlDataAdapter(strSQL, ConnSql);//创建DataAdapter数据适配器实例
            SqlConnection mycon = new SqlConnection(strConn);
            // mycon.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);//填充数据到dt
            foreach (DataRow row in dt.Rows)
            {
                list1.Add(row["Name"].ToString());
                list2.Add(row["Number"].ToString());
                list3.Add(row["Zhuzhi"].ToString());
            }
            String[] s1 = list1.ToArray();
            String[] s2 = list2.ToArray();
            String[] s3 = list3.ToArray();
           
            int flag = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i].Equals(textBox1.Text) && s2[i].Equals(textBox2.Text) && s3[i].Equals(textBox3.Text) )
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
                string conStr1 =@"server=DESKTOP-7MDE3B1;uid=sa;pwd=1234567890;database=house";
                SqlConnection mycon1 = new SqlConnection(conStr1);
                mycon1.Open();
                if (textBox1.Text != " " && textBox2.Text != "" && textBox3.Text != "")
                {
                    string sql4 = "insert into Yong_hu1 values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    SqlCommand com = new SqlCommand(sql4, mycon1);
                    SqlDataReader dr = com.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("用户信息储存成功");
                }
                else
                    MessageBox.Show("用户信息储存失败");
                this.Close();
            } 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
