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

                pessoa.tipo = cbTipo.Text;
                pessoa.cpf = txtCpf.Text;
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

                MessageBox.Show("Usuário Atualizado com Sucesso", "Fazendo umas mudanças");
            }
        private void delete(Pessoa pessoa)
        {
            PessoaBll pessoaBll = new PessoaBll();

          
            pessoa.cpf = txtCpf.Text;
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
                        txtImagem.Text = foto;
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
            txtCpf.Text = pessoa.cpf;
            txtDataNasc.Text = pessoa.dataNascimento.ToString();
            txtEndereco.Text = pessoa.endereco;
            txtBairro.Text = pessoa.bairro;
            txtCep.Text = pessoa.cep;
            txtCidade.Text = pessoa.cidade;
            txtEstado.Text = pessoa.estado;
            txtTelefone.Text = pessoa.telefone;
            cbTipo.Text = pessoa.tipo;

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
            if (MessageBox.Show("Você tem certeza que deseja excluir sua conta? :c", "Não faça isso por favor!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Okay, conta excluída", "O mundo está perdido");
                delete(pessoa);
            }
            else
            {
                MessageBox.Show("Ufa, pensei que você iria fazer uma loucura!", "Ainda existem pessoas de bem");
            }
        }
    }
    }

