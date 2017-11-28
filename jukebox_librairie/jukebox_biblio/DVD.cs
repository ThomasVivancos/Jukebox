using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jukebox_biblio
{
    public class DVD : Support
    {

        private string metteurenscene;

        //getteur

        public string GetMetteurenscene()
        {
            return metteurenscene;

        }

        public string GetTitre()
        {
            return titre;
        }
        public string GetDuree()
        {
            return duree;
        }
        public bool GetEnstock()
        {
            return enstock;
        }
        public string GetCommentaire()
        {
            return commentaire;
        }

        public void SetMetteurenscene(string unMetteurenscene)
        {
            this.metteurenscene = unMetteurenscene;
        }
      

        //constructeur
        public DVD(int id, string titre, string duree, bool enstock, string commentaire, string metteurenscene) : base(id, titre, duree, enstock, commentaire)
        {

            this.metteurenscene = metteurenscene;
        }

        //Procédure Afficher Classe DVD
        public override void Afficher()
        {
            Console.WriteLine("DVD ");
            Console.WriteLine("Metteur en scène : " + metteurenscene);
            base.Afficher();
        }
    }
}
