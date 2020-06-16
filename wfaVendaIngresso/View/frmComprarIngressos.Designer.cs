namespace wfaVendaIngresso
{
    partial class frmComprarIngressos
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
            this.txtConfirmaEmail = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEvent1 = new System.Windows.Forms.Label();
            this.btnComprarIngresso = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetalhesEvento = new System.Windows.Forms.Label();
            this.cbQtdIngressos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConfirmaEmail
            // 
            this.txtConfirmaEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmaEmail.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmaEmail.Location = new System.Drawing.Point(325, 463);
            this.txtConfirmaEmail.Name = "txtConfirmaEmail";
            this.txtConfirmaEmail.Size = new System.Drawing.Size(288, 26);
            this.txtConfirmaEmail.TabIndex = 36;
            this.txtConfirmaEmail.Text = "Confirmação de email...";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(325, 410);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 26);
            this.txtEmail.TabIndex = 35;
            this.txtEmail.Text = "Email...";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSobrenome.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(15, 463);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(288, 26);
            this.txtSobrenome.TabIndex = 34;
            this.txtSobrenome.Text = "Sobrenome...";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(16, 410);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(288, 26);
            this.txtNome.TabIndex = 33;
            this.txtNome.Text = "Nome...";
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.BackColor = System.Drawing.Color.White;
            this.cbFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFormaPagamento.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Items.AddRange(new object[] {
            "Crédito",
            "Débito",
            "Boleto"});
            this.cbFormaPagamento.Location = new System.Drawing.Point(15, 365);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(288, 33);
            this.cbFormaPagamento.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(942, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "R$ 50,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(942, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "R$ 10,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(697, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Taxas:";
            // 
            // lblEvent1
            // 
            this.lblEvent1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent1.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblEvent1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblEvent1.Location = new System.Drawing.Point(697, 9);
            this.lblEvent1.Name = "lblEvent1";
            this.lblEvent1.Size = new System.Drawing.Size(244, 40);
            this.lblEvent1.TabIndex = 22;
            this.lblEvent1.Text = "Sáb, 2 de Maio, 12:00H";
            this.lblEvent1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnComprarIngresso
            // 
            this.btnComprarIngresso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnComprarIngresso.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnComprarIngresso.FlatAppearance.BorderSize = 0;
            this.btnComprarIngresso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprarIngresso.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarIngresso.ForeColor = System.Drawing.Color.White;
            this.btnComprarIngresso.Location = new System.Drawing.Point(-1, 515);
            this.btnComprarIngresso.Name = "btnComprarIngresso";
            this.btnComprarIngresso.Size = new System.Drawing.Size(1052, 85);
            this.btnComprarIngresso.TabIndex = 21;
            this.btnComprarIngresso.Text = "Comprar";
            this.btnComprarIngresso.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGreen;
            this.label7.Location = new System.Drawing.Point(910, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 37);
            this.label7.TabIndex = 20;
            this.label7.Text = "R$ 60,00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGreen;
            this.label6.Location = new System.Drawing.Point(698, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 37);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(697, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Por: Jureg";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDetalhesEvento
            // 
            this.lblDetalhesEvento.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhesEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblDetalhesEvento.Location = new System.Drawing.Point(694, 49);
            this.lblDetalhesEvento.Name = "lblDetalhesEvento";
            this.lblDetalhesEvento.Size = new System.Drawing.Size(342, 58);
            this.lblDetalhesEvento.TabIndex = 17;
            this.lblDetalhesEvento.Text = "Live Daybreaker";
            this.lblDetalhesEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbQtdIngressos
            // 
            this.cbQtdIngressos.BackColor = System.Drawing.Color.White;
            this.cbQtdIngressos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbQtdIngressos.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQtdIngressos.FormattingEnabled = true;
            this.cbQtdIngressos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbQtdIngressos.Location = new System.Drawing.Point(325, 365);
            this.cbQtdIngressos.Name = "cbQtdIngressos";
            this.cbQtdIngressos.Size = new System.Drawing.Size(288, 33);
            this.cbQtdIngressos.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(697, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Valor Unidade:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::wfaVendaIngresso.Properties.Resources.eventoFoto;
            this.pictureBox4.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(689, 326);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Qtd Ingressos:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Roboto Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(12, 337);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(218, 25);
            this.lblCpf.TabIndex = 31;
            this.lblCpf.Text = "Forma de Pagamento:";
            // 
            // frmComprarIngressos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.txtConfirmaEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbQtdIngressos);
            this.Controls.Add(this.cbFormaPagamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEvent1);
            this.Controls.Add(this.btnComprarIngresso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDetalhesEvento);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComprarIngressos";
            this.Text = "frmComprarIngressos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirmaEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEvent1;
        private System.Windows.Forms.Button btnComprarIngresso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetalhesEvento;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cbQtdIngressos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCpf;
    }
}