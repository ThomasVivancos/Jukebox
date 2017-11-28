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
    public partial class form_DVD_ajout : Form
    {
        public form_DVD_ajout()
        {
            InitializeComponent();
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            //Déclaration des variables
            BDD bdd = new BDD();
            string erreur_msg = null;
            string titre = ajout_champ_titre.Text;
            string duree = ajout_champ_duree.Text;
            bool enstock = false;

            if (ajout_champ_enstock.Checked)
            {
                enstock = true;
            }
            string metteurenscene = ajout_champ_metteurenscene.Text;
            string commentaire = ajout_champ_commentaire.Text;


            //Nous ajoutons notre nouveau dvd
            DVD dvd = new DVD(0, titre, duree, enstock, commentaire, metteurenscene);
            //Je rajoute le dvd à la classe bdd afin de le stocker dans la base de données MySql
            bdd.AddDVD(dvd, erreur_msg);
            if (erreur_msg != null)
            {
                MessageBox.Show(erreur_msg);
            }
            else
            {

                form_dvd frm_dvd = new form_dvd();
                frm_dvd.Show();
                this.Hide();
            }
        }

        private void fermeture(object sender, FormClosingEventArgs e)
        {
            form_dvd frm_dvd = new form_dvd();
            frm_dvd.Show();
        }
    }
}
