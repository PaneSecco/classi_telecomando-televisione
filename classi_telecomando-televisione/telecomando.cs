using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classi_telecomando_televisione
{
    internal class telecomando
    {
        televisione tv = new televisione();

        //immutabili
        private string produttore;
        private string modello;
        private string modalita;

        public telecomando()
        {

        }

        public void setcanale(int cambio)
        {
            tv.setcanale(cambio);
        }

        public int getcanale()
        {
            return tv.getcanale();
        }

        public void cambio_stato()
        {
            tv.cambio_stato();
        }

        public bool get_stato()
        {
            return tv.get_stato();
        }

        public void volume_su()
        {
            tv.volume_su();
        }
        public void volume_giu()
        {
            tv.volume_giu();
        }

        public int get_volume()
        {
            return tv.get_volume();
        }
        public void set_specifiche(string produttore1, string modello1, string modalita1)
        {
            produttore = produttore1;
            modello = modello1;
            modalita = modalita1;
        }
        public string[] get_specifiche()
        {
            string[] array = { produttore, modello, modalita };
            return array;
        }
    }
}
