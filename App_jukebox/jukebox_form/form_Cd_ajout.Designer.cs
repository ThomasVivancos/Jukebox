namespace jukebox_form
{
    partial class form_Cd_ajout
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ajout_champ_artiste = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ajout_champ_enstock = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ajout_champ_titre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ajout_cd = new System.Windows.Forms.Label();
            this.ajout_champ_duree = new System.Windows.Forms.NumericUpDown();
            this.ajout_champ_nbpiste = new System.Windows.Forms.NumericUpDown();
            this.ajout_champ_prix = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ajout_champ_duree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajout_champ_nbpiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajout_champ_prix)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ajout
            // 
            this.btn_ajout.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajout.Location = new System.Drawing.Point(172, 453);
            this.btn_ajout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(100, 28);
            this.btn_ajout.TabIndex = 33;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // ajout_champ_commentaire
            // 
            this.ajout_champ_commentaire.Location = new System.Drawing.Point(187, 316);
            this.ajout_champ_commentaire.Margin = new System.Windows.Forms.Padding(4);
            this.ajout_champ_commentaire.Multiline = true;
            this.ajout_champ_commentaire.Name = "ajout_champ_commentaire";
            this.ajout_champ_commentaire.Size = new System.Drawing.Size(165, 99);
            this.ajout_champ_commentaire.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 316);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Commentaire";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 273);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Prix (XPF)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nombre de pistes";
            // 
            // ajout_champ_artiste
            // 
            this.ajout_champ_artiste.Location = new System.Drawing.Point(187, 185);
            this.ajout_champ_artiste.Margin = new System.Windows.Forms.Padding(4);
            this.ajout_champ_artiste.Name = "ajout_champ_artiste";
            this.ajout_champ_artiste.Size = new System.Drawing.Size(132, 22);
            this.ajout_champ_artiste.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Artiste";
            // 
            // ajout_champ_enstock
            // 
            this.ajout_champ_enstock.AutoSize = true;
            this.ajout_champ_enstock.Location = new System.Drawing.Point(187, 150);
            this.ajout_champ_enstock.Margin = new System.Windows.Forms.Padding(4);
            this.ajout_champ_enstock.Name = "ajout_champ_enstock";
            this.ajout_champ_enstock.Size = new System.Drawing.Size(52, 21);
            this.ajout_champ_enstock.TabIndex = 23;
            this.ajout_champ_enstock.Text = "Oui";
            this.ajout_champ_enstock.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Dispo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Durée(min)";
            // 
            // ajout_champ_titre
            // 
            this.ajout_champ_titre.Location = new System.Drawing.Point(187, 46);
            this.ajout_champ_titre.Margin = new System.Windows.Forms.Padding(4);
            this.ajout_champ_titre.Name = "ajout_champ_titre";
            this.ajout_champ_titre.Size = new System.Drawing.Size(132, 22);
            this.ajout_champ_titre.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Titre";
            // 
            // txt_ajout_cd
            // 
            this.txt_ajout_cd.AutoSize = true;
            this.txt_ajout_cd.Location = new System.Drawing.Point(163, 5);
            this.txt_ajout_cd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_ajout_cd.Name = "txt_ajout_cd";
            this.txt_ajout_cd.Size = new System.Drawing.Size(91, 17);
            this.txt_ajout_cd.TabIndex = 18;
            this.txt_ajout_cd.Text = "Ajouter le CD";
            // 
            // ajout_champ_duree
            // 
            this.ajout_champ_duree.Location = new System.Drawing.Point(187, 95);
            this.ajout_champ_duree.Name = "ajout_champ_duree";
            this.ajout_champ_duree.Size = new System.Drawing.Size(120, 22);
            this.ajout_champ_duree.TabIndex = 34;
            // 
            // ajout_champ_nbpiste
            // 
            this.ajout_champ_nbpiste.Location = new System.Drawing.Point(187, 230);
            this.ajout_champ_nbpiste.Name = "ajout_champ_nbpiste";
            this.ajout_champ_nbpiste.Size = new System.Drawing.Size(120, 22);
            this.ajout_champ_nbpiste.TabIndex = 35;
            // 
            // ajout_champ_prix
            // 
            this.ajout_champ_prix.Location = new System.Drawing.Point(187, 271);
            this.ajout_champ_prix.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ajout_champ_prix.Name = "ajout_champ_prix";
            this.ajout_champ_prix.Size = new System.Drawing.Size(120, 22);
            this.ajout_champ_prix.TabIndex = 36;
            // 
            // form_Cd_ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 510);
            this.Controls.Add(this.ajout_champ_prix);
            this.Controls.Add(this.ajout_champ_nbpiste);
            this.Controls.Add(this.ajout_champ_duree);
            this.Controls.Add(this.btn_ajout);
            this.Controls.Add(this.ajout_champ_commentaire);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ajout_champ_artiste);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ajout_champ_enstock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ajout_champ_titre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ajout_cd);
            this.Name = "form_Cd_ajout";
            this.Text = "form_ajout_cd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fermeture_form_cd_ajout);
            ((System.ComponentModel.ISupportInitialize)(this.ajout_champ_duree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajout_champ_nbpiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajout_champ_prix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.TextBox ajout_champ_commentaire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ajout_champ_artiste;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ajout_champ_enstock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ajout_champ_titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_ajout_cd;
        private System.Windows.Forms.NumericUpDown ajout_champ_duree;
        private System.Windows.Forms.NumericUpDown ajout_champ_nbpiste;
        private System.Windows.Forms.NumericUpDown ajout_champ_prix;
    }
}