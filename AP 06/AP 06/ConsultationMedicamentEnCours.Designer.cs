
namespace AP_06
{
    partial class ConsultationMedicamentEnCours
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
            this.lvAfficherMedoc = new System.Windows.Forms.ListView();
            this.depotLegal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomCommercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.libelleFamille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lvWorkflowMedocChoisi = new System.Windows.Forms.ListView();
            this.numEtape = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.normeEtape = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateNorme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btRetour = new System.Windows.Forms.Button();
            this.lvDecision = new System.Windows.Forms.ListView();
            this.libelleDecision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateDécision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvAfficherMedoc
            // 
            this.lvAfficherMedoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.depotLegal,
            this.nomCommercial,
            this.libelleFamille});
            this.lvAfficherMedoc.FullRowSelect = true;
            this.lvAfficherMedoc.HideSelection = false;
            this.lvAfficherMedoc.Location = new System.Drawing.Point(29, 81);
            this.lvAfficherMedoc.MultiSelect = false;
            this.lvAfficherMedoc.Name = "lvAfficherMedoc";
            this.lvAfficherMedoc.Size = new System.Drawing.Size(880, 553);
            this.lvAfficherMedoc.TabIndex = 0;
            this.lvAfficherMedoc.UseCompatibleStateImageBehavior = false;
            this.lvAfficherMedoc.View = System.Windows.Forms.View.Details;
            this.lvAfficherMedoc.SelectedIndexChanged += new System.EventHandler(this.lvAfficherMedoc_SelectedIndexChanged);
            // 
            // depotLegal
            // 
            this.depotLegal.Text = "Dépôt légal";
            this.depotLegal.Width = 140;
            // 
            // nomCommercial
            // 
            this.nomCommercial.Text = "Nom commercial";
            this.nomCommercial.Width = 160;
            // 
            // libelleFamille
            // 
            this.libelleFamille.Text = "Libellé de la famille";
            this.libelleFamille.Width = 330;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultation des médicaments en cours de validation";
            // 
            // lvWorkflowMedocChoisi
            // 
            this.lvWorkflowMedocChoisi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numEtape,
            this.normeEtape,
            this.dateNorme});
            this.lvWorkflowMedocChoisi.HideSelection = false;
            this.lvWorkflowMedocChoisi.Location = new System.Drawing.Point(963, 228);
            this.lvWorkflowMedocChoisi.Name = "lvWorkflowMedocChoisi";
            this.lvWorkflowMedocChoisi.Size = new System.Drawing.Size(426, 406);
            this.lvWorkflowMedocChoisi.TabIndex = 2;
            this.lvWorkflowMedocChoisi.UseCompatibleStateImageBehavior = false;
            this.lvWorkflowMedocChoisi.View = System.Windows.Forms.View.Details;
            this.lvWorkflowMedocChoisi.SelectedIndexChanged += new System.EventHandler(this.lvWorkflowMedocChoisi_SelectedIndexChanged);
            // 
            // numEtape
            // 
            this.numEtape.Text = "Numéro Etape";
            this.numEtape.Width = 70;
            // 
            // normeEtape
            // 
            this.normeEtape.Text = "Norme de l\'étape";
            this.normeEtape.Width = 120;
            // 
            // dateNorme
            // 
            this.dateNorme.Text = "Date de norme";
            this.dateNorme.Width = 120;
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(82, 694);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(251, 74);
            this.btRetour.TabIndex = 3;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // lvDecision
            // 
            this.lvDecision.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.libelleDecision,
            this.dateDécision});
            this.lvDecision.HideSelection = false;
            this.lvDecision.Location = new System.Drawing.Point(1408, 228);
            this.lvDecision.Name = "lvDecision";
            this.lvDecision.Size = new System.Drawing.Size(310, 410);
            this.lvDecision.TabIndex = 4;
            this.lvDecision.UseCompatibleStateImageBehavior = false;
            this.lvDecision.View = System.Windows.Forms.View.Details;
            // 
            // libelleDecision
            // 
            this.libelleDecision.Text = "Décision";
            this.libelleDecision.Width = 70;
            // 
            // dateDécision
            // 
            this.dateDécision.Text = "Date de la décision";
            this.dateDécision.Width = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(958, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Etapes : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1403, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Décisions : ";
            // 
            // ConsultationMedicamentEnCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 809);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvDecision);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.lvWorkflowMedocChoisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvAfficherMedoc);
            this.Name = "ConsultationMedicamentEnCours";
            this.Text = "ConsultationMedicamentEnCours";
            this.Load += new System.EventHandler(this.ConsultationMedicamentEnCours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvAfficherMedoc;
        private System.Windows.Forms.ColumnHeader depotLegal;
        private System.Windows.Forms.ColumnHeader nomCommercial;
        private System.Windows.Forms.ColumnHeader libelleFamille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvWorkflowMedocChoisi;
        private System.Windows.Forms.ColumnHeader numEtape;
        private System.Windows.Forms.ColumnHeader normeEtape;
        private System.Windows.Forms.ColumnHeader dateNorme;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.ListView lvDecision;
        private System.Windows.Forms.ColumnHeader libelleDecision;
        private System.Windows.Forms.ColumnHeader dateDécision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}