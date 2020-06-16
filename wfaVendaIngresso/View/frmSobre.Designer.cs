namespace wfaVendaIngresso.View
{
    partial class frmSobre
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDetalhesEvento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::wfaVendaIngresso.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(269, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDetalhesEvento
            // 
            this.lblDetalhesEvento.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalhesEvento.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhesEvento.ForeColor = System.Drawing.Color.White;
            this.lblDetalhesEvento.Location = new System.Drawing.Point(100, 494);
            this.lblDetalhesEvento.Name = "lblDetalhesEvento";
            this.lblDetalhesEvento.Size = new System.Drawing.Size(867, 58);
            this.lblDetalhesEvento.TabIndex = 18;
            this.lblDetalhesEvento.Text = "Developed by Matheus Sales and Thales Zago";
            this.lblDetalhesEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BackgroundImage = global::wfaVendaIngresso.Properties.Resources.backgroundAbout;
            this.ClientSize = new System.Drawing.Size(1050, 621);
            this.Controls.Add(this.lblDetalhesEvento);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSobre";
            this.Text = "frmSobre";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDetalhesEvento;
    }
}