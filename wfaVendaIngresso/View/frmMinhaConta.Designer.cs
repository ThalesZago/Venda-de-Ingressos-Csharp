namespace wfaVendaIngresso
{
    partial class frmMinhaConta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataNasc = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.btnTrocaFoto = new System.Windows.Forms.Button();
            this.pcbFotoConta = new wfaVendaIngresso.Classes.RoundedPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoConta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lblBairro);
            this.panel1.Controls.Add(this.txtCidade);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.lblCep);
            this.panel1.Controls.Add(this.txtCep);
            this.panel1.Controls.Add(this.lblCidade);
            this.panel1.Controls.Add(this.txtBairro);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Location = new System.Drawing.Point(519, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 391);
            this.panel1.TabIndex = 1;
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(32, 229);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(288, 24);
            this.txtEstado.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(86)))), ((int)(((byte)(247)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(179, 319);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 39);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(29, 20);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(52, 18);
            this.lblBairro.TabIndex = 0;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(32, 167);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(288, 24);
            this.txtCidade.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(86)))), ((int)(((byte)(247)))));
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(32, 319);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(141, 39);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(29, 82);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(43, 18);
            this.lblCep.TabIndex = 0;
            this.lblCep.Text = "CEP:";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(32, 105);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(288, 24);
            this.txtCep.TabIndex = 1;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(29, 144);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(58, 18);
            this.lblCidade.TabIndex = 0;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(32, 43);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(288, 24);
            this.txtBairro.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(29, 206);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(59, 18);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtEndereco);
            this.panel2.Controls.Add(this.txtTelefone);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.txtDataNasc);
            this.panel2.Controls.Add(this.txtCpf);
            this.panel2.Controls.Add(this.lblEndereco);
            this.panel2.Controls.Add(this.lblTelefone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblCpf);
            this.panel2.Location = new System.Drawing.Point(162, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 391);
            this.panel2.TabIndex = 0;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(12, 353);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(288, 24);
            this.txtEndereco.TabIndex = 1;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(13, 291);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(288, 24);
            this.txtTelefone.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(12, 229);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 24);
            this.txtEmail.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 167);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(288, 24);
            this.txtNome.TabIndex = 1;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNasc.Location = new System.Drawing.Point(12, 105);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(288, 24);
            this.txtDataNasc.TabIndex = 1;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(12, 43);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(288, 24);
            this.txtCpf.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(9, 330);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(72, 18);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(10, 268);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(69, 18);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(9, 144);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de Nascimento:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(9, 20);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(42, 18);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "CPF:";
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
            this.btnTrocaFoto.Location = new System.Drawing.Point(602, 69);
            this.btnTrocaFoto.Name = "btnTrocaFoto";
            this.btnTrocaFoto.Size = new System.Drawing.Size(250, 40);
            this.btnTrocaFoto.TabIndex = 3;
            this.btnTrocaFoto.Text = "Trocar Foto";
            this.btnTrocaFoto.UseVisualStyleBackColor = false;
            this.btnTrocaFoto.Click += new System.EventHandler(this.btnTrocaFoto_Click);
            // 
            // pcbFotoConta
            // 
            this.pcbFotoConta.Location = new System.Drawing.Point(444, 14);
            this.pcbFotoConta.Name = "pcbFotoConta";
            this.pcbFotoConta.Size = new System.Drawing.Size(152, 149);
            this.pcbFotoConta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFotoConta.TabIndex = 5;
            this.pcbFotoConta.TabStop = false;
            // 
            // frmMinhaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::wfaVendaIngresso.Properties.Resources.apolloMinhaContaCerto1;
            this.ClientSize = new System.Drawing.Size(1050, 621);
            this.Controls.Add(this.pcbFotoConta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTrocaFoto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMinhaConta";
            this.Text = "Minha Conta";
            this.Load += new System.EventHandler(this.frmMinhaConta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoConta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDataNasc;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnTrocaFoto;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private Classes.RoundedPictureBox pcbFotoConta;
    }
}