using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jukebox_biblio
{
    public class Chambre
    {
        private int numero;
        private float prix;
        private string etat;

        //Constructeur

        public void chambre(int numero, float prix, string etat)
        {
            this.numero = numero;
            this.prix = prix;
            this.etat = etat;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public float getPrix()
        {
            return this.prix;
        }

        public string getEtat()
        {
            return this.etat;
        }

    }
}
