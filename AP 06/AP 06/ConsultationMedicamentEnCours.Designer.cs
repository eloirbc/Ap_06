
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
            this.decisionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.decisionDate,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvWorkflowMedocChoisi.HideSelection = false;
            this.lvWorkflowMedocChoisi.Location = new System.Drawing.Point(963, 81);
            this.lvWorkflowMedocChoisi.Name = "lvWorkflowMedocChoisi";
            this.lvWorkflowMedocChoisi.Size = new System.Drawing.Size(357, 553);
            this.lvWorkflowMedocChoisi.TabIndex = 2;
            this.lvWorkflowMedocChoisi.UseCompatibleStateImageBehavior = false;
            this.lvWorkflowMedocChoisi.View = System.Windows.Forms.View.Details;
            // 
            // numEtape
            // 
            this.numEtape.Text = "Numéro Etape";
            // 
            // decisionDate
            // 
            this.decisionDate.Text = "Date de la décision";
            // 
            // ConsultationMedicamentEnCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 646);
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
        private System.Windows.Forms.ColumnHeader decisionDate;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}