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
    public partial class form_DVD_modif : Form
    {

        int id_dvd;

        public form_DVD_modif(DVD dvd_a_modif)
        {
            InitializeComponent();
            this.id_dvd = dvd_a_modif.GetId();
            this.modif_champ_metteurenscene.Text = dvd_a_modif.GetMetteurenscene();
            this.modif_champ_commentaire.Text = dvd_a_modif.GetCommentaire();
            this.modif_champ_duree.Text = dvd_a_modif.GetDuree();
            this.modif_champ_enstock.Checked = dvd_a_modif.GetEnstock();
            this.modif_champ_titre.Text = dvd_a_modif.GetTitre();
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            BDD bdd = new BDD();
            string erreur_msg = null;
            DVD dvd_modifie = new DVD(
                id_dvd,
                modif_champ_titre.Text,
                modif_champ_duree.Text,
                modif_champ_enstock.Checked,
                modif_champ_metteurenscene.Text,
                modif_champ_commentaire.Text
            );
            bdd.UpdateDVD(dvd_modifie, erreur_msg);
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

        private void fermeture(object sender, FormClosedEventArgs e)
        {
            form_dvd frm_dvd = new form_dvd();
            frm_dvd.Show();
        }
    }
}
