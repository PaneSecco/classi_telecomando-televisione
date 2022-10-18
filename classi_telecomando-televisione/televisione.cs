using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classi_telecomando_televisione
{
    internal class televisione
    {
        //mutabili
        private int canale = 0;
        private int volume = 0;
        private bool stato = false;

        public televisione()
        {

        }
        public void setcanale(int cambio)
        {
            canale = cambio;
        }
        public int getcanale()
        {
            return canale;
        }
        public void cambio_stato()
        {
            if (stato == false)
            {
                stato = true;
            }
            else
            {
                stato = false;
            }
        }
        public bool get_stato()
        {
            return stato;
        }
        public void volume_su()
        {
            volume = volume + 1;
        }
        public void volume_giu()
        {
            volume = volume - 1;
        }

        public int get_volume()
        {
            return volume;
        }

    }
}
