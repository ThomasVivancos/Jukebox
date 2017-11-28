namespace jukebox_form
{
    partial class form_CD
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
            this.liste_cd = new System.Windows.Forms.DataGridView();
            this.btn_ajout_cd = new System.Windows.Forms.Button();
            this.btn_modif_cd = new System.Windows.Forms.Button();
            this.btn_supp_CD = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            this.btn_emp_CD = new System.Windows.Forms.Button();
            this.btn_rendre_CD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liste_cd)).BeginInit();
            this.SuspendLayout();
            // 
            // liste_cd
            // 
            this.liste_cd.AllowUserToAddRows = false;
            this.liste_cd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste_cd.Location = new System.Drawing.Point(12, 12);
            this.liste_cd.Name = "liste_cd";
            this.liste_cd.RowTemplate.Height = 24;
            this.liste_cd.Size = new System.Drawing.Size(1146, 293);
            this.liste_cd.TabIndex = 0;
            // 
            // btn_ajout_cd
            // 
            this.btn_ajout_cd.Location = new System.Drawing.Point(120, 419);
            this.btn_ajout_cd.Name = "btn_ajout_cd";
            this.btn_ajout_cd.Size = new System.Drawing.Size(117, 43);
            this.btn_ajout_cd.TabIndex = 1;
            this.btn_ajout_cd.Text = "Ajouter un nouveau CD";
            this.btn_ajout_cd.UseVisualStyleBackColor = true;
            this.btn_ajout_cd.Click += new System.EventHandler(this.btn_ajout_cd_Click);
            // 
            // btn_modif_cd
            // 
            this.btn_modif_cd.Location = new System.Drawing.Point(295, 419);
            this.btn_modif_cd.Name = "btn_modif_cd";
            this.btn_modif_cd.Size = new System.Drawing.Size(117, 43);
            this.btn_modif_cd.TabIndex = 2;
            this.btn_modif_cd.Text = "Modifier le CD";
            this.btn_modif_cd.UseVisualStyleBackColor = true;
            this.btn_modif_cd.Click += new System.EventHandler(this.btn_modif_cd_Click);
            // 
            // btn_supp_CD
            // 
            this.btn_supp_CD.Location = new System.Drawing.Point(497, 419);
            this.btn_supp_CD.Name = "btn_supp_CD";
            this.btn_supp_CD.Size = new System.Drawing.Size(112, 43);
            this.btn_supp_CD.TabIndex = 3;
            this.btn_supp_CD.Text = "Supprimer le CD";
            this.btn_supp_CD.UseVisualStyleBackColor = true;
            this.btn_supp_CD.Click += new System.EventHandler(this.btn_supp_CD_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(1028, 424);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(121, 32);
            this.btn_retour.TabIndex = 4;
            this.btn_retour.Text = "Retour au menu";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // btn_emp_CD
            // 
            this.btn_emp_CD.Location = new System.Drawing.Point(692, 419);
            this.btn_emp_CD.Name = "btn_emp_CD";
            this.btn_emp_CD.Size = new System.Drawing.Size(112, 43);
            this.btn_emp_CD.TabIndex = 5;
            this.btn_emp_CD.Text = "Emprunter";
            this.btn_emp_CD.UseVisualStyleBackColor = true;
            this.btn_emp_CD.Click += new System.EventHandler(this.btn_emp_CD_Click);
            // 
            // btn_rendre_CD
            // 
            this.btn_rendre_CD.Location = new System.Drawing.Point(841, 419);
            this.btn_rendre_CD.Name = "btn_rendre_CD";
            this.btn_rendre_CD.Size = new System.Drawing.Size(112, 43);
            this.btn_rendre_CD.TabIndex = 6;
            this.btn_rendre_CD.Text = "Rendre";
            this.btn_rendre_CD.UseVisualStyleBackColor = true;
            this.btn_rendre_CD.Click += new System.EventHandler(this.btn_rendre_CD_Click);
            // 
            // form_CD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 513);
            this.Controls.Add(this.btn_rendre_CD);
            this.Controls.Add(this.btn_emp_CD);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_supp_CD);
            this.Controls.Add(this.btn_modif_cd);
            this.Controls.Add(this.btn_ajout_cd);
            this.Controls.Add(this.liste_cd);
            this.Name = "form_CD";
            this.Text = "Liste des CD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fermeture_form_CD);
            ((System.ComponentModel.ISupportInitialize)(this.liste_cd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView liste_cd;
        private System.Windows.Forms.Button btn_ajout_cd;
        private System.Windows.Forms.Button btn_modif_cd;
        private System.Windows.Forms.Button btn_supp_CD;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Button btn_emp_CD;
        private System.Windows.Forms.Button btn_rendre_CD;
    }
}