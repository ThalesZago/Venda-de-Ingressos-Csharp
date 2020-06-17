using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaVendaIngresso.Classes;
using wfaVendaIngresso.Dao;

namespace wfaVendaIngresso.View
{

    public partial class frmMeusEventos : Form
    {
        List<Evento> eventos = new List<Evento>();
        
        public frmMeusEventos()
        {
            InitializeComponent();
            carregarEventos();
        }

        
        public void carregarEventos()
        {
            this.Controls.Clear();
            EventoDAO dao = new EventoDAO();

            eventos = dao.getMeusEventos(View.frmLogin.pessoa.cpf);

            LastPosition lastPosition = new LastPosition(80, 25, 3, 169, 3, 138, -7, 4, -7, 210);

            foreach (Evento evt in eventos)
            {
                Panel panel = new Panel();
                panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                panel.Location = new System.Drawing.Point(lastPosition.panelPositionHor, lastPosition.panelPositionVer);
                panel.Name = "panelEvento " + evt.id;
                panel.Size = new System.Drawing.Size(270, 245);
                panel.TabIndex = 10;
                panel.Click += new EventHandler(panel_Click);
                this.Controls.Add(panel);

                Label lblNomeEvento = new Label();
                lblNomeEvento.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblNomeEvento.ForeColor = System.Drawing.Color.Black;
                lblNomeEvento.Location = new System.Drawing.Point(lastPosition.lblNomeEventoPositionHor, lastPosition.lblNomeEventoPositionVer);
                lblNomeEvento.Name = "lblNomeEvento " + evt.id;
                lblNomeEvento.Size = new System.Drawing.Size(262, 31);
                lblNomeEvento.TabIndex = 1;
                lblNomeEvento.Text = evt.nome;
                lblNomeEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblNomeEvento.Click += new EventHandler(panel_Click);
                panel.Controls.Add(lblNomeEvento);

                Label lblDataEvento = new Label();
                lblDataEvento.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblDataEvento.ForeColor = System.Drawing.Color.SandyBrown;
                lblDataEvento.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
                lblDataEvento.Location = new System.Drawing.Point(lastPosition.lblDataEventoPositionHor, lastPosition.lblDataEventoPositionVer);
                lblDataEvento.Name = "lblDataEvento " + evt.id;
                lblDataEvento.Size = new System.Drawing.Size(144, 31);
                lblDataEvento.TabIndex = 1;
                lblDataEvento.Text = evt.dataHora.ToString();
                lblDataEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblDataEvento.Click += new EventHandler(panel_Click);
                panel.Controls.Add(lblDataEvento);

                Button btnShowEvento = new Button();
                btnShowEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(86)))), ((int)(((byte)(247)))));
                btnShowEvento.FlatAppearance.BorderColor = System.Drawing.Color.White;
                btnShowEvento.FlatAppearance.BorderSize = 0;
                btnShowEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnShowEvento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnShowEvento.ForeColor = System.Drawing.Color.White;
                btnShowEvento.Location = new System.Drawing.Point(lastPosition.btnShowEventPositionHor, lastPosition.btnShowEventPositionVer);
                btnShowEvento.Name = "btnShowEvento " + evt.id;
                btnShowEvento.Size = new System.Drawing.Size(283, 35);
                btnShowEvento.TabIndex = 6;
                btnShowEvento.Text = "Detalhes";
                btnShowEvento.UseVisualStyleBackColor = false;
                btnShowEvento.Click += new EventHandler(panel_Click);
                panel.Controls.Add(btnShowEvento);

                PictureBox pictureEvento = new PictureBox();
                if (evt.imgEvent == null)
                {
                    pictureEvento.Image = Properties.Resources.apolloCadastroOficial;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(evt.imgEvent);
                    pictureEvento.Image = System.Drawing.Image.FromStream(mstream);
                }
                pictureEvento.Location = new System.Drawing.Point(lastPosition.pictureEventoPositionHor, lastPosition.pictureEventoPositionVer);
                pictureEvento.Name = "pictureBoxEvento " + evt.id;
                pictureEvento.Size = new System.Drawing.Size(283, 135);
                pictureEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                pictureEvento.TabIndex = 0;
                pictureEvento.TabStop = false;
                pictureEvento.Click += new EventHandler(panel_Click);
                panel.Controls.Add(pictureEvento);

                int newPanelPositionHor = 0;
                int newPanelPositionVer = 0;

                if (lastPosition.panelPositionHor > 380)
                {
                    newPanelPositionHor = 80;
                    newPanelPositionVer = lastPosition.panelPositionVer + 265;
                }
                else
                {
                    newPanelPositionHor = lastPosition.panelPositionHor + 300;
                    newPanelPositionVer = lastPosition.panelPositionVer;
                }

                lastPosition = new LastPosition(newPanelPositionHor, newPanelPositionVer,
                                                lastPosition.lblNomeEventoPositionHor, lastPosition.lblNomeEventoPositionVer,
                                                lastPosition.lblDataEventoPositionHor, lastPosition.lblDataEventoPositionVer,
                                                lastPosition.pictureEventoPositionHor, lastPosition.pictureEventoPositionVer,
                                                lastPosition.btnShowEventPositionHor, lastPosition.btnShowEventPositionVer);
            }

        }

        public class LastPosition
        {
            public int panelPositionHor;
            public int panelPositionVer;
            public int lblNomeEventoPositionHor;
            public int lblNomeEventoPositionVer;
            public int lblDataEventoPositionHor;
            public int lblDataEventoPositionVer;
            public int pictureEventoPositionHor;
            public int pictureEventoPositionVer;
            public int btnShowEventPositionHor;
            public int btnShowEventPositionVer;

            public LastPosition(int panelPositionHor, int panelPositionVer, int lblNomeEventoPositionHor, int lblNomeEventoPositionVer, int lblDataEventoPositionHor, int lblDataEventoPositionVer, int pictureEventoPositionHor, int pictureEventoPositionVer, int btnShowEventPositionHor, int btnShowEventPositionVer)
            {
                this.panelPositionHor = panelPositionHor;
                this.panelPositionVer = panelPositionVer;
                this.lblNomeEventoPositionHor = lblNomeEventoPositionHor;
                this.lblNomeEventoPositionVer = lblNomeEventoPositionVer;
                this.lblDataEventoPositionHor = lblDataEventoPositionHor;
                this.lblDataEventoPositionVer = lblDataEventoPositionVer;
                this.pictureEventoPositionHor = pictureEventoPositionHor;
                this.pictureEventoPositionVer = pictureEventoPositionVer;
                this.btnShowEventPositionHor = btnShowEventPositionHor;
                this.btnShowEventPositionVer = btnShowEventPositionVer;
            }
        }

        private void panel_Click(object sender, System.EventArgs e)
        {
            var t = (dynamic)sender;
            int idEvento = int.Parse(t.Name.Split(' ')[1]);

            foreach (Evento ev in eventos)
            {
                if (ev.id == idEvento)
                {
                    frmEditarEventos editaEventos = new frmEditarEventos(ev);
                    editaEventos.loadEventos += carregarEventos;
                    editaEventos.ShowDialog();
                    
                    
                }
            }
        }

        
    }
}
