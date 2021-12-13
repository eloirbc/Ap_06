
namespace AP_06
{
    partial class DecisionDuneEtape
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvMedicaments = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbMettreAJourEtat = new System.Windows.Forms.GroupBox();
            this.cbTypeDécision = new System.Windows.Forms.ComboBox();
            this.dtpDateDecision = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lbReferenceNext = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.lbLibelleNext = new System.Windows.Forms.Label();
            this.lbNumeroNext = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbDateNorme = new System.Windows.Forms.Label();
            this.lbNorme = new System.Windows.Forms.Label();
            this.lbLibelle = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMedicament = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMettreAJourEtat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "DÉCISION D\'UNE ÉTAPE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "MÉDICAMENTS :";
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
            this.columnHeader10,
            this.columnHeader1,
            this.columnHeader2});
            this.lvMedicaments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvMedicaments.FullRowSelect = true;
            this.lvMedicaments.HideSelection = false;
            this.lvMedicaments.Location = new System.Drawing.Point(12, 130);
            this.lvMedicaments.Name = "lvMedicaments";
            this.lvMedicaments.Size = new System.Drawing.Size(910, 279);
            this.lvMedicaments.TabIndex = 5;
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Étape";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "État";
            this.columnHeader2.Width = 138;
            // 
            // gbMettreAJourEtat
            // 
            this.gbMettreAJourEtat.Controls.Add(this.cbTypeDécision);
            this.gbMettreAJourEtat.Controls.Add(this.dtpDateDecision);
            this.gbMettreAJourEtat.Controls.Add(this.label9);
            this.gbMettreAJourEtat.Controls.Add(this.lbReferenceNext);
            this.gbMettreAJourEtat.Controls.Add(this.btValider);
            this.gbMettreAJourEtat.Controls.Add(this.lbLibelleNext);
            this.gbMettreAJourEtat.Controls.Add(this.lbNumeroNext);
            this.gbMettreAJourEtat.Controls.Add(this.label14);
            this.gbMettreAJourEtat.Controls.Add(this.label15);
            this.gbMettreAJourEtat.Controls.Add(this.label16);
            this.gbMettreAJourEtat.Controls.Add(this.label18);
            this.gbMettreAJourEtat.Controls.Add(this.lbDateNorme);
            this.gbMettreAJourEtat.Controls.Add(this.lbNorme);
            this.gbMettreAJourEtat.Controls.Add(this.lbLibelle);
            this.gbMettreAJourEtat.Controls.Add(this.lbDate);
            this.gbMettreAJourEtat.Controls.Add(this.lbNumero);
            this.gbMettreAJourEtat.Controls.Add(this.label8);
            this.gbMettreAJourEtat.Controls.Add(this.label7);
            this.gbMettreAJourEtat.Controls.Add(this.label6);
            this.gbMettreAJourEtat.Controls.Add(this.label5);
            this.gbMettreAJourEtat.Controls.Add(this.label4);
            this.gbMettreAJourEtat.Controls.Add(this.lbMedicament);
            this.gbMettreAJourEtat.Controls.Add(this.label3);
            this.gbMettreAJourEtat.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMettreAJourEtat.Location = new System.Drawing.Point(12, 415);
            this.gbMettreAJourEtat.Name = "gbMettreAJourEtat";
            this.gbMettreAJourEtat.Size = new System.Drawing.Size(910, 334);
            this.gbMettreAJourEtat.TabIndex = 6;
            this.gbMettreAJourEtat.TabStop = false;
            this.gbMettreAJourEtat.Text = "Mettre à jour l\'Etape";
            this.gbMettreAJourEtat.Visible = false;
            // 
            // cbTypeDécision
            // 
            this.cbTypeDécision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeDécision.FormattingEnabled = true;
            this.cbTypeDécision.Items.AddRange(new object[] {
            "validée",
            "refusée"});
            this.cbTypeDécision.Location = new System.Drawing.Point(670, 217);
            this.cbTypeDécision.Name = "cbTypeDécision";
            this.cbTypeDécision.Size = new System.Drawing.Size(216, 32);
            this.cbTypeDécision.TabIndex = 24;
            // 
            // dtpDateDecision
            // 
            this.dtpDateDecision.Location = new System.Drawing.Point(670, 176);
            this.dtpDateDecision.Name = "dtpDateDecision";
            this.dtpDateDecision.Size = new System.Drawing.Size(216, 32);
            this.dtpDateDecision.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Type Décision :";
            // 
            // lbReferenceNext
            // 
            this.lbReferenceNext.AutoSize = true;
            this.lbReferenceNext.Location = new System.Drawing.Point(635, 144);
            this.lbReferenceNext.Name = "lbReferenceNext";
            this.lbReferenceNext.Size = new System.Drawing.Size(24, 24);
            this.lbReferenceNext.TabIndex = 21;
            this.lbReferenceNext.Text = "X";
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(387, 268);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(136, 48);
            this.btValider.TabIndex = 20;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // lbLibelleNext
            // 
            this.lbLibelleNext.AutoSize = true;
            this.lbLibelleNext.Location = new System.Drawing.Point(597, 105);
            this.lbLibelleNext.Name = "lbLibelleNext";
            this.lbLibelleNext.Size = new System.Drawing.Size(24, 24);
            this.lbLibelleNext.TabIndex = 19;
            this.lbLibelleNext.Text = "X";
            // 
            // lbNumeroNext
            // 
            this.lbNumeroNext.AutoSize = true;
            this.lbNumeroNext.Location = new System.Drawing.Point(610, 69);
            this.lbNumeroNext.Name = "lbNumeroNext";
            this.lbNumeroNext.Size = new System.Drawing.Size(24, 24);
            this.lbNumeroNext.TabIndex = 17;
            this.lbNumeroNext.Text = "X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(502, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 24);
            this.label14.TabIndex = 16;
            this.label14.Text = "Date Décision :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(503, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 24);
            this.label15.TabIndex = 15;
            this.label15.Text = "Référence :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(503, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 24);
            this.label16.TabIndex = 14;
            this.label16.Text = "Libellé :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(502, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 24);
            this.label18.TabIndex = 12;
            this.label18.Text = "Numéro :";
            // 
            // lbDateNorme
            // 
            this.lbDateNorme.AutoSize = true;
            this.lbDateNorme.Location = new System.Drawing.Point(174, 220);
            this.lbDateNorme.Name = "lbDateNorme";
            this.lbDateNorme.Size = new System.Drawing.Size(24, 24);
            this.lbDateNorme.TabIndex = 11;
            this.lbDateNorme.Text = "X";
            // 
            // lbNorme
            // 
            this.lbNorme.AutoSize = true;
            this.lbNorme.Location = new System.Drawing.Point(122, 182);
            this.lbNorme.Name = "lbNorme";
            this.lbNorme.Size = new System.Drawing.Size(24, 24);
            this.lbNorme.TabIndex = 10;
            this.lbNorme.Text = "X";
            // 
            // lbLibelle
            // 
            this.lbLibelle.AutoSize = true;
            this.lbLibelle.Location = new System.Drawing.Point(121, 144);
            this.lbLibelle.Name = "lbLibelle";
            this.lbLibelle.Size = new System.Drawing.Size(24, 24);
            this.lbLibelle.TabIndex = 9;
            this.lbLibelle.Text = "X";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(102, 105);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(24, 24);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "X";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(135, 69);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(24, 24);
            this.lbNumero.TabIndex = 7;
            this.lbNumero.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Date Norme :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Norme :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Libellé :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numéro :";
            // 
            // lbMedicament
            // 
            this.lbMedicament.AutoSize = true;
            this.lbMedicament.Location = new System.Drawing.Point(310, 28);
            this.lbMedicament.Name = "lbMedicament";
            this.lbMedicament.Size = new System.Drawing.Size(24, 24);
            this.lbMedicament.TabIndex = 1;
            this.lbMedicament.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Modification du médicament :";
            // 
            // DecisionDuneEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(934, 761);
            this.Controls.Add(this.gbMettreAJourEtat);
            this.Controls.Add(this.lvMedicaments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DecisionDuneEtape";
            this.Text = "DecisionDuneEtape";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DecisionDuneEtape_Load);
            this.gbMettreAJourEtat.ResumeLayout(false);
            this.gbMettreAJourEtat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvMedicaments;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox gbMettreAJourEtat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMedicament;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDateNorme;
        private System.Windows.Forms.Label lbNorme;
        private System.Windows.Forms.Label lbLibelle;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbLibelleNext;
        private System.Windows.Forms.Label lbNumeroNext;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbReferenceNext;
        private System.Windows.Forms.DateTimePicker dtpDateDecision;
        private System.Windows.Forms.ComboBox cbTypeDécision;
    }
}