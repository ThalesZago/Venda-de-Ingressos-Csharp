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

namespace wfaVendaIngresso
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 71;
            }
            else
            {
                menuVertical.Width = 250;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int LX, LY;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1300, 650);
            this.Location = new Point(LX, LY);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
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

        private void openFormInPanel(object formFilho)
        {
            if(this.panelContainer.Controls.Count > 0)
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
        }

        private void btnMinhaConta_Click(object sender, EventArgs e)
        {
            openFormInPanel(new frmMinhaConta());
        }

        private void btnMeusEventos_Click(object sender, EventArgs e)
        {
            openFormInPanel(new frmMeusEventos());
        }


        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84;
            const int DesEsquerda = 16;
            const int DesDireita = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamanhoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamanhoAreaForm.Width - 16 && CoordenadaArea.Y >= TamanhoAreaForm.Height - 17)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesEsquerda : DesDireita);
                    return;
                }
            }
            base.WndProc(ref msj);
        }

    }
}
