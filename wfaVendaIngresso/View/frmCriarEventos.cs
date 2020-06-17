using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaVendaIngresso.Classes;
using wfaVendaIngresso.Dao;
using wfaVendaIngresso.View;

namespace wfaVendaIngresso
{
    public partial class frmCriarEventos : Form
    {
        public frmCriarEventos()
        {
            InitializeComponent();
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
                    pcbEvento.ImageLocation = foto;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um Erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MemoryStream mstream = new MemoryStream();
            pcbEvento.Image.Save(mstream, pcbEvento.Image.RawFormat);
            byte[] img = mstream.ToArray();

            Evento evento = new Evento();
            evento.nome = txtNome.Text;
            evento.endereco = txtEndereco.Text;
            evento.dataHora = Convert.ToDateTime(txtDataHora.Text);
            evento.valorIngresso = Double.Parse(txtValorIngresso.Text);
            evento.imgEvent = img;

            EventoDAO dao = new EventoDAO();
            dao.insert(evento, frmLogin.pessoa);

            

            MessageBox.Show("Evento cadastrado com sucesso", "Sucesso!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
