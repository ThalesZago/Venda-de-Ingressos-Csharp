using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaVendaIngresso.Classes;

namespace wfaVendaIngresso
{
    public partial class frmHome : Form
    {
        List<Evento> eventos = new List<Evento>();

        public frmHome()
        {
            InitializeComponent();
            carregarEventos();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            tmrHora.Start();
        }

        private void lblDataHora_Click(object sender, EventArgs e)
        {

        }

        private void carregarEventos()
        {
            for (int i = 0; i < 10; i++)
            {
                EventoEletronica evt = new EventoEletronica();
                evt.endereco = "Rua XX";
                evt.nome = "EletroHouse" + i;
                evt.dataHora = DateTime.Now;

                eventos.Add(evt);
            }

            LastPosition lastPosition = new LastPosition(80, 25, 3, 169, 3, 138, -7, 4);

            foreach (Evento evt in eventos)
            {
                Panel panel = new Panel();
                panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                panel.Location = new System.Drawing.Point(lastPosition.panelPositionHor, lastPosition.panelPositionVer);
                panel.Name = "panelEvento"+evt.nome;
                panel.Size = new System.Drawing.Size(270, 245);
                panel.TabIndex = 10;
                panel.Click += new EventHandler(panel_Click);
                this.Controls.Add(panel);

                Label lblNomeEvento = new Label();
                lblNomeEvento.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblNomeEvento.ForeColor = System.Drawing.Color.Black;
                lblNomeEvento.Location = new System.Drawing.Point(lastPosition.lblNomeEventoPositionHor, lastPosition.lblNomeEventoPositionVer);
                lblNomeEvento.Name = "lblNomeEvento" + evt.nome;
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
                lblDataEvento.Name = "lblDataEvento" + evt.nome;
                lblDataEvento.Size = new System.Drawing.Size(144, 31);
                lblDataEvento.TabIndex = 1;
                lblDataEvento.Text = evt.dataHora.ToString();
                lblDataEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                lblDataEvento.Click += new EventHandler(panel_Click);
                panel.Controls.Add(lblDataEvento);

                PictureBox pictureEvento = new PictureBox();
                pictureEvento.Image = global::wfaVendaIngresso.Properties.Resources.eventoFoto;
                pictureEvento.Location = new System.Drawing.Point(lastPosition.pictureEventoPositionHor, lastPosition.pictureEventoPositionVer);
                pictureEvento.Name = "pictureBoxEvento"+evt.nome;
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
                                                lastPosition.pictureEventoPositionHor, lastPosition.pictureEventoPositionVer);
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

            public LastPosition(int panelPositionHor, int panelPositionVer, int lblNomeEventoPositionHor, int lblNomeEventoPositionVer, int lblDataEventoPositionHor, int lblDataEventoPositionVer, int pictureEventoPositionHor, int pictureEventoPositionVer)
            {
                this.panelPositionHor = panelPositionHor;
                this.panelPositionVer = panelPositionVer;
                this.lblNomeEventoPositionHor = lblNomeEventoPositionHor;
                this.lblNomeEventoPositionVer = lblNomeEventoPositionVer;
                this.lblDataEventoPositionHor = lblDataEventoPositionHor;
                this.lblDataEventoPositionVer = lblDataEventoPositionVer;
                this.pictureEventoPositionHor = pictureEventoPositionHor;
                this.pictureEventoPositionVer = pictureEventoPositionVer;
            }
        }

        private void panel_Click(object sender, System.EventArgs e)
        {
            var t = (dynamic)sender;

            MessageBox.Show("Voce clicou no componente " + t.Name);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
