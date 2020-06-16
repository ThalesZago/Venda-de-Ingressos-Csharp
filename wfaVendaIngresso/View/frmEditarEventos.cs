using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaVendaIngresso
{
    public partial class frmEditarEventos : Form
    {
        public frmEditarEventos()
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
                    txtFoto.Text = foto;
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
    }
}

