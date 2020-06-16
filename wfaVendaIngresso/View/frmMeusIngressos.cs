using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaVendaIngresso
{
    public partial class frmMeusIngressos : Form
    {
        frmDetalharIngresso ingresso = new frmDetalharIngresso();
        public frmMeusIngressos()
        {
            InitializeComponent();
        }

        private void pcbIngresso1_Click(object sender, EventArgs e)
        {
            ingresso.ShowDialog();
        }

        private void pcbIngresso2_Click(object sender, EventArgs e)
        {
            ingresso.ShowDialog();
        }

        private void pcbIngresso3_Click(object sender, EventArgs e)
        {
            ingresso.ShowDialog();
        }

        private void pcbIngresso4_Click(object sender, EventArgs e)
        {
            ingresso.ShowDialog();
        }

        private void pcbIngresso5_Click(object sender, EventArgs e)
        {
            ingresso.ShowDialog();
        }

        private void pcbIngresso6_Click(object sender, EventArgs e)
        {
            ingresso.ShowDialog();
        }
    }
}
