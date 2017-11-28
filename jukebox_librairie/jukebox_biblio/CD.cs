using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jukebox_biblio
{
    public class CD : Support
    {

        private string artiste;
        private int nbpiste;
        private string prix;

        //Constructeur
        public CD(int id, string titre, string duree, bool enstock, string artiste, int nbpiste, string prix, string commentaire) : base(id, titre, duree, enstock, commentaire)
        {
            this.artiste = artiste;
            this.prix = prix;
            this.nbpiste = nbpiste;
        }

        public string GetTitre()
        {
            return titre;
        }
        public string GetDuree()
        {
            return duree;
        }
        public string GetArtiste()
        {
            return artiste;
        }
        public bool GetEnstock()
        {
            return enstock;
        }
        public int GetNbpiste()
        {
            return nbpiste;
        }
        public string GetPrix()
        {
            return prix;
        }
        public string GetCommentaire()
        {
            return commentaire;
        }







        //Procédure Affiche()
        public override void Afficher()
        {
            Console.WriteLine("CD ");
            Console.WriteLine("artiste : " + artiste);
            Console.WriteLine("nombre de pistes : " + nbpiste);
            Console.WriteLine("prix : " + prix + " € ");
            base.Afficher();
        }
    }
}
