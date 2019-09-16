namespace cinema
{
    partial class Form1
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
            this.lb_titre = new System.Windows.Forms.Label();
            this.lb_titreFilm = new System.Windows.Forms.Label();
            this.lb_nbPlacesFilm = new System.Windows.Forms.Label();
            this.lb_prixPlaceFilm = new System.Windows.Forms.Label();
            this.cb_tarifReduit = new System.Windows.Forms.CheckBox();
            this.tb_titre = new System.Windows.Forms.TextBox();
            this.tb_places = new System.Windows.Forms.TextBox();
            this.tb_prix = new System.Windows.Forms.TextBox();
            this.bt_validerSeance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_titre.Location = new System.Drawing.Point(303, 22);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(166, 44);
            this.lb_titre.TabIndex = 0;
            this.lb_titre.Text = "CINEMA\r\n";
            // 
            // lb_titreFilm
            // 
            this.lb_titreFilm.AutoSize = true;
            this.lb_titreFilm.Location = new System.Drawing.Point(109, 115);
            this.lb_titreFilm.Name = "lb_titreFilm";
            this.lb_titreFilm.Size = new System.Drawing.Size(70, 13);
            this.lb_titreFilm.TabIndex = 1;
            this.lb_titreFilm.Text = "Titre du film : ";
            // 
            // lb_nbPlacesFilm
            // 
            this.lb_nbPlacesFilm.AutoSize = true;
            this.lb_nbPlacesFilm.Location = new System.Drawing.Point(109, 168);
            this.lb_nbPlacesFilm.Name = "lb_nbPlacesFilm";
            this.lb_nbPlacesFilm.Size = new System.Drawing.Size(99, 13);
            this.lb_nbPlacesFilm.TabIndex = 2;
            this.lb_nbPlacesFilm.Text = "Nombre de places :";
            // 
            // lb_prixPlaceFilm
            // 
            this.lb_prixPlaceFilm.AutoSize = true;
            this.lb_prixPlaceFilm.Location = new System.Drawing.Point(112, 227);
            this.lb_prixPlaceFilm.Name = "lb_prixPlaceFilm";
            this.lb_prixPlaceFilm.Size = new System.Drawing.Size(88, 13);
            this.lb_prixPlaceFilm.TabIndex = 3;
            this.lb_prixPlaceFilm.Text = "Prix d\'une place :";
            // 
            // cb_tarifReduit
            // 
            this.cb_tarifReduit.AutoSize = true;
            this.cb_tarifReduit.Location = new System.Drawing.Point(115, 306);
            this.cb_tarifReduit.Name = "cb_tarifReduit";
            this.cb_tarifReduit.Size = new System.Drawing.Size(163, 17);
            this.cb_tarifReduit.TabIndex = 4;
            this.cb_tarifReduit.Text = "Bénéficiaire d\'une réduction :";
            this.cb_tarifReduit.UseVisualStyleBackColor = true;
            // 
            // tb_titre
            // 
            this.tb_titre.Location = new System.Drawing.Point(273, 115);
            this.tb_titre.Name = "tb_titre";
            this.tb_titre.Size = new System.Drawing.Size(100, 20);
            this.tb_titre.TabIndex = 5;
            this.tb_titre.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // tb_places
            // 
            this.tb_places.Location = new System.Drawing.Point(273, 168);
            this.tb_places.Name = "tb_places";
            this.tb_places.Size = new System.Drawing.Size(100, 20);
            this.tb_places.TabIndex = 6;
            // 
            // tb_prix
            // 
            this.tb_prix.Location = new System.Drawing.Point(273, 227);
            this.tb_prix.Name = "tb_prix";
            this.tb_prix.Size = new System.Drawing.Size(100, 20);
            this.tb_prix.TabIndex = 7;
            // 
            // bt_validerSeance
            // 
            this.bt_validerSeance.Location = new System.Drawing.Point(273, 346);
            this.bt_validerSeance.Name = "bt_validerSeance";
            this.bt_validerSeance.Size = new System.Drawing.Size(100, 31);
            this.bt_validerSeance.TabIndex = 8;
            this.bt_validerSeance.Text = "Valider la séance";
            this.bt_validerSeance.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_validerSeance);
            this.Controls.Add(this.tb_prix);
            this.Controls.Add(this.tb_places);
            this.Controls.Add(this.tb_titre);
            this.Controls.Add(this.cb_tarifReduit);
            this.Controls.Add(this.lb_prixPlaceFilm);
            this.Controls.Add(this.lb_nbPlacesFilm);
            this.Controls.Add(this.lb_titreFilm);
            this.Controls.Add(this.lb_titre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titre;
        private System.Windows.Forms.Label lb_titreFilm;
        private System.Windows.Forms.Label lb_nbPlacesFilm;
        private System.Windows.Forms.Label lb_prixPlaceFilm;
        private System.Windows.Forms.CheckBox cb_tarifReduit;
        private System.Windows.Forms.TextBox tb_titre;
        private System.Windows.Forms.TextBox tb_places;
        private System.Windows.Forms.TextBox tb_prix;
        private System.Windows.Forms.Button bt_validerSeance;
    }
}

