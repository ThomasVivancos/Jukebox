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
    public partial class form_CD_modif : Form
    {

        int id_cd;

        public form_CD_modif(CD cd_a_modif)
        {
            InitializeComponent();
            this.id_cd = cd_a_modif.GetId();
            this.modif_champ_artiste.Text = cd_a_modif.GetArtiste();
            this.modif_champ_commentaire.Text = cd_a_modif.GetCommentaire();
            this.modif_champ_duree.Text = cd_a_modif.GetDuree();
            this.modif_champ_enstock.Checked = cd_a_modif.GetEnstock();
            this.modif_champ_nbpiste.Text = cd_a_modif.GetNbpiste().ToString();
            this.modif_champ_prix.Text = cd_a_modif.GetPrix();
            this.modif_champ_titre.Text = cd_a_modif.GetTitre();
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            BDD bdd = new BDD();
            string erreur_msg = null;
            CD cd_modifie = new CD(
                id_cd,
                modif_champ_titre.Text,
                modif_champ_duree.Text,
                modif_champ_enstock.Checked,
                modif_champ_artiste.Text,
                Convert.ToInt16(modif_champ_nbpiste.Text),
                modif_champ_prix.Text,
                modif_champ_commentaire.Text
            );
            bdd.UpdateCd(cd_modifie, erreur_msg);
            if (erreur_msg != null)
            {
                MessageBox.Show(erreur_msg);
            }else
            {
                form_CD frm_cd = new form_CD();
                frm_cd.Show();
                this.Hide();
            }
            }

        private void fermeture_form_cd_modif(object sender, FormClosingEventArgs e)
        {
            form_CD frm_cd = new form_CD();
            frm_cd.Show();
        }
    }
    }

