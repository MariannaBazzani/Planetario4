using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario4
{
    internal class Planetario
    {
        public List<Pianeta> Pianeti { get; set; }

        public Planetario()
        {
            Pianeti = new List<Pianeta>();
        }

        public Vector ForzaGravitazionale(Pianeta pianeta, Pianeta Altro)
        {
            Vector d = Altro.Posizione - pianeta.Posizione;
            double f = pianeta.G * pianeta.Massa * Altro.Massa / d.Modulo() / d.Modulo();
            return f * d.Versore();
        }

        public Vector ForzaTotale(Pianeta pianeta)
        {
            Vector ForzaTot = new Vector(0, 0);
            foreach (Pianeta Altro in Pianeti)
            {
                if (pianeta == Altro) { continue; }

                ForzaTot += ForzaGravitazionale(pianeta, Altro);
            }
            return ForzaTot;
        }

        public void Traiettoria(int interval)
        {
            foreach (Pianeta pianeta in Pianeti)
            {
                pianeta.Accelerazione = ForzaTotale(pianeta) / pianeta.Massa;
                pianeta.Posizione = pianeta.Posizione + pianeta.Velocita * interval + 0.5 * pianeta.Accelerazione * interval * interval;
                pianeta.Velocita = pianeta.Velocita + pianeta.Accelerazione * interval;
            }
        }
    }
}
