namespace jukebox_form
{
    partial class form_DVD_modif
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
            this.btn_modif = new System.Windows.Forms.Button();
            this.modif_champ_commentaire = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.modif_champ_metteurenscene = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.modif_champ_duree = new System.Windows.Forms.TextBox();
            this.modif_champ_enstock = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modif_champ_titre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_modif_dvd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_modif
            // 
            this.btn_modif.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modif.Location = new System.Drawing.Point(211, 422);
            this.btn_modif.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(100, 28);
            this.btn_modif.TabIndex = 65;
            this.btn_modif.Text = "Modifier";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // modif_champ_commentaire
            // 
            this.modif_champ_commentaire.Location = new System.Drawing.Point(217, 254);
            this.modif_champ_commentaire.Margin = new System.Windows.Forms.Padding(4);
            this.modif_champ_commentaire.Multiline = true;
            this.modif_champ_commentaire.Name = "modif_champ_commentaire";
            this.modif_champ_commentaire.Size = new System.Drawing.Size(165, 99);
            this.modif_champ_commentaire.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 254);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 63;
            this.label8.Text = "Commentaire";
            // 
            // modif_champ_metteurenscene
            // 
            this.modif_champ_metteurenscene.Location = new System.Drawing.Point(232, 198);
            this.modif_champ_metteurenscene.Margin = new System.Windows.Forms.Padding(4);
            this.modif_champ_metteurenscene.Name = "modif_champ_metteurenscene";
            this.modif_champ_metteurenscene.Size = new System.Drawing.Size(132, 22);
            this.modif_champ_metteurenscene.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Metteur en scène";
            // 
            // modif_champ_duree
            // 
            this.modif_champ_duree.Location = new System.Drawing.Point(232, 109);
            this.modif_champ_duree.Margin = new System.Windows.Forms.Padding(4);
            this.modif_champ_duree.Name = "modif_champ_duree";
            this.modif_champ_duree.Size = new System.Drawing.Size(132, 22);
            this.modif_champ_duree.TabIndex = 56;
            // 
            // modif_champ_enstock
            // 
            this.modif_champ_enstock.AutoSize = true;
            this.modif_champ_enstock.Location = new System.Drawing.Point(232, 163);
            this.modif_champ_enstock.Margin = new System.Windows.Forms.Padding(4);
            this.modif_champ_enstock.Name = "modif_champ_enstock";
            this.modif_champ_enstock.Size = new System.Drawing.Size(52, 21);
            this.modif_champ_enstock.TabIndex = 55;
            this.modif_champ_enstock.Text = "Oui";
            this.modif_champ_enstock.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Dispo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Durée(min)";
            // 
            // modif_champ_titre
            // 
            this.modif_champ_titre.Location = new System.Drawing.Point(232, 59);
            this.modif_champ_titre.Margin = new System.Windows.Forms.Padding(4);
            this.modif_champ_titre.Name = "modif_champ_titre";
            this.modif_champ_titre.Size = new System.Drawing.Size(132, 22);
            this.modif_champ_titre.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Titre";
            // 
            // txt_modif_dvd
            // 
            this.txt_modif_dvd.AutoSize = true;
            this.txt_modif_dvd.Location = new System.Drawing.Point(208, 18);
            this.txt_modif_dvd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_modif_dvd.Name = "txt_modif_dvd";
            this.txt_modif_dvd.Size = new System.Drawing.Size(106, 17);
            this.txt_modif_dvd.TabIndex = 50;
            this.txt_modif_dvd.Text = "Modifier le DVD";
            // 
            // form_DVD_modif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 514);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.modif_champ_commentaire);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.modif_champ_metteurenscene);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modif_champ_duree);
            this.Controls.Add(this.modif_champ_enstock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modif_champ_titre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_modif_dvd);
            this.Name = "form_DVD_modif";
            this.Text = "Modifier le DVD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.TextBox modif_champ_commentaire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox modif_champ_metteurenscene;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox modif_champ_duree;
        private System.Windows.Forms.CheckBox modif_champ_enstock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modif_champ_titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_modif_dvd;
    }
}