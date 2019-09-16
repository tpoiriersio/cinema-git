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
            this.cb_tarifReduit = new System.Windows.Forms.CheckBox();
            this.bt_validerSeance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_places = new System.Windows.Forms.TextBox();
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
            // cb_tarifReduit
            // 
            this.cb_tarifReduit.AutoSize = true;
            this.cb_tarifReduit.Location = new System.Drawing.Point(150, 205);
            this.cb_tarifReduit.Name = "cb_tarifReduit";
            this.cb_tarifReduit.Size = new System.Drawing.Size(163, 17);
            this.cb_tarifReduit.TabIndex = 4;
            this.cb_tarifReduit.Text = "Bénéficiaire d\'une réduction :";
            this.cb_tarifReduit.UseVisualStyleBackColor = true;
            // 
            // bt_validerSeance
            // 
            this.bt_validerSeance.Location = new System.Drawing.Point(311, 266);
            this.bt_validerSeance.Name = "bt_validerSeance";
            this.bt_validerSeance.Size = new System.Drawing.Size(100, 31);
            this.bt_validerSeance.TabIndex = 8;
            this.bt_validerSeance.Text = "Valider la séance";
            this.bt_validerSeance.UseVisualStyleBackColor = true;
            this.bt_validerSeance.Click += new System.EventHandler(this.Bt_validerSeance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de places :";
            // 
            // tb_places
            // 
            this.tb_places.Location = new System.Drawing.Point(311, 125);
            this.tb_places.Name = "tb_places";
            this.tb_places.Size = new System.Drawing.Size(100, 20);
            this.tb_places.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_places);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_validerSeance);
            this.Controls.Add(this.cb_tarifReduit);
            this.Controls.Add(this.lb_titre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titre;
        private System.Windows.Forms.CheckBox cb_tarifReduit;
        private System.Windows.Forms.Button bt_validerSeance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_places;
    }
}

