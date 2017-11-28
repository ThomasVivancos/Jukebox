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
    public partial class form_CD : Form
    {

        private BDD bdd = new BDD();

        public form_CD()
        {
            InitializeComponent();
            formCD_Load();
        }


        private void formCD_Load()
        {
            string erreur_msg = null;
            this.bdd.LoadCd(liste_cd, erreur_msg);
            if (erreur_msg != null )
            {
                MessageBox.Show(erreur_msg);
            }
        }

        private void btn_ajout_cd_Click(object sender, EventArgs e)
        {
            form_Cd_ajout ajoutcd = new form_Cd_ajout();
            ajoutcd.Show();
            this.Hide();
        }

        private void btn_modif_cd_Click(object sender, EventArgs e)
        {
            CD CD_a_modif = new CD(
            Convert.ToInt16(liste_cd.CurrentRow.Cells["id"].Value),
            liste_cd.CurrentRow.Cells["titre"].Value.ToString(),
            liste_cd.CurrentRow.Cells["duree"].Value.ToString(),
            Convert.ToBoolean(liste_cd.CurrentRow.Cells["enstock"].Value.ToString()),
            liste_cd.CurrentRow.Cells["artiste"].Value.ToString(),
            Convert.ToInt16(liste_cd.CurrentRow.Cells["nbpiste"].Value.ToString()),
            liste_cd.CurrentRow.Cells["prix"].Value.ToString(),
            liste_cd.CurrentRow.Cells["commentaire"].Value.ToString()
            );

            form_CD_modif modifier_CD = new form_CD_modif(CD_a_modif);
            modifier_CD.Show();
            this.Hide();
        }

        private void btn_supp_CD_Click(object sender, EventArgs e)
        {
            int id_cd = Convert.ToInt16(liste_cd.CurrentRow.Cells["id"].Value);
            string erreur_msg = null;
            this.bdd.delete_CD(id_cd, erreur_msg);
            if (erreur_msg != null)
            {
                MessageBox.Show(erreur_msg);
            }else
            {
                this.formCD_Load();
            }
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            form_accueil form_menu = new form_accueil();
            form_menu.Show();
            this.Hide();
        }

        private void fermeture_form_CD(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_emp_CD_Click(object sender, EventArgs e)
        {


            if (liste_cd.CurrentRow.Cells["enstock"].Value.ToString() == "True")
            {
                int id_cd = Convert.ToInt16(liste_cd.CurrentRow.Cells["id"].Value);
                Form_CD_emprunt frm_emp = new Form_CD_emprunt(id_cd);
                frm_emp.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Ce CD est déjà réservé");
            }
            
        }

        private void btn_rendre_CD_Click(object sender, EventArgs e)
        {
            if(liste_cd.CurrentRow.Cells["enstock"].Value.ToString() == "True")
            {
                MessageBox.Show("Ce CD est déjà rendu");
                
            }else
            {
                int id_cd = Convert.ToInt16(liste_cd.CurrentRow.Cells["id"].Value);
                bdd.rendre(id_cd);
                this.formCD_Load();
            }
        }
    }
}
