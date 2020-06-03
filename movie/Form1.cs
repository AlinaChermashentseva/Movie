using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_6__Animation_
{
  public partial class MainForm : Form
    {
        Graphics g;
        Random rand;
        Bitmap bitmp;
        int[] coordinateX = new int[986]; // смещение по Х
        int[] coordinateY = new int[564]; // смещение по Y

        Planet Mercury = new Planet(60, 493-7, 282 - 7);
        Planet Venus = new Planet(90, 493 - 10, 282 - 10);
        Planet Earth = new Planet(120, 493 - 12, 282 - 12);
        Planet Mars = new Planet(147, 493 - 7, 282 - 7);
        Planet Jupiter = new Planet(200, 493 - 22, 282 - 22);
        Planet Saturn = new Planet(250, 493 - 20, 282 - 20);
        Planet Uranus = new Planet(295, 493 - 17, 282 - 17);
        Planet Neptune = new Planet(350, 493 - 18, 282 - 18);
        Planet Pluto = new Planet(390, 493 - 6, 282 - 6);

        public MainForm()
        {
            rand = new Random((int)DateTime.Now.Ticks);
            InitializeComponent();
            bitmp = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
            g = Graphics.FromImage(bitmp);

            for (int i = 0; i < 564; i++)
            {
                coordinateX[i] = rand.Next(986);
                coordinateY[i] = rand.Next(564);
            }
        }

        private void DrawStars(Bitmap bitmp, int coordinateX, int coordinateY)
        {
            g.FillEllipse(Brushes.White, MainPictureBox.Width - coordinateX, MainPictureBox.Height - coordinateY, 2, 2);           
            MainPictureBox.Image = bitmp;
        }

        private void DrawPlanet(Bitmap bitmp)
        {
            g.FillEllipse(Brushes.Yellow, (MainPictureBox.Width/2)-40, (MainPictureBox.Height / 2) - 40, 80, 80);
            g.FillEllipse(Brushes.Peru, Mercury.x, Mercury.y, 14, 14);
            g.FillEllipse(Brushes.BurlyWood, Venus.x, Venus.y, 20, 20);
            g.FillEllipse(Brushes.DodgerBlue, Earth.x, Earth.y, 24, 24);
            g.FillEllipse(Brushes.Red, Mars.x, Mars.y, 14, 14);
            g.FillEllipse(Brushes.Orange, Jupiter.x, Jupiter.y, 44, 44);
            g.FillEllipse(Brushes.Khaki, Saturn.x, Saturn.y, 40, 40);
            g.FillEllipse(Brushes.LightSkyBlue, Uranus.x, Uranus.y, 34, 34);
            g.FillEllipse(Brushes.SteelBlue, Neptune.x, Neptune.y, 36, 36);
            g.FillEllipse(Brushes.Brown, Pluto.x, Pluto.y, 12, 12);
            MainPictureBox.Image = bitmp;
        }

        private void AnimationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AnimationCheckBox.Checked)
            {
                MercuryTimer.Enabled = true;
                VenusTimer.Enabled = true;
                EarthTimer.Enabled = true;
                MarsTimer.Enabled = true;
                JupiterTimer.Enabled = true;
                SaturnTimer.Enabled = true;
                UranusTimer.Enabled = true;
                NeptuneTimer.Enabled = true;
                PlutoTimer.Enabled = true;
            }
            else
            {
                MercuryTimer.Enabled = false;
                VenusTimer.Enabled = false;
                EarthTimer.Enabled = false;
                MarsTimer.Enabled = false;
                JupiterTimer.Enabled = false;
                SaturnTimer.Enabled = false;
                UranusTimer.Enabled = false;
                NeptuneTimer.Enabled = false;
                PlutoTimer.Enabled = false;
            }
        }

        private void MercuryTimer_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.Black);

            for (int i = 0; i < 500; i++)
                DrawStars(bitmp, coordinateX[i], coordinateY[i]);

            DrawPlanet(bitmp);

            Mercury.Draw();
        }

        private void VenusTimer_Tick(object sender, EventArgs e)
        {
            Venus.Draw();
        }

        private void EarthTimer_Tick(object sender, EventArgs e)
        {
            Earth.Draw();
        }

        private void MarsTimer_Tick(object sender, EventArgs e)
        {
            Mars.Draw();
        }

        private void JupiterTimer_Tick(object sender, EventArgs e)
        {
            Jupiter.Draw();
        }

        private void SaturnTimer_Tick(object sender, EventArgs e)
        {
            Saturn.Draw();
        }

        private void UranusTimer_Tick(object sender, EventArgs e)
        {
            Uranus.Draw();
        }

        private void NeptuneTimer_Tick(object sender, EventArgs e)
        {
            Neptune.Draw();
        }

        private void PlutoTimer_Tick(object sender, EventArgs e)
        {
            Pluto.Draw();
        }

    }
    public class Planet
    {
        public int r;  //радиус
        public int x0;
        public int y0;
        public float x = 0, y = 0;
        public double fi = 0.0;
        public Planet(int rad, int x00, int y00) { r = rad; x0 = x00; y0 = y00; }
        public void Draw()
        {
            fi += 0.01;
            if (fi > 2 * Math.PI) fi = 0.0;
            x = (float)(r * Math.Cos(fi) + x0);
            y = (float)(r * Math.Sin(fi) + y0);
        }
    }
}
