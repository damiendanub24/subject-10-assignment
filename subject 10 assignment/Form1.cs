using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subject_10_assignment
{
    public partial class FormComputerinfo : Form
    {
        public FormComputerinfo()
        {
            InitializeComponent();
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            imgInfo.Image = Properties.Resources.imgCPU;
            lblInfo.Text = Properties.Resources.txtCPU;
        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            imgInfo.Image = Properties.Resources.imgRAM;
            lblInfo.Text = Properties.Resources.txtRAM;
        }

        private void btnSSD_Click(object sender, EventArgs e)
        {
            imgInfo.Image = Properties.Resources.imgSSD;
            lblInfo.Text = Properties.Resources.txtSSD;
        }

        private void btnPSU_Click(object sender, EventArgs e)
        {
            imgInfo.Image = Properties.Resources.imgPSU;
            lblInfo.Text = Properties.Resources.txtPSU;
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            imgInfo.Image = Properties.Resources.imgIP;
            lblInfo.Text = Properties.Resources.txtIP;
        }

        private void btnOP_Click(object sender, EventArgs e)
        {
            imgInfo.Image = Properties.Resources.imgOP;
            lblInfo.Text = Properties.Resources.txtOP;
        }
    }
}
