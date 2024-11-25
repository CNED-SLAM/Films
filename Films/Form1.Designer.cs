namespace Films
{
    partial class frmFilms
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lstTitres = new System.Windows.Forms.ListBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(46, 6);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(148, 20);
            this.txtTitre.TabIndex = 1;
            this.txtTitre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitre_KeyPress);
            // 
            // lstTitres
            // 
            this.lstTitres.FormattingEnabled = true;
            this.lstTitres.Location = new System.Drawing.Point(46, 32);
            this.lstTitres.Name = "lstTitres";
            this.lstTitres.Size = new System.Drawing.Size(148, 121);
            this.lstTitres.TabIndex = 2;
            this.lstTitres.SelectedIndexChanged += new System.EventHandler(this.lstTitres_SelectedIndexChanged);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(46, 156);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(35, 13);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "label2";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(200, 6);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(86, 20);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(200, 32);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(86, 20);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(200, 133);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(86, 20);
            this.btnVider.TabIndex = 6;
            this.btnVider.Text = "vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // frmFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 175);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lstTitres);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label1);
            this.Name = "frmFilms";
            this.Text = "Films";
            this.Load += new System.EventHandler(this.frmFilms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.ListBox lstTitres;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnVider;
    }
}

