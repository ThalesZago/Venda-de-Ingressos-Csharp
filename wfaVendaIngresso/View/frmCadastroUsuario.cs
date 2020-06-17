using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaVendaIngresso.Classes;
using System.Runtime.InteropServices;
using wfaVendaIngresso.Dao;
namespace wfaVendaIngresso.View
{
    public partial class frmCadastroUsuario : Form
    {
        Pessoa pessoa = new Pessoa();
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        private void cadastraPessoa(Pessoa pessoa)
        {
            PessoaDAO dao = new PessoaDAO();

            
            pessoa.cpf = txtCpf.Text.Replace(".", "");
            pessoa.nome = txtNome.Text;
            pessoa.email = txtEmail.Text;
            pessoa.username = txtUsuario.Text;
            pessoa.password = txtSenha.Text;
            pessoa.isAdmin = "USER";

            dao.insert(pessoa);

            MessageBox.Show("Usuário cadastrado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            cadastraPessoa(pessoa);
            txtCpf.Text = "";
            txtEmail.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtUsuario.Text = "";

            this.Hide();
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void barraVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
