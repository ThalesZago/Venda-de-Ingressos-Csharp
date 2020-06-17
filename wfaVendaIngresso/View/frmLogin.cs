using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using wfaVendaIngresso.Classes;
using wfaVendaIngresso.Dao;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.InteropServices;

namespace wfaVendaIngresso.View
{
    public partial class frmLogin : Form
    {
        public static Pessoa pessoa;
        public frmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PessoaDAO dao = new PessoaDAO();
            
            List<Pessoa> pessoas = dao.getPessoas(txtUsuarioLogin.Text, txtSenhaLogin.Text);
            if (!pessoas.Any())
            {
                MessageBox.Show("usuario invalido");
            }
            else if(pessoas[0].isAdmin == "ADMIN")
            {
                this.Hide();
                pessoa = pessoas[0];
                frmPrincipal principal = new frmPrincipal();
                principal.ShowDialog();
            }
            else
            {
                this.Hide();
                pessoa = pessoas[0];
                frmPrincipalUser user = new frmPrincipalUser();
                user.ShowDialog();
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario cadastroUsuario = new frmCadastroUsuario();
            cadastroUsuario.ShowDialog();
            
        }

        private void barraVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
