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
using wfaVendaIngresso.View;

namespace wfaVendaIngresso
{
    public partial class frmEditarEventos : Form
    {
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        public event Action loadEventos;
        public Evento evento;
        public frmEditarEventos(Evento evento)
        {
            
            InitializeComponent();
            if(evento == null)
            {
                return;
            }
            this.evento = evento;
            preencherCampos();
        }
       
        private void preencherCampos()
        {
            txtNome.Text = evento.nome;
            txtEndereco.Text = evento.endereco;
            txtDataHora.Text = evento.dataHora.ToString();
            txtValorIngresso.Text = evento.valorIngresso.ToString();

            if (evento.imgEvent == null)
            {
                pcbEvento.Image = Properties.Resources.apolloCadastroOficial;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(evento.imgEvent);
                pcbEvento.Image = System.Drawing.Image.FromStream(mstream);
            }
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MemoryStream mstream = new MemoryStream();
            pcbEvento.Image.Save(mstream, pcbEvento.Image.RawFormat);
            byte[] img = mstream.ToArray();

            evento.nome = txtNome.Text;
            evento.endereco = txtEndereco.Text;
            evento.dataHora = Convert.ToDateTime(txtDataHora.Text);
            evento.valorIngresso = Double.Parse(txtValorIngresso.Text);
            evento.imgEvent = img;

            EventoDAO dao = new EventoDAO();
            dao.update(evento);
         
            MessageBox.Show("Evento alterado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (loadEventos != null)
            {
                loadEventos();
            }
           
            this.Hide();
        }
    }
}

