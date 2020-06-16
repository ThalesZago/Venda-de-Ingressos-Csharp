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
using wfaVendaIngresso.Bll;
namespace wfaVendaIngresso.View
{
    public partial class frmCadastroUsuario : Form
    {
        Pessoa pessoa = new Pessoa();
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void cadastraPessoa(Pessoa pessoa)
        {
            PessoaBll pessoaBll = new PessoaBll();

            
            pessoa.cpf = txtCpf.Text;
            pessoa.nome = txtNome.Text;
            pessoa.email = txtEmail.Text;
            pessoa.username = txtUsuario.Text;
            pessoa.password = txtSenha.Text;
            pessoa.isAdmin = lbIsAdmin.Text;

            pessoaBll.insert(pessoa);

            MessageBox.Show("Usuário Cadastrado com Sucesso!");
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
    }
}
