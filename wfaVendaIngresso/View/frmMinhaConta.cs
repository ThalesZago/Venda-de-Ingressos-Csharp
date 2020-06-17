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
using System.IO;
using MySql.Data.MySqlClient;
namespace wfaVendaIngresso
{
    public partial class frmMinhaConta : Form
    {
        Pessoa pessoa = new Pessoa();
        public frmMinhaConta()
        {
            InitializeComponent();
        }

       private void salvar(Pessoa pessoa)
            {
                PessoaBll pessoaBll = new PessoaBll();

                MemoryStream mstream = new MemoryStream();
                pcbFotoConta.Image.Save(mstream, pcbFotoConta.Image.RawFormat);
                byte[] img = mstream.ToArray();

                pessoa.tipo = "Pessoa Física";
                pessoa.cpf = txtCpf.Text.Replace(".", "");
                pessoa.dataNascimento = Convert.ToDateTime(txtDataNasc.Text);
                pessoa.nome = txtNome.Text;
                pessoa.email = txtEmail.Text;
                pessoa.telefone = txtTelefone.Text;
                pessoa.endereco = txtEndereco.Text;
                pessoa.bairro = txtBairro.Text;
                pessoa.cep = txtCep.Text;
                pessoa.cidade = txtCidade.Text;
                pessoa.estado = txtEstado.Text;
                pessoa.imgUser = img;

                pessoaBll.update(pessoa);

                MessageBox.Show("Usuário alterado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void delete(Pessoa pessoa)
        {
            PessoaBll pessoaBll = new PessoaBll();

          
            pessoa.cpf = txtCpf.Text.Replace(".", "");
            pessoaBll.delete(pessoa);
            Application.Exit();

           
        }
        private void btnTrocaFoto_Click(object sender, EventArgs e)
            {

                try
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        string foto = dialog.FileName.ToString();
                        pcbFotoConta.ImageLocation = foto;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um Erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            private void btnSalvar_Click(object sender, EventArgs e)
            {
                salvar(pessoa);
            }

        private void frmMinhaConta_Load(object sender, EventArgs e)
        {
            pessoa = View.frmLogin.pessoa;
            txtNome.Text = pessoa.nome;
            txtEmail.Text = pessoa.email;
            txtCpf.Text = pessoa.cpf.ToString();
            txtDataNasc.Text = pessoa.dataNascimento.ToString();
            txtEndereco.Text = pessoa.endereco;
            txtBairro.Text = pessoa.bairro;
            txtCep.Text = pessoa.cep;
            txtCidade.Text = pessoa.cidade;
            txtEstado.Text = pessoa.estado;
            txtTelefone.Text = pessoa.telefone;

            if (pessoa.imgUser == null)
            {
                pcbFotoConta.Image = Properties.Resources.boss_man_128;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(pessoa.imgUser);
                pcbFotoConta.Image = System.Drawing.Image.FromStream(mstream);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja excluir sua conta?", "Não faça isso por favor!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                delete(pessoa);
                MessageBox.Show("Conta excluída com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Conta excluída com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
    }

