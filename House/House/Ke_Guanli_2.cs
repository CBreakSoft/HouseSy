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
    public partial class Ke_Guanli_2 : Form
    {
        public Ke_Guanli_2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ding_fang f = new Ding_fang();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ding_dan f = new Ding_dan();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tui_fang f = new Tui_fang();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Huan_fang f = new Huan_fang();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
