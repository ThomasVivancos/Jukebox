using jukebox_biblio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jukebox_form
{
    public partial class Form_CD_emprunt : Form
    {

        int id_cd;

        public Form_CD_emprunt(int id_cd)
        {
            InitializeComponent();
            this.id_cd = id_cd;
            BDD bdd = new BDD();
            bdd.listeChambre(comboBox1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            int numChambre = Convert.ToInt16(comboBox1.SelectedItem);
            BDD bdd = new BDD();
            bdd.emprunter(this.id_cd, numChambre, date);

            form_CD frm_cd = new form_CD();
            frm_cd.Show();
            this.Hide();
        }

        private void fermeture_form_emprunt(object sender, FormClosingEventArgs e)
        {
            form_CD frm_cd = new form_CD();
            frm_cd.Show();
        }

    }
}
