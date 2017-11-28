namespace jukebox_form
{
    partial class form_dvd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_retour = new System.Windows.Forms.Button();
            this.btn_supp_dvd = new System.Windows.Forms.Button();
            this.btn_modif_dvd = new System.Windows.Forms.Button();
            this.btn_ajout_dvd = new System.Windows.Forms.Button();
            this.liste_dvd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.liste_dvd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(809, 419);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(121, 32);
            this.btn_retour.TabIndex = 9;
            this.btn_retour.Text = "Retour au menu";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // btn_supp_dvd
            // 
            this.btn_supp_dvd.Location = new System.Drawing.Point(497, 419);
            this.btn_supp_dvd.Name = "btn_supp_dvd";
            this.btn_supp_dvd.Size = new System.Drawing.Size(112, 43);
            this.btn_supp_dvd.TabIndex = 8;
            this.btn_supp_dvd.Text = "Supprimer le DVD";
            this.btn_supp_dvd.UseVisualStyleBackColor = true;
            this.btn_supp_dvd.Click += new System.EventHandler(this.btn_supp_dvd_Click);
            // 
            // btn_modif_dvd
            // 
            this.btn_modif_dvd.Location = new System.Drawing.Point(295, 419);
            this.btn_modif_dvd.Name = "btn_modif_dvd";
            this.btn_modif_dvd.Size = new System.Drawing.Size(117, 43);
            this.btn_modif_dvd.TabIndex = 7;
            this.btn_modif_dvd.Text = "Modifier le DVD";
            this.btn_modif_dvd.UseVisualStyleBackColor = true;
            this.btn_modif_dvd.Click += new System.EventHandler(this.btn_modif_dvd_Click);
            // 
            // btn_ajout_dvd
            // 
            this.btn_ajout_dvd.Location = new System.Drawing.Point(120, 419);
            this.btn_ajout_dvd.Name = "btn_ajout_dvd";
            this.btn_ajout_dvd.Size = new System.Drawing.Size(117, 43);
            this.btn_ajout_dvd.TabIndex = 6;
            this.btn_ajout_dvd.Text = "Ajouter un nouveau DVD";
            this.btn_ajout_dvd.UseVisualStyleBackColor = true;
            this.btn_ajout_dvd.Click += new System.EventHandler(this.btn_ajout_dvd_Click);
            // 
            // liste_dvd
            // 
            this.liste_dvd.AllowUserToAddRows = false;
            this.liste_dvd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste_dvd.Location = new System.Drawing.Point(12, 12);
            this.liste_dvd.Name = "liste_dvd";
            this.liste_dvd.RowTemplate.Height = 24;
            this.liste_dvd.Size = new System.Drawing.Size(1146, 293);
            this.liste_dvd.TabIndex = 5;
            // 
            // form_dvd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 507);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_supp_dvd);
            this.Controls.Add(this.btn_modif_dvd);
            this.Controls.Add(this.btn_ajout_dvd);
            this.Controls.Add(this.liste_dvd);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fermeture);
            this.Name = "form_dvd";
            this.Text = "Liste des DVD";
            ((System.ComponentModel.ISupportInitialize)(this.liste_dvd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Button btn_supp_dvd;
        private System.Windows.Forms.Button btn_modif_dvd;
        private System.Windows.Forms.Button btn_ajout_dvd;
        private System.Windows.Forms.DataGridView liste_dvd;

    }
}