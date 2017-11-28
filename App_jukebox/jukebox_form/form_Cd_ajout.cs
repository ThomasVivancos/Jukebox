using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jukebox_biblio;

namespace jukebox_form
{
    public partial class form_Cd_ajout : Form
    {
        public form_Cd_ajout()
        {
            InitializeComponent();
        }

        BDD bdd = new BDD();


        private void btn_ajout_Click(object sender, EventArgs e)
        {
            //Déclaration des variables
            string erreur_msg = null;
            string titre = ajout_champ_titre.Text;
            string duree = ajout_champ_duree.Value.ToString();
            bool enstock = false;

            if (ajout_champ_enstock.Checked)
            {
                enstock = true;
            }
            string artiste = ajout_champ_artiste.Text;
            int nbpiste = Convert.ToInt16(ajout_champ_nbpiste.Value);
            string prix = ajout_champ_prix.Value.ToString(); ;
            string commentaire = ajout_champ_commentaire.Text;


            //Nous ajoutons notre nouveau cd
            CD cd = new CD(0, titre, duree, enstock, artiste, nbpiste, prix, commentaire);
            //Je rajoute le cd à la classe bdd afin de le stocker dans la base de données MySql
            bdd.AddCd(cd, erreur_msg);
            if (erreur_msg != null)
            {
                MessageBox.Show(erreur_msg);
            }
            else
            {

                form_CD frm_cd = new form_CD();
                frm_cd.Show();
                this.Hide();
            }
        }

        private void Fermeture_form_cd_ajout(Object sender, FormClosingEventArgs e)
        {
            form_CD frm_cd = new form_CD();
            frm_cd.Show();
        }
    }
}
