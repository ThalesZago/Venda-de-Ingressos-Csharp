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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lblDataHora.Text = datetime.ToString();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            tmrHora.Start();
        }
    }
}
