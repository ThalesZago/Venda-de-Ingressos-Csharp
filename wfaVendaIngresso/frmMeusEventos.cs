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
    public partial class frmMeusEventos : Form
    {
        public frmMeusEventos()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarEventos frmEditar = new frmEditarEventos();
            if (dgvEventos.SelectedRows.Count > 0)
            {
                frmEditar.txtId.Text = dgvEventos.CurrentRow.Cells[0].Value.ToString();
                frmEditar.txtNomeEvento.Text = dgvEventos.CurrentRow.Cells[1].Value.ToString();
                frmEditar.txtEnderecoEvento.Text = dgvEventos.CurrentRow.Cells[2].Value.ToString();
                frmEditar.txtDataHoraEvento.Text = dgvEventos.CurrentRow.Cells[3].Value.ToString();
                frmEditar.txtValorEvento.Text = dgvEventos.CurrentRow.Cells[4].Value.ToString();
                frmEditar.txtDescricaoEvento.Text = dgvEventos.CurrentRow.Cells[5].Value.ToString();
                frmEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para editar!", "ERRO");

            }
        }
    }
}
