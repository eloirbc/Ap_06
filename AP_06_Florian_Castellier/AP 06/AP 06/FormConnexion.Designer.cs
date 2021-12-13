namespace AP_06
{
    partial class FormConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdentifiant = new System.Windows.Forms.TextBox();
            this.tbMotDePasse = new System.Windows.Forms.TextBox();
            this.btConnexion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "gesAMM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identifiant :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 588);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mot de passe :";
            // 
            // tbIdentifiant
            // 
            this.tbIdentifiant.Location = new System.Drawing.Point(312, 496);
            this.tbIdentifiant.Name = "tbIdentifiant";
            this.tbIdentifiant.Size = new System.Drawing.Size(191, 44);
            this.tbIdentifiant.TabIndex = 3;
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Location = new System.Drawing.Point(340, 585);
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.PasswordChar = '*';
            this.tbMotDePasse.Size = new System.Drawing.Size(191, 44);
            this.tbMotDePasse.TabIndex = 4;
            // 
            // btConnexion
            // 
            this.btConnexion.Location = new System.Drawing.Point(191, 681);
            this.btConnexion.Name = "btConnexion";
            this.btConnexion.Size = new System.Drawing.Size(253, 54);
            this.btConnexion.TabIndex = 5;
            this.btConnexion.Text = "Connexion";
            this.btConnexion.UseVisualStyleBackColor = true;
            this.btConnexion.Click += new System.EventHandler(this.btConnexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(91, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 288);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(618, 832);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btConnexion);
            this.Controls.Add(this.tbMotDePasse);
            this.Controls.Add(this.tbIdentifiant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "FormConnexion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdentifiant;
        private System.Windows.Forms.TextBox tbMotDePasse;
        private System.Windows.Forms.Button btConnexion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

