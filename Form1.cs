using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai16_FormatText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ten = " Nguyễn Thị Hoài Mơ ";
            lblInfo.Text = " Họ và tên thí sinh " + ten + Environment.NewLine;
            lblInfo.Text += "Ngày viết chương trình" + System.DateTime.Now;
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formatTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText formatText = new FormatText();
            formatText .MdiParent = this;
            formatText.Show();
        }

        private void aboutBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.MdiParent = this;
            aboutBox1.Show();
        }
    }
}
