using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaVendaIngresso.Classes;

namespace wfaVendaIngresso
{
    public partial class frmDetalharIngresso : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        Ingresso ingresso;
        public frmDetalharIngresso(Ingresso ingresso)
        {
            InitializeComponent();
            this.ingresso = ingresso;
            carregarCampos();
        }

        private void carregarCampos()
        {
            txtId.Text = ingresso.id.ToString();
            txtNome.Text = ingresso.nomeEvento;
            txtEndereco.Text = ingresso.enderecoEvento;
            txtValor.Text = "R$ " + ingresso.valor.ToString();
            txtQuantidade.Text = ingresso.quantidade.ToString();
            txtFormaPagamento.Text = ingresso.formaPagamento;
            txtDataHora.Text = ingresso.dataHoraEvento.ToString();

            pcbQrCode.Image = GerarQRCode(pcbQrCode.Width, pcbQrCode.Height, ingresso.nomeEvento + ingresso.id);

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public Bitmap GerarQRCode(int width, int height, string text)
        {
            try
            {
                var bw = new ZXing.BarcodeWriter();
                var encOptions = new ZXing.Common.EncodingOptions() { Width = width, Height = height, Margin = 0 };
                bw.Options = encOptions;
                bw.Format = ZXing.BarcodeFormat.QR_CODE;
                var resultado = new Bitmap(bw.Write(text));
                return resultado;
            }
            catch
            {
                throw;
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
    }
}
