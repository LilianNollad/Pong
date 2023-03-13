namespace balle
{
    partial class Fm_principal
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
            this.components = new System.ComponentModel.Container();
            this.leTerrain = new System.Windows.Forms.Panel();
            this.laRaquette = new balle.Raquette();
            this.balle11 = new balle.Balle1();
            this.bt_jouer = new System.Windows.Forms.Button();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.lb_score = new System.Windows.Forms.Label();
            this.lb_score2 = new System.Windows.Forms.Label();
            this.lb_score3 = new System.Windows.Forms.Label();
            this.lb_score4 = new System.Windows.Forms.Label();
            this.leTerrain.SuspendLayout();
            this.SuspendLayout();
            // 
            // leTerrain
            // 
            this.leTerrain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.leTerrain.Controls.Add(this.laRaquette);
            this.leTerrain.Controls.Add(this.balle11);
            this.leTerrain.Location = new System.Drawing.Point(25, 59);
            this.leTerrain.Name = "leTerrain";
            this.leTerrain.Size = new System.Drawing.Size(945, 393);
            this.leTerrain.TabIndex = 0;
            this.leTerrain.Paint += new System.Windows.Forms.PaintEventHandler(this.leTerrain_Paint);
            // 
            // laRaquette
            // 
            this.laRaquette.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.laRaquette.Location = new System.Drawing.Point(307, 309);
            this.laRaquette.Name = "laRaquette";
            this.laRaquette.Size = new System.Drawing.Size(160, 21);
            this.laRaquette.TabIndex = 2;
            this.laRaquette.KeyDown += new System.Windows.Forms.KeyEventHandler(this.laRaquette_KeyDown_1);
            this.laRaquette.KeyUp += new System.Windows.Forms.KeyEventHandler(this.laRaquette_KeyUp_1);
            // 
            // balle11
            // 
            this.balle11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.balle11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balle11.Location = new System.Drawing.Point(789, 54);
            this.balle11.Name = "balle11";
            this.balle11.Size = new System.Drawing.Size(27, 27);
            this.balle11.TabIndex = 0;
            this.balle11.Load += new System.EventHandler(this.balle11_Load);
            // 
            // bt_jouer
            // 
            this.bt_jouer.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_jouer.Location = new System.Drawing.Point(25, 12);
            this.bt_jouer.Name = "bt_jouer";
            this.bt_jouer.Size = new System.Drawing.Size(111, 48);
            this.bt_jouer.TabIndex = 1;
            this.bt_jouer.Text = "Jouer";
            this.bt_jouer.UseVisualStyleBackColor = true;
            this.bt_jouer.Click += new System.EventHandler(this.bt_jouer_Click);
            // 
            // bt_quitter
            // 
            this.bt_quitter.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quitter.Location = new System.Drawing.Point(814, 12);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(140, 48);
            this.bt_quitter.TabIndex = 2;
            this.bt_quitter.Text = "Quitter";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // tempo
            // 
            this.tempo.Interval = 10;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.Font = new System.Drawing.Font("Unispace", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score.Location = new System.Drawing.Point(418, 12);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(134, 34);
            this.lb_score.TabIndex = 4;
            this.lb_score.Text = "Score :";
            this.lb_score.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_score2
            // 
            this.lb_score2.AutoSize = true;
            this.lb_score2.Font = new System.Drawing.Font("Unispace", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score2.Location = new System.Drawing.Point(551, 12);
            this.lb_score2.Name = "lb_score2";
            this.lb_score2.Size = new System.Drawing.Size(32, 34);
            this.lb_score2.TabIndex = 5;
            this.lb_score2.Text = "0";
            // 
            // lb_score3
            // 
            this.lb_score3.AutoSize = true;
            this.lb_score3.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score3.Location = new System.Drawing.Point(719, 467);
            this.lb_score3.Name = "lb_score3";
            this.lb_score3.Size = new System.Drawing.Size(178, 24);
            this.lb_score3.TabIndex = 6;
            this.lb_score3.Text = "MeilleurScore:";
            this.lb_score3.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_score4
            // 
            this.lb_score4.AutoSize = true;
            this.lb_score4.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score4.Location = new System.Drawing.Point(903, 467);
            this.lb_score4.Name = "lb_score4";
            this.lb_score4.Size = new System.Drawing.Size(22, 24);
            this.lb_score4.TabIndex = 7;
            this.lb_score4.Text = "0";
            // 
            // Fm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(982, 500);
            this.Controls.Add(this.lb_score4);
            this.Controls.Add(this.lb_score3);
            this.Controls.Add(this.lb_score2);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_jouer);
            this.Controls.Add(this.leTerrain);
            this.Name = "Fm_principal";
            this.Text = "Form1";
            this.leTerrain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leTerrain;
        private System.Windows.Forms.Button bt_jouer;
        private System.Windows.Forms.Button bt_quitter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Balle1 balle11;
        private System.Windows.Forms.Timer tempo;
        private Raquette laRaquette;
        private System.Windows.Forms.Label lb_score;
        private System.Windows.Forms.Label lb_score2;
        private System.Windows.Forms.Label lb_score3;
        private System.Windows.Forms.Label lb_score4;
    }
}

