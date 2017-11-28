namespace jukebox_form
{
    partial class form_DVD_ajout
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
            this.btn_ajout = new System.Windows.Forms.Button();
            this.ajout_champ_commentaire = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ajout_champ_metteurenscene = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ajout_champ_duree = new System.Windows.Forms.TextBox();
            this.ajout_champ_enstock = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ajout_champ_titre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ajout_dvd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ajout
            // 
            this.btn_ajout.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout.Location = new System.Drawing.Point(251, 449);
            this.btn_ajout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(100, 28);
            this.btn_ajout.TabIndex = 49;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // ajout_champ_commentaire
            // 
            this.ajout_champ_commentaire.Location = new System.Drawing.Point(278, 293);
            this.ajout_champ_commentaire.Margin = new System.Windows.Forms.Padding(4);
            this.ajout_champ_commentaire.Multiline = true;
            this.ajout_champ_commentaire.Name = "ajout_champ_commentaire";
            this.ajout_champ_commentaire.Size = new System.Drawing.Size(165, 99);
            this.ajout_champ_commentaire.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 293);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Commentaire";
            // 
            // ajout_champ_metteurenscene
            // 
            this.ajout_champ_metteurenscene.Location = new System.Drawing.Point(299, 208);
            this.ajout_champ_metteurenscene.Margin = new System.Windows.Forms.Padding(4);
            this.ajout_champ_metteurenscene.Name = "ajout_champ_metteurenscene";
            this.ajout_champ_metteurenscene.Size = new System.Drawing.Size(132, 22);
            this.ajout_champ_metteurenscene.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Metteur en scène";
            // 
            // ajout_champ_duree
            // 
            this.ajout_champ_duree.Location = new System.Drawing.Point(299, 119);
            this.ajout_champ_duree.Margin = new System.Windows.Forms.Padding(4);
            this.ajout_champ_duree.Name = "ajout_champ_duree";
            this.ajout_champ_duree.Size = new System.Drawing.Size(132, 22);
            this.ajout_champ_duree.TabIndex = 40;
            // 
            // ajout_champ_enstock
            // 
            this.ajout_champ_enstock.AutoSize = true;
            this.ajout_champ_enstock.Location = new System.Drawing.Point(299, 173);
            this.ajout_champ_enstock.Margin = new System.Windows.Forms.Padding(4);
            this.ajout_champ_enstock.Name = "ajout_champ_enstock";
            this.ajout_champ_enstock.Size = new System.Drawing.Size(52, 21);
            this.ajout_champ_enstock.TabIndex = 39;
            this.ajout_champ_enstock.Text = "Oui";
            this.ajout_champ_enstock.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Dispo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Durée(min)";
            // 
            // ajout_champ_titre
            // 
            this.ajout_champ_titre.Location = new System.Drawing.Point(299, 69);
            this.ajout_champ_titre.Margin = new System.Windows.Forms.Padding(4);
            this.ajout_champ_titre.Name = "ajout_champ_titre";
            this.ajout_champ_titre.Size = new System.Drawing.Size(132, 22);
            this.ajout_champ_titre.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Titre";
            // 
            // txt_ajout_dvd
            // 
            this.txt_ajout_dvd.AutoSize = true;
            this.txt_ajout_dvd.Location = new System.Drawing.Point(250, 27);
            this.txt_ajout_dvd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_ajout_dvd.Name = "txt_ajout_dvd";
            this.txt_ajout_dvd.Size = new System.Drawing.Size(101, 17);
            this.txt_ajout_dvd.TabIndex = 34;
            this.txt_ajout_dvd.Text = "Ajouter le DVD";
            // 
            // form_DVD_ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 532);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.ajout_champ_commentaire);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ajout_champ_metteurenscene);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ajout_champ_duree);
            this.Controls.Add(this.ajout_champ_enstock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ajout_champ_titre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ajout_dvd);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fermeture);
            this.Name = "form_DVD_ajout";
            this.Text = "Ajouter un DVD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.TextBox ajout_champ_commentaire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ajout_champ_metteurenscene;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ajout_champ_duree;
        private System.Windows.Forms.CheckBox ajout_champ_enstock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ajout_champ_titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_ajout_dvd;
    }
}