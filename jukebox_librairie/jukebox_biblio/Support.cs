using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jukebox_biblio
{
    public class Support
    {
        private int id;
        public string titre;
        public string duree;
        public bool enstock;
        public string commentaire;

        public int GetId()
        {
            return this.id;
        }

        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }

        public string Duree
        {
            get
            {
                return duree;
            }

            set
            {
                duree = value;
            }
        }

        public bool Enstock
        {
            get
            {
                return enstock;
            }

            set
            {
                enstock = value;
            }
        }

        public string Commentaire
        {
            get
            {
                return commentaire;
            }

            set
            {
                commentaire = value;
            }
        }

        //accesseurs Classe Support










        //constructeur Classe Support
        public Support(int id, string titre, string duree, bool enstock, string commentaire)
        {
            this.id = id;
            this.Titre = titre;
            this.Duree = duree;
            this.Enstock = enstock;
            this.Commentaire = commentaire;
        }

        //Procédure Afficher Classe Support
        public virtual void Afficher()
        {
            Console.WriteLine("titre : " + Titre + " (" + Duree + " mn)");
            Console.WriteLine(Commentaire);
            if (Enstock)
            {
                Console.WriteLine("en stock");
            }
            else
            {
                Console.WriteLine("non disponible");
            }

        }
    }
}
