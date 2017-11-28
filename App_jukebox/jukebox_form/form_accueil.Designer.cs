namespace jukebox_form
{
    partial class form_accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cd = new System.Windows.Forms.Button();
            this.btn_dvd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cd
            // 
            this.btn_cd.Location = new System.Drawing.Point(113, 245);
            this.btn_cd.Name = "btn_cd";
            this.btn_cd.Size = new System.Drawing.Size(75, 23);
            this.btn_cd.TabIndex = 0;
            this.btn_cd.Text = "CD";
            this.btn_cd.UseVisualStyleBackColor = true;
            this.btn_cd.Click += new System.EventHandler(this.btn_cd_Click);
            // 
            // btn_dvd
            // 
            this.btn_dvd.Location = new System.Drawing.Point(344, 245);
            this.btn_dvd.Name = "btn_dvd";
            this.btn_dvd.Size = new System.Drawing.Size(75, 23);
            this.btn_dvd.TabIndex = 1;
            this.btn_dvd.Text = "DVD";
            this.btn_dvd.UseVisualStyleBackColor = true;
            this.btn_dvd.Click += new System.EventHandler(this.btn_dvd_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jukebox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bora-Bora";
            // 
            // form_accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dvd);
            this.Controls.Add(this.btn_cd);
            this.Name = "form_accueil";
            this.Text = "Appli_jukebox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fermeture_accueil);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cd;
        private System.Windows.Forms.Button btn_dvd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

