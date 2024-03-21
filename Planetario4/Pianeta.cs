using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario4
{
    internal class Pianeta
    {
        public Vector Velocita { get; set; }
        public double Massa { get; set; }
        public Vector Posizione { get; set; }
        public Vector ForzaApplicata { get; set; }
        public Vector Accelerazione { get; set; }
        public double G { get; set; } = 6.67;
        public double Tempo { get; set; }
        public Color Colore { get; set; }

        public Pianeta(Vector velocita, double massa, Vector posizione)
        {
            Velocita = velocita;
            Massa = massa;
            Posizione = posizione;
        }

        public void DisegnaPianeta(Graphics g)
        {
            float raggio = (float)Math.Sqrt(Massa);
            float x = (float)Posizione.X - (raggio / 2);
            float y = (float)Posizione.Y - (raggio / 2);
            g.FillEllipse(new SolidBrush(Colore), x, y, raggio, raggio);
        }

        public override string ToString()
        {
            return $"{Velocita}; {Posizione}; {Massa}";
        }
    }
}
