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
    public partial class FormatText : Form
    {
        public FormatText()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Red;
            txtNhapten.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Green;
            txtNhapten.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Blue;
            txtNhapten.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.ForeColor = Color.Black;
            txtNhapten.ForeColor = Color.Black;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLaptrinh.Font = new Font (lblLaptrinh.Font.Name , lblLaptrinh.Font.Size,lblLaptrinh.Font.Style ^ FontStyle.Bold);
        }
    }
}
