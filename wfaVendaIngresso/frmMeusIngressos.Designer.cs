namespace wfaVendaIngresso
{
    partial class frmMeusIngressos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvIngressos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoIngresso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdIngressos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetalhar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngressos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIngressos
            // 
            this.dgvIngressos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dgvIngressos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngressos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEvento,
            this.nomeEvento,
            this.enderecoEvento,
            this.dataEvento,
            this.valorEvento,
            this.descricaoEvento,
            this.formaPagamentoIngresso,
            this.qtdIngressos});
            this.dgvIngressos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvIngressos.Location = new System.Drawing.Point(12, 42);
            this.dgvIngressos.Name = "dgvIngressos";
            this.dgvIngressos.Size = new System.Drawing.Size(847, 507);
            this.dgvIngressos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Ingressos";
            // 
            // idEvento
            // 
            this.idEvento.HeaderText = "ID";
            this.idEvento.Name = "idEvento";
            // 
            // nomeEvento
            // 
            this.nomeEvento.HeaderText = "Nome";
            this.nomeEvento.Name = "nomeEvento";
            // 
            // enderecoEvento
            // 
            this.enderecoEvento.HeaderText = "Endereço";
            this.enderecoEvento.Name = "enderecoEvento";
            // 
            // dataEvento
            // 
            this.dataEvento.HeaderText = "Data/Hora";
            this.dataEvento.Name = "dataEvento";
            // 
            // valorEvento
            // 
            this.valorEvento.HeaderText = "Valor";
            this.valorEvento.Name = "valorEvento";
            // 
            // descricaoEvento
            // 
            this.descricaoEvento.HeaderText = "Descrição";
            this.descricaoEvento.Name = "descricaoEvento";
            // 
            // formaPagamentoIngresso
            // 
            this.formaPagamentoIngresso.HeaderText = "Forma de Pagamento";
            this.formaPagamentoIngresso.Name = "formaPagamentoIngresso";
            // 
            // qtdIngressos
            // 
            this.qtdIngressos.HeaderText = "Quantidade";
            this.qtdIngressos.Name = "qtdIngressos";
            // 
            // btnDetalhar
            // 
            this.btnDetalhar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.btnDetalhar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnDetalhar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDetalhar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalhar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhar.ForeColor = System.Drawing.Color.White;
            this.btnDetalhar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalhar.Location = new System.Drawing.Point(865, 50);
            this.btnDetalhar.Name = "btnDetalhar";
            this.btnDetalhar.Size = new System.Drawing.Size(157, 40);
            this.btnDetalhar.TabIndex = 5;
            this.btnDetalhar.Text = "Detalhar";
            this.btnDetalhar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(865, 498);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmMeusIngressos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDetalhar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIngressos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMeusIngressos";
            this.Text = "frmMeusIngressos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngressos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIngressos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamentoIngresso;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdIngressos;
        private System.Windows.Forms.Button btnDetalhar;
        private System.Windows.Forms.Button btnCancelar;
    }
}