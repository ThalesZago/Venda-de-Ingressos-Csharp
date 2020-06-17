using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaVendaIngresso.Classes;
using wfaVendaIngresso.Dao;

namespace wfaVendaIngresso
{
    public partial class frmComprarIngressos : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        public Evento evento;
        public frmComprarIngressos(Evento evento)
        {
            InitializeComponent();
            this.evento = evento;

            preencherCampos();
        }

        private void preencherCampos()
        {
            this.lblDetalhesEvento.Text = evento.nome;
            this.lblEvent1.Text = evento.dataHora.ToString();
            this.label3.Text = "R$ " + evento.valorIngresso.ToString();
            this.label5.Text = "R$ " + evento.valorTaxas.ToString();
            this.label7.Text = "R$ " + (evento.valorTaxas + evento.valorIngresso).ToString();
            if (evento.imgEvent == null)
            {
                pictureBox4.Image = Properties.Resources.apolloCadastroOficial;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(evento.imgEvent);
                pictureBox4.Image = System.Drawing.Image.FromStream(mstream);
            }
        }

        private void barraVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnComprarIngresso_Click(object sender, EventArgs e)
        {
            if(txtConfirmaEmail.Text != txtEmail.Text)
            {
                MessageBox.Show("O e-mail confirmado está diferente do informado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Int32.Parse(cbQtdIngressos.Text) == 0)
            {
                MessageBox.Show("O campo Quantidade de Ingressos não pode ser 0");
                return;
            }

            if(txtConfirmaEmail.Text == "" || txtEmail.Text == "" || txtNome.Text == "" || txtSobrenome.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
                return;
            }

            Ingresso ingresso = new Ingresso();
            ingresso.idEvento = evento.id;
            ingresso.cpfPessoa = View.frmLogin.pessoa.cpf;
            ingresso.valor = (evento.valorTaxas + evento.valorIngresso) * Int32.Parse(cbQtdIngressos.Text);
            ingresso.quantidade = Int32.Parse(cbQtdIngressos.Text);
            ingresso.formaPagamento = cbFormaPagamento.Text;

            IngressoDAO dao = new IngressoDAO();
            dao.insert(ingresso);


            MessageBox.Show("Ingresso comprado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }

        private void cbQtdIngressos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label7.Text = "R$ " + ((evento.valorTaxas + evento.valorIngresso) * Int32.Parse(cbQtdIngressos.Text)).ToString();
        }
    }
}
