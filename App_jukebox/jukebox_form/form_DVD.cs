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
    public partial class form_dvd : Form
    {
        private BDD bdd = new BDD();
        public form_dvd()
        {
            InitializeComponent();
            form_dvd_Load();
        }

        private void form_dvd_Load()
        {
            string erreur_msg = null;
            this.bdd.LoadDVD(liste_dvd, erreur_msg);
            if (erreur_msg != null)
            {
                MessageBox.Show(erreur_msg);
            }
        }

        private void btn_ajout_dvd_Click(object sender, EventArgs e)
        {
            form_DVD_ajout ajoutdvd = new form_DVD_ajout();
            ajoutdvd.Show();
            this.Hide();
        }

        private void btn_modif_dvd_Click(object sender, EventArgs e)
        {
            DVD DVD_a_modif = new DVD(
            Convert.ToInt16(liste_dvd.CurrentRow.Cells["id"].Value),
            liste_dvd.CurrentRow.Cells["titre"].Value.ToString(),
            liste_dvd.CurrentRow.Cells["duree"].Value.ToString(),
            Convert.ToBoolean(liste_dvd.CurrentRow.Cells["enstock"].Value.ToString()),
            liste_dvd.CurrentRow.Cells["commentaire"].Value.ToString(),
            liste_dvd.CurrentRow.Cells["metteurenscene"].Value.ToString()
            );

            form_DVD_modif modifier_DVD = new form_DVD_modif(DVD_a_modif);
            modifier_DVD.Show();
            this.Hide();
        }

        private void btn_supp_dvd_Click(object sender, EventArgs e)
        {
            int id_dvd = Convert.ToInt16(liste_dvd.CurrentRow.Cells["id"].Value);
            string erreur_msg = null;
            this.bdd.delete_DVD(id_dvd, erreur_msg);
            if (erreur_msg != null)
            {
                MessageBox.Show(erreur_msg);
            }
            else
            {
                this.form_dvd_Load();
            }
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            form_accueil form_menu = new form_accueil();
            form_menu.Show();
            this.Hide();
        }

        private void fermeture(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
