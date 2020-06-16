namespace wfaVendaIngresso.View
{
    partial class frmPrincipalUser
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
            this.menuVertical = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.frmPrincipal = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.barraVertical = new System.Windows.Forms.Panel();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnMeusIngressos = new System.Windows.Forms.Button();
            this.btnMinhaConta = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.menuVertical.SuspendLayout();
            this.frmPrincipal.SuspendLayout();
            this.barraVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(24)))), ((int)(((byte)(116)))));
            this.menuVertical.Controls.Add(this.btnSobre);
            this.menuVertical.Controls.Add(this.btnMeusIngressos);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Controls.Add(this.btnMinhaConta);
            this.menuVertical.Controls.Add(this.btnHome);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(253, 650);
            this.menuVertical.TabIndex = 7;
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(253, 63);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1050, 587);
            this.panelContainer.TabIndex = 9;
            // 
            // frmPrincipal
            // 
            this.frmPrincipal.AutoScroll = true;
            this.frmPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.frmPrincipal.Controls.Add(this.panelContainer);
            this.frmPrincipal.Controls.Add(this.barraVertical);
            this.frmPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.frmPrincipal.Name = "frmPrincipal";
            this.frmPrincipal.Size = new System.Drawing.Size(1300, 650);
            this.frmPrincipal.TabIndex = 8;
            this.frmPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraVertical_MouseDown);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(0, 62);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1059, 588);
            this.pnlContainer.TabIndex = 11;
            // 
            // barraVertical
            // 
            this.barraVertical.BackColor = System.Drawing.Color.Transparent;
            this.barraVertical.BackgroundImage = global::wfaVendaIngresso.Properties.Resources.account_circle_white_192x192;
            this.barraVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barraVertical.Controls.Add(this.btnMinimizar);
            this.barraVertical.Controls.Add(this.pnlContainer);
            this.barraVertical.Controls.Add(this.btnFechar);
            this.barraVertical.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraVertical.Location = new System.Drawing.Point(0, 0);
            this.barraVertical.Name = "barraVertical";
            this.barraVertical.Size = new System.Drawing.Size(1300, 66);
            this.barraVertical.TabIndex = 10;
            this.barraVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraVertical_MouseDown);
            // 
            // btnSobre
            // 
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(3, 246);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(250, 40);
            this.btnSobre.TabIndex = 1;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnMeusIngressos
            // 
            this.btnMeusIngressos.FlatAppearance.BorderSize = 0;
            this.btnMeusIngressos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMeusIngressos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeusIngressos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeusIngressos.ForeColor = System.Drawing.Color.White;
            this.btnMeusIngressos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeusIngressos.Location = new System.Drawing.Point(3, 203);
            this.btnMeusIngressos.Name = "btnMeusIngressos";
            this.btnMeusIngressos.Size = new System.Drawing.Size(250, 40);
            this.btnMeusIngressos.TabIndex = 1;
            this.btnMeusIngressos.Text = "Meus Ingressos";
            this.btnMeusIngressos.UseVisualStyleBackColor = true;
            this.btnMeusIngressos.Click += new System.EventHandler(this.btnMeusIngressos_Click);
            // 
            // btnMinhaConta
            // 
            this.btnMinhaConta.FlatAppearance.BorderSize = 0;
            this.btnMinhaConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMinhaConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinhaConta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinhaConta.ForeColor = System.Drawing.Color.White;
            this.btnMinhaConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinhaConta.Location = new System.Drawing.Point(3, 160);
            this.btnMinhaConta.Name = "btnMinhaConta";
            this.btnMinhaConta.Size = new System.Drawing.Size(250, 40);
            this.btnMinhaConta.TabIndex = 1;
            this.btnMinhaConta.Text = "Minha Conta";
            this.btnMinhaConta.UseVisualStyleBackColor = true;
            this.btnMinhaConta.Click += new System.EventHandler(this.btnMinhaConta_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 117);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(250, 40);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::wfaVendaIngresso.Properties.Resources.logo_horizontal;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::wfaVendaIngresso.Properties.Resources.icon_minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1228, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::wfaVendaIngresso.Properties.Resources.icon_cerrar2;
            this.btnFechar.Location = new System.Drawing.Point(1269, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(20, 20);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 1;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmPrincipalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.frmPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipalUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipalUser";
            this.menuVertical.ResumeLayout(false);
            this.frmPrincipal.ResumeLayout(false);
            this.barraVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnMeusIngressos;
        private System.Windows.Forms.Button btnMinhaConta;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel frmPrincipal;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel barraVertical;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel pnlContainer;
    }
}