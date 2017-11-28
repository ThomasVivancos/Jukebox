using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace jukebox_biblio
{
    public class BDD
    {
        private MySqlConnection connection;

        // Constructeur
        public BDD()
        {
            this.InitConnexion();
        }
        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=localhost; DATABASE=jukebox; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        //Operation sur les CD


        public void LoadCd(DataGridView liste_cd, string erreur_msg)
        {

            try
            {
                BDD bdd = new jukebox_biblio.BDD();

                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select cd.id, titre, duree, enstock, artiste, nbpiste, prix, commentaire from cd, support where cd.id = support.id;", bdd.GetConnection());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                liste_cd.DataSource = DS.Tables[0];
                liste_cd.Columns[0].Visible = false;
                liste_cd.Columns["id"].HeaderText = "Id";
                liste_cd.Columns["titre"].HeaderText = "Titre";
                liste_cd.Columns["duree"].HeaderText = "Durée(mins)";
                liste_cd.Columns["enstock"].HeaderText = "En stock";
                liste_cd.Columns["artiste"].HeaderText = "Artiste";
                liste_cd.Columns["nbpiste"].HeaderText = "Nombre de piste";
                liste_cd.Columns["prix"].HeaderText = "Prix (xcfp)";
                liste_cd.Columns["commentaire"].HeaderText = "Commentaire";
                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }

        public void AddCd(CD cd, string erreur_msg)
        {
            try
            {
                BDD bdd = new jukebox_biblio.BDD();
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = bdd.GetConnection().CreateCommand();
                

                // Requête SQL
                cmd.CommandText = "Call ajout_cd(@titre, @duree, @enstock, @commentaire, @artiste, @nbpiste, @prix)";

                // utilisation de l'objet cd passé en paramètre
                cmd.Parameters.AddWithValue("@titre", cd.GetTitre());
                cmd.Parameters.AddWithValue("@duree", cd.GetDuree());
                cmd.Parameters.AddWithValue("@enstock", cd.GetEnstock());
                cmd.Parameters.AddWithValue("@commentaire", cd.GetCommentaire());
                cmd.Parameters.AddWithValue("@artiste", cd.GetArtiste());
                cmd.Parameters.AddWithValue("@nbpiste", cd.GetNbpiste());
                cmd.Parameters.AddWithValue("@prix", cd.GetPrix());

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();


                // Fermeture de la connexion
                bdd.GetConnection().Close();

            }
            catch (Exception ex)
            {
                erreur_msg = ex.Message;
            }
        }

        public void UpdateCd(CD cd, string erreur_msg)
        {
            try
            {
                BDD bdd = new BDD();
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = bdd.GetConnection().CreateCommand();

                // Requête SQL
                cmd.CommandText = "Call Modif_cd(@Id, @titre, @duree, @enstock, @commentaire, @artiste, @nbpiste, @prix)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@Id", cd.GetId());
                cmd.Parameters.AddWithValue("@titre", cd.GetTitre());
                cmd.Parameters.AddWithValue("@duree", cd.GetDuree());
                cmd.Parameters.AddWithValue("@enstock", cd.GetEnstock());
                cmd.Parameters.AddWithValue("@artiste", cd.GetArtiste());
                cmd.Parameters.AddWithValue("@nbpiste", cd.GetNbpiste());
                cmd.Parameters.AddWithValue("@prix", cd.GetPrix());
                cmd.Parameters.AddWithValue("@commentaire", cd.GetCommentaire());

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch (Exception ex)
            {
                erreur_msg = ex.Message;
            }
        }

        public void delete_CD(int id_cd, string erreur_msg)
        {
            try
            {
                BDD bdd = new jukebox_biblio.BDD();
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = bdd.GetConnection().CreateCommand();

                // Requête SQL
                cmd.CommandText = "Call Delete_cd(@Id);";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@Id", id_cd);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch (Exception ex)
            {
                erreur_msg = ex.Message;
            }
        }

        //opération sur les DVD

        public void LoadDVD(DataGridView liste_dvd, string erreur_msg)
        {

            try
            {
                BDD bdd = new jukebox_biblio.BDD();

                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select dvd.id, titre, duree, enstock, metteurenscene, commentaire from dvd, support where dvd.id = support.id;", bdd.GetConnection());
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                liste_dvd.DataSource = DS.Tables[0];
                liste_dvd.Columns[0].Visible = false;
                liste_dvd.Columns["id"].HeaderText = "Id";
                liste_dvd.Columns["titre"].HeaderText = "Titre";
                liste_dvd.Columns["duree"].HeaderText = "Durée(mins)";
                liste_dvd.Columns["enstock"].HeaderText = "En stock";
                liste_dvd.Columns["metteurenscene"].HeaderText = "Metteur en scène";
                liste_dvd.Columns["commentaire"].HeaderText = "Commentaire";
                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }

        public void AddDVD(DVD dvd, string erreur_msg)
        {
            try
            {
                BDD bdd = new jukebox_biblio.BDD();
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = bdd.GetConnection().CreateCommand();

                // Requête SQL
                cmd.CommandText = "Call ajout_dvd(@titre, @duree, @enstock, @commentaire, @metteurenscene);";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@titre", dvd.GetTitre());
                cmd.Parameters.AddWithValue("@duree", dvd.GetDuree());
                cmd.Parameters.AddWithValue("@enstock", dvd.GetEnstock());
                cmd.Parameters.AddWithValue("@metteurenscene", dvd.GetMetteurenscene());
                cmd.Parameters.AddWithValue("@commentaire", dvd.GetCommentaire());

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                bdd.GetConnection().Close();

            }
            catch (Exception ex)
            {
                erreur_msg = ex.Message;
            }
        }

        public void UpdateDVD(DVD dvd, string erreur_msg)
        {
            try
            {
                BDD bdd = new BDD();
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = bdd.GetConnection().CreateCommand();

                // Requête SQL
                cmd.CommandText = "Call Modif_dvd(@Id, @titre, @duree, @enstock, @commentaire, @metteurenscene);";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@Id", dvd.GetId());
                cmd.Parameters.AddWithValue("@titre", dvd.GetTitre());
                cmd.Parameters.AddWithValue("@duree", dvd.GetDuree());
                cmd.Parameters.AddWithValue("@enstock", dvd.GetEnstock());
                cmd.Parameters.AddWithValue("@metteurenscene", dvd.GetMetteurenscene());
                cmd.Parameters.AddWithValue("@commentaire", dvd.GetCommentaire());

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch (Exception ex)
            {
                erreur_msg = ex.Message;
            }
        }

        public void delete_DVD(int id_dvd, string erreur_msg)
        {
            try
            {
                BDD bdd = new jukebox_biblio.BDD();
                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = bdd.GetConnection().CreateCommand();

                // Requête SQL
                cmd.CommandText = "Call delete_dvd(@Id);";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@Id", id_dvd);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch (Exception ex)
            {
                erreur_msg = ex.Message;
            }
        }

        public void listeChambre(ComboBox cb)
        {
            try
            {
                BDD bdd = new jukebox_biblio.BDD();

                // Ouverture de la connexion SQL
                bdd.GetConnection().Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select num_chambre from Chambre;", bdd.GetConnection());
                DataTable DS = new DataTable();
                mySqlDataAdapter.Fill(DS);
                for (int i = 0; i < DS.Rows.Count; i++)
                {
                    cb.Items.Add(DS.Rows[i].ItemArray[0]);
                }
                // Fermeture de la connexion
                bdd.GetConnection().Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }

        public void emprunter(int id_cd, int num_chambre, DateTime date)
        {
            BDD bdd = new jukebox_biblio.BDD();
            // Ouverture de la connexion SQL
            bdd.GetConnection().Open();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = bdd.GetConnection().CreateCommand();


            // Requête SQL
            cmd.CommandText = "Insert into emprunt values('', @date, 0, @numChambre, @Id);";

            cmd.Parameters.AddWithValue("@Id", id_cd);
            cmd.Parameters.AddWithValue("@numChambre", num_chambre);
            cmd.Parameters.AddWithValue("@date", date);


            // Exécution de la commande SQL
            cmd.ExecuteNonQuery();


            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd1 = bdd.GetConnection().CreateCommand();


            // Requête SQL
            cmd1.CommandText = "Update support set enstock = 0 where id = @Id;";

            cmd1.Parameters.AddWithValue("@Id", id_cd);


            // Exécution de la commande SQL
            cmd1.ExecuteNonQuery();

            // Fermeture de la connexion
            bdd.GetConnection().Close();
        }

        public void rendre(int id_cd)
        {
            BDD bdd = new jukebox_biblio.BDD();
            // Ouverture de la connexion SQL
            bdd.GetConnection().Open();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = bdd.GetConnection().CreateCommand();


            // Requête SQL
            cmd.CommandText = "Update support set enstock = 1 where id = @Id; ";

            cmd.Parameters.AddWithValue("@Id", id_cd);


            // Exécution de la commande SQL
            cmd.ExecuteNonQuery();


            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd1 = bdd.GetConnection().CreateCommand();


            // Requête SQL
            cmd1.CommandText = "Call Rendre(@Id);";

            cmd1.Parameters.AddWithValue("@Id", id_cd);


            // Exécution de la commande SQL
            cmd1.ExecuteNonQuery();

            // Fermeture de la connexion
            bdd.GetConnection().Close();
        }



    }
}
