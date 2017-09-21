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
    public partial class Zhu_ce : Form
    {
        public Zhu_ce()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            List<string> list4 = new List<string>();
            List<string> list5 = new List<string>();
            List<string> list6 = new List<string>();
            List<string> list7 = new List<string>();
            string strConn = @"server=DESKTOP-7MDE3B1;uid=sa;pwd=1234567890;database=house";//SQLServer链接字符串server=UX4O9RYIS9GU4MK
            SqlConnection ConnSql = new SqlConnection(strConn);//Sql链接类的实例化
            ConnSql.Open();//打开数据库
            string strSQL = "select * from Zhu_ce ";//要执行的SQL语句
            SqlDataAdapter da = new SqlDataAdapter(strSQL, ConnSql);//创建DataAdapter数据适配器实例
            SqlConnection mycon = new SqlConnection(strConn);
            // mycon.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);//填充数据到dt
            foreach (DataRow row in dt.Rows)
            {
                list1.Add(row["Zhanghao"].ToString());
                list2.Add(row["Mima"].ToString());
                list3.Add(row["Name"].ToString());
                list4.Add(row["Sex"].ToString());
                list5.Add(row["Age"].ToString());
                list6.Add(row["Ddate"].ToString());
                list7.Add(row["School"].ToString());
            }
            String[] s1 = list1.ToArray();
            String[] s2 = list2.ToArray();
            String[] s3 = list3.ToArray();
            String[] s4 = list4.ToArray();
            String[] s5 = list5.ToArray();
            String[] s6 = list6.ToArray();
            String[] s7 = list7.ToArray();
            int flag = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i].Equals(textBox1.Text))
                {
                    flag = 1;
                    break;
                }
            }
            ConnSql.Close();//关闭数据库
            if (flag == 1)
            {
                MessageBox.Show("账号已存在,请更改账号");
            }
            else if (flag == 0)
            {
                string conStr1 = @"server=DESKTOP-7MDE3B1;uid=sa;pwd=1234567890;database=house";
                SqlConnection mycon1 = new SqlConnection(conStr1);
                mycon1.Open();
                string sql4 = "insert into Zhu_ce values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                SqlCommand com = new SqlCommand(sql4, mycon1);
                SqlDataReader dr = com.ExecuteReader();
                dr.Close();
                int m = 0;
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s3[i].Equals(textBox3.Text) && s4[i].Equals(textBox4.Text)
                   && s5[i].Equals(textBox5.Text) && s6[i].Equals(textBox6.Text) && s7[i].Equals(textBox7.Text))
                    {
                        m = 1;
                        break;
                    }
                }
                if (m == 1)
                {
                    MessageBox.Show("您注册过");
                }
                else
                    MessageBox.Show("注册成功");
                this.Close();
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Zhu_ce_Load(object sender, EventArgs e)
        {

        }
    }
}
