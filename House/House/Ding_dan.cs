using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace House
{
    public partial class Ding_dan : Form
    {
        public Ding_dan()
        {
            InitializeComponent();
        }

        private void Ding_dan_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“houseDataSet7.Ding_dan1”中。您可以根据需要移动或删除它。
            this.ding_dan1TableAdapter.Fill(this.houseDataSet7.Ding_dan1);
            // TODO: 这行代码将数据加载到表“houseDataSet7.Ding_dan1”中。您可以根据需要移动或删除它。
            this.ding_dan1TableAdapter.Fill(this.houseDataSet7.Ding_dan1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
