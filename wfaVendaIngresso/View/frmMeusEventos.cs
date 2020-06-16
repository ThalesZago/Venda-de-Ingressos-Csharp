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
    public partial class frmMeusEventos : Form
    {
        public frmMeusEventos()
        {
            InitializeComponent();
        }

        frmEditarEventos eventos = new frmEditarEventos();  

        private void pcbEvento1_Click(object sender, EventArgs e)
        {
            eventos.ShowDialog();
        }

        private void pcbEvento2_Click(object sender, EventArgs e)
        {
            eventos.ShowDialog();
        }

        private void pcbEvento3_Click(object sender, EventArgs e)
        {
            eventos.ShowDialog();
        }

        private void pcbEvento4_Click(object sender, EventArgs e)
        {
            eventos.ShowDialog();
        }

        private void pcbEvento5_Click(object sender, EventArgs e)
        {
            eventos.ShowDialog();
        }

        private void pcbEvento6_Click(object sender, EventArgs e)
        {
            eventos.ShowDialog();
        }
    }
}
