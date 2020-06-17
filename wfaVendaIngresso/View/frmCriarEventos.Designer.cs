namespace wfaVendaIngresso
{
    partial class frmCriarEventos
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
            this.btnTrocaFoto = new System.Windows.Forms.Button();
            this.lblCadastroUsuario = new System.Windows.Forms.Label();
            this.txtDataHora = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValorIngresso = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pcbEvento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrocaFoto
            // 
            this.btnTrocaFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(86)))), ((int)(((byte)(247)))));
            this.btnTrocaFoto.FlatAppearance.BorderSize = 0;
            this.btnTrocaFoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnTrocaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrocaFoto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocaFoto.ForeColor = System.Drawing.Color.White;
            this.btnTrocaFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrocaFoto.Location = new System.Drawing.Point(713, 571);
            this.btnTrocaFoto.Name = "btnTrocaFoto";
            this.btnTrocaFoto.Size = new System.Drawing.Size(156, 38);
            this.btnTrocaFoto.TabIndex = 54;
            this.btnTrocaFoto.Text = "Trocar Imagem";
            this.btnTrocaFoto.UseVisualStyleBackColor = false;
            this.btnTrocaFoto.Click += new System.EventHandler(this.btnTrocaFoto_Click);
            // 
            // lblCadastroUsuario
            // 
            this.lblCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblCadastroUsuario.Location = new System.Drawing.Point(653, 49);
            this.lblCadastroUsuario.Name = "lblCadastroUsuario";
            this.lblCadastroUsuario.Size = new System.Drawing.Size(272, 50);
            this.lblCadastroUsuario.TabIndex = 70;
            this.lblCadastroUsuario.Text = "Criar Evento";
            // 
            // txtDataHora
            // 
            this.txtDataHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDataHora.Location = new System.Drawing.Point(660, 273);
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.Size = new System.Drawing.Size(367, 26);
            this.txtDataHora.TabIndex = 69;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(660, 167);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(367, 26);
            this.txtNome.TabIndex = 66;
            // 
            // txtValorIngresso
            // 
            this.txtValorIngresso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorIngresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorIngresso.Location = new System.Drawing.Point(660, 326);
            this.txtValorIngresso.Name = "txtValorIngresso";
            this.txtValorIngresso.Size = new System.Drawing.Size(367, 26);
            this.txtValorIngresso.TabIndex = 71;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEndereco.Location = new System.Drawing.Point(660, 220);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(367, 26);
            this.txtEndereco.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(656, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "Valor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(656, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 62;
            this.label12.Text = "Endereço";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(656, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 63;
            this.label13.Text = "Data/Hora";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Gray;
            this.lblNome.Location = new System.Drawing.Point(656, 143);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 64;
            this.lblNome.Text = "Nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(86)))), ((int)(((byte)(247)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(875, 571);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(152, 38);
            this.btnSalvar.TabIndex = 55;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pcbEvento
            // 
            this.pcbEvento.Image = global::wfaVendaIngresso.Properties.Resources.apolloCadastroOficial;
            this.pcbEvento.Location = new System.Drawing.Point(-1, -1);
            this.pcbEvento.Name = "pcbEvento";
            this.pcbEvento.Size = new System.Drawing.Size(639, 618);
            this.pcbEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEvento.TabIndex = 59;
            this.pcbEvento.TabStop = false;
            // 
            // frmCriarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 621);
            this.Controls.Add(this.btnTrocaFoto);
            this.Controls.Add(this.lblCadastroUsuario);
            this.Controls.Add(this.txtDataHora);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtValorIngresso);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pcbEvento);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCriarEventos";
            this.Text = "frmCriarEventos";
            ((System.ComponentModel.ISupportInitialize)(this.pcbEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrocaFoto;
        private System.Windows.Forms.Label lblCadastroUsuario;
        private System.Windows.Forms.TextBox txtDataHora;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValorIngresso;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbEvento;
        private System.Windows.Forms.Button btnSalvar;
    }
}