
namespace AP_06
{
    partial class MedicamentsParFamille
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
            this.lvFamille = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvMedicaments = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvFamille
            // 
            this.lvFamille.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lvFamille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvFamille.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvFamille.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvFamille.FullRowSelect = true;
            this.lvFamille.HideSelection = false;
            this.lvFamille.Location = new System.Drawing.Point(166, 130);
            this.lvFamille.Name = "lvFamille";
            this.lvFamille.Size = new System.Drawing.Size(607, 279);
            this.lvFamille.TabIndex = 0;
            this.lvFamille.UseCompatibleStateImageBehavior = false;
            this.lvFamille.View = System.Windows.Forms.View.Details;
            this.lvFamille.SelectedIndexChanged += new System.EventHandler(this.lvFamille_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code de la famille";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Désignation";
            this.columnHeader2.Width = 254;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre de médicaments autorisés";
            this.columnHeader3.Width = 258;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÉDICAMENTS PAR FAMILLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "FAMILLES :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "MÉDICAMENTS :";
            // 
            // lvMedicaments
            // 
            this.lvMedicaments.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lvMedicaments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMedicaments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvMedicaments.FullRowSelect = true;
            this.lvMedicaments.HideSelection = false;
            this.lvMedicaments.Location = new System.Drawing.Point(12, 470);
            this.lvMedicaments.Name = "lvMedicaments";
            this.lvMedicaments.Size = new System.Drawing.Size(910, 279);
            this.lvMedicaments.TabIndex = 3;
            this.lvMedicaments.UseCompatibleStateImageBehavior = false;
            this.lvMedicaments.View = System.Windows.Forms.View.Details;
            this.lvMedicaments.SelectedIndexChanged += new System.EventHandler(this.lvMedicaments_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dépot légal";
            this.columnHeader4.Width = 94;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nom commercial";
            this.columnHeader5.Width = 158;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Code";
            this.columnHeader6.Width = 58;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Composition";
            this.columnHeader7.Width = 145;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Effets";
            this.columnHeader8.Width = 148;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Contre indication";
            this.columnHeader9.Width = 251;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Prix";
            this.columnHeader10.Width = 54;
            // 
            // MedicamentsParFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(934, 761);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvMedicaments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvFamille);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedicamentsParFamille";
            this.Text = "Medicaments Par Famille";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MedicamentsParFamille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFamille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvMedicaments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}