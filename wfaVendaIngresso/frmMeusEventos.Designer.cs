namespace wfaVendaIngresso
{
    partial class frmMeusEventos
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
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovoEvento = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.idEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventos
            // 
            this.dgvEventos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEvento,
            this.nomeEvento,
            this.enderecoEvento,
            this.dataEvento,
            this.valorEvento,
            this.descricaoEvento});
            this.dgvEventos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvEventos.Location = new System.Drawing.Point(42, 33);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.Size = new System.Drawing.Size(645, 531);
            this.dgvEventos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Eventos";
            // 
            // btnNovoEvento
            // 
            this.btnNovoEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.btnNovoEvento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnNovoEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNovoEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoEvento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoEvento.ForeColor = System.Drawing.Color.White;
            this.btnNovoEvento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoEvento.Location = new System.Drawing.Point(707, 33);
            this.btnNovoEvento.Name = "btnNovoEvento";
            this.btnNovoEvento.Size = new System.Drawing.Size(250, 40);
            this.btnNovoEvento.TabIndex = 4;
            this.btnNovoEvento.Text = "Novo";
            this.btnNovoEvento.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(707, 95);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(250, 40);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(31)))), ((int)(((byte)(51)))));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(707, 156);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(250, 40);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
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
            // frmMeusEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovoEvento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMeusEventos";
            this.Text = "frmMeusEventos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovoEvento;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoEvento;
    }
}