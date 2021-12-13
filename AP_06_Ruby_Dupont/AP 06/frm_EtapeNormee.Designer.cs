
namespace AP_06
{
    partial class frm_EtapeNormee
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
            this.lvEtapeNormee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btMaj = new System.Windows.Forms.Button();
            this.tbDateNorme = new System.Windows.Forms.TextBox();
            this.tbNorme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvEtapeNormee
            // 
            this.lvEtapeNormee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lvEtapeNormee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvEtapeNormee.FullRowSelect = true;
            this.lvEtapeNormee.HideSelection = false;
            this.lvEtapeNormee.Location = new System.Drawing.Point(42, 95);
            this.lvEtapeNormee.MultiSelect = false;
            this.lvEtapeNormee.Name = "lvEtapeNormee";
            this.lvEtapeNormee.Size = new System.Drawing.Size(499, 322);
            this.lvEtapeNormee.TabIndex = 3;
            this.lvEtapeNormee.UseCompatibleStateImageBehavior = false;
            this.lvEtapeNormee.View = System.Windows.Forms.View.Details;
            this.lvEtapeNormee.SelectedIndexChanged += new System.EventHandler(this.lvEtapeNormee_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N° de l\'étape";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Libelle de l\'étape";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Norme";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date de la norme";
            this.columnHeader4.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(992, 67);
            this.label1.TabIndex = 4;
            this.label1.Text = "MISE À JOUR DES ÉTAPES NORMÉES";
            // 
            // btMaj
            // 
            this.btMaj.Enabled = false;
            this.btMaj.Location = new System.Drawing.Point(573, 290);
            this.btMaj.Name = "btMaj";
            this.btMaj.Size = new System.Drawing.Size(449, 127);
            this.btMaj.TabIndex = 5;
            this.btMaj.Text = "Mettre à Jour";
            this.btMaj.UseVisualStyleBackColor = true;
            this.btMaj.Click += new System.EventHandler(this.btMaj_Click);
            // 
            // tbDateNorme
            // 
            this.tbDateNorme.Location = new System.Drawing.Point(689, 210);
            this.tbDateNorme.Name = "tbDateNorme";
            this.tbDateNorme.Size = new System.Drawing.Size(333, 22);
            this.tbDateNorme.TabIndex = 6;
            // 
            // tbNorme
            // 
            this.tbNorme.Location = new System.Drawing.Point(689, 145);
            this.tbNorme.Name = "tbNorme";
            this.tbNorme.Size = new System.Drawing.Size(333, 22);
            this.tbNorme.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Norme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date de la norme:";
            // 
            // frm_EtapeNormee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNorme);
            this.Controls.Add(this.tbDateNorme);
            this.Controls.Add(this.btMaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvEtapeNormee);
            this.Name = "frm_EtapeNormee";
            this.Text = "frm_EtapeNormee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_EtapeNormee_FormClosing);
            this.Load += new System.EventHandler(this.frm_EtapeNormee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEtapeNormee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btMaj;
        private System.Windows.Forms.TextBox tbDateNorme;
        private System.Windows.Forms.TextBox tbNorme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}