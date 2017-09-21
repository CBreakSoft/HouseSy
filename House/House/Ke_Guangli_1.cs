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
    public partial class Ke_Guangli_1 : Form
    {
        public Ke_Guangli_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ke_Xinxi f = new Ke_Xinxi();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ke_Guanli_2 f = new Ke_Guanli_2();
            f.Show();
        }
    }
}
