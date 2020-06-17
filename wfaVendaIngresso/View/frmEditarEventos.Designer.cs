namespace wfaVendaIngresso
{
    partial class frmEditarEventos
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCadastroUsuario = new System.Windows.Forms.Label();
            this.barraVertical = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.pcbEvento = new System.Windows.Forms.PictureBox();
            this.txtDataHora = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValorIngresso = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.barraVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
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
            this.btnTrocaFoto.Location = new System.Drawing.Point(217, 653);
            this.btnTrocaFoto.Name = "btnTrocaFoto";
            this.btnTrocaFoto.Size = new System.Drawing.Size(174, 38);
            this.btnTrocaFoto.TabIndex = 4;
            this.btnTrocaFoto.Text = "Trocar Imagem";
            this.btnTrocaFoto.UseVisualStyleBackColor = false;
            this.btnTrocaFoto.Click += new System.EventHandler(this.btnTrocaFoto_Click);
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
            this.btnSalvar.Location = new System.Drawing.Point(24, 653);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(174, 38);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblCadastroUsuario
            // 
            this.lblCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblCadastroUsuario.Location = new System.Drawing.Point(8, 30);
            this.lblCadastroUsuario.Name = "lblCadastroUsuario";
            this.lblCadastroUsuario.Size = new System.Drawing.Size(272, 50);
            this.lblCadastroUsuario.TabIndex = 52;
            this.lblCadastroUsuario.Text = "Editar Evento";
            // 
            // barraVertical
            // 
            this.barraVertical.Controls.Add(this.btnFechar);
            this.barraVertical.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraVertical.Location = new System.Drawing.Point(0, 0);
            this.barraVertical.Name = "barraVertical";
            this.barraVertical.Size = new System.Drawing.Size(1280, 27);
            this.barraVertical.TabIndex = 54;
            this.barraVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraVertical_MouseDown);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::wfaVendaIngresso.Properties.Resources.icon_cerrar2;
            this.btnFechar.Location = new System.Drawing.Point(1257, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(20, 20);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 55;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pcbEvento
            // 
            this.pcbEvento.Image = global::wfaVendaIngresso.Properties.Resources.apolloCadastroOficial;
            this.pcbEvento.Location = new System.Drawing.Point(414, -1);
            this.pcbEvento.Name = "pcbEvento";
            this.pcbEvento.Size = new System.Drawing.Size(866, 721);
            this.pcbEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEvento.TabIndex = 42;
            this.pcbEvento.TabStop = false;
            // 
            // txtDataHora
            // 
            this.txtDataHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDataHora.Location = new System.Drawing.Point(24, 232);
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.Size = new System.Drawing.Size(367, 26);
            this.txtDataHora.TabIndex = 78;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(24, 126);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(367, 26);
            this.txtNome.TabIndex = 76;
            // 
            // txtValorIngresso
            // 
            this.txtValorIngresso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorIngresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtValorIngresso.Location = new System.Drawing.Point(24, 285);
            this.txtValorIngresso.Name = "txtValorIngresso";
            this.txtValorIngresso.Size = new System.Drawing.Size(367, 26);
            this.txtValorIngresso.TabIndex = 80;
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEndereco.Location = new System.Drawing.Point(24, 179);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(367, 26);
            this.txtEndereco.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(20, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(20, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Data/Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(20, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 75;
            this.label5.Text = "Nome";
            // 
            // frmEditarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblCadastroUsuario);
            this.Controls.Add(this.barraVertical);
            this.Controls.Add(this.txtDataHora);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtValorIngresso);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTrocaFoto);
            this.Controls.Add(this.pcbEvento);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Evento";
            this.barraVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrocaFoto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCadastroUsuario;
        private System.Windows.Forms.PictureBox pcbEvento;
        private System.Windows.Forms.Panel barraVertical;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.TextBox txtDataHora;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValorIngresso;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}