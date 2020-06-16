using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace wfaVendaIngresso.View
{
    public partial class frmPrincipalUser : Form
    {
        public frmPrincipalUser()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

    
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barraVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinhaConta_Click(object sender, EventArgs e)
        {
            openFormInPanel(new frmMinhaConta());
            barraVertical.BackColor = Color.WhiteSmoke;
        }
        private void openFormInPanel(object formFilho)
        {
            if (this.panelContainer.Controls.Count > 0)
            {
                this.panelContainer.Controls.RemoveAt(0);
            }
            Form ff = formFilho as Form;
            ff.TopLevel = false;
            ff.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(ff);
            this.panelContainer.Tag = ff;
            ff.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openFormInPanel(new frmHome());
            barraVertical.BackgroundImage = null;
            btnFechar.Image = Properties.Resources.icon_cerrar2;
            btnMinimizar.Image = Properties.Resources.icon_minimizar;
        }

        private void btnMeusEventos_Click(object sender, EventArgs e)
        {
            openFormInPanel(new frmMeusEventos());
            barraVertical.BackgroundImage = null;
            btnFechar.Image = Properties.Resources.icon_cerrar2;
            btnMinimizar.Image = Properties.Resources.icon_minimizar;
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            openFormInPanel(new View.frmSobre());
            barraVertical.BackgroundImage = Properties.Resources.verticalPanelGradient;
            btnFechar.Image = Properties.Resources.cerrar1;
            btnMinimizar.Image = Properties.Resources.minimazar;

        }

        private void btnMeusIngressos_Click(object sender, EventArgs e)
        {
            openFormInPanel(new frmMeusIngressos());
            barraVertical.BackgroundImage = null;
            btnFechar.Image = Properties.Resources.icon_cerrar2;
            btnMinimizar.Image = Properties.Resources.icon_minimizar;
        }
    }
}
