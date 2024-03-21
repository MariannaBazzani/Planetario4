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

namespace Planetario4
{
    public partial class Form1 : Form
    {
        Graphics g;

        readonly Timer timer = new Timer();

        readonly Planetario planetario = new Planetario();
        readonly Vector vectorInstance = new Vector();
        readonly Color colorTrasparent = new SolidBrush(Color.FromArgb(0, Color.Black)).Color;

        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            BackColor = Color.Black;
            this.Paint += new PaintEventHandler(Form1_Paint);

            timer.Tick += new EventHandler(tiktak_Tick);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            DrawPlanets();
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void DrawPlanets()
        {
            foreach (var pianeta in planetario.Pianeti)
            {
                pianeta.DisegnaPianeta(g);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox()) return;

            Pianeta p = new Pianeta(Vector.Parse(txtVelocita.Text), double.Parse(txtMassa.Text), Vector.Parse(txtPosizione.Text));
            p.Colore = GetColor();

            lstPianeti.Items.Add(p);
            planetario.Pianeti.Add(p);

            txtVelocita.Clear();
            txtPosizione.Clear();
            txtMassa.Clear();
            txtNome.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstPianeti.SelectedIndex == -1)
            {
                MessageBox.Show("Nessun elemento è stato selezionato");
            }
            else
            {
                lstPianeti.Items.RemoveAt(lstPianeti.SelectedIndex);
                planetario.Pianeti.RemoveAt(lstPianeti.SelectedIndex);
            }
        }

        private bool CheckTextBox()
        {
            if (!vectorInstance.TryParse(txtVelocita.Text, out Vector velocita))
            {
                MessageBox.Show("La velocità inserita non corrisponde a un vettore");
                return false;
            }
            if (!vectorInstance.TryParse(txtPosizione.Text, out Vector posizione))
            {
                MessageBox.Show("La posizione inserita non corrisponde a un vettore");
                return false;
            }
            if (!double.TryParse(txtMassa.Text, out var massa))
            {
                MessageBox.Show("La massa inserita non è un numero");
                return false;
            }
            return true;
        }

        private Color GetColor()
        {
            switch (txtNome.Text)
            {
                case "Sole":
                    return Color.Gold;
                case "Mercurio":
                    return Color.DarkGray;
                case "Venere":
                    return Color.Peru;
                case "Terra":
                    return Color.CornflowerBlue;
                case "Marte":
                    return Color.Coral;
                case "Giove":
                    return Color.DarkGoldenrod;
                case "Saturno":
                    return Color.Tan;
                case "Urano":
                    return Color.SkyBlue;
                case "Nettuno":
                    return Color.DodgerBlue;
                default:
                    return Color.White;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstPianeti.Items.Count == 0)
            {
                MessageBox.Show("Nessun elemento è presente nella lista");
            }
            else
            {
                lstPianeti.Items.Clear();
                planetario.Pianeti.RemoveRange(0, planetario.Pianeti.Count - 1);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();

            string imagePath = Path.Combine(Application.StartupPath, "..\\..\\..\\background.jpg");
            this.BackgroundImage = Image.FromFile(imagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void tiktak_Tick(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            planetario.Traiettoria(timer.Interval / 1000);
            Refresh();
            DrawPlanets();
        }
    }
}
