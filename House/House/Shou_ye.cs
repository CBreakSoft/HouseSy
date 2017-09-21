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
    public partial class Shou_ye : Form
    {
        public Shou_ye()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deng_lu f = new Deng_lu();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zhu_ce f = new Zhu_ce();
            f.Show();
        }
    }
}
