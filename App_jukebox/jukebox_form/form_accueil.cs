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
    public partial class form_accueil : Form
    {
        public form_accueil()
        {
            InitializeComponent();
        }

        private void btn_dvd_Click(object sender, EventArgs e)
        {
            form_dvd frm_dvd = new form_dvd();
            frm_dvd.Show();
            this.Hide();
        }

        private void btn_cd_Click(object sender, EventArgs e)
        {
            form_CD frm_cd = new form_CD();
            frm_cd.Show();
            this.Hide();
        }

        private void fermeture_accueil(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
