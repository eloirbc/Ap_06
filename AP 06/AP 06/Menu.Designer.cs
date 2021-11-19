namespace AP_06
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etapeNormeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workflowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.familleToolStripMenuItem,
            this.medicamentToolStripMenuItem,
            this.etapeToolStripMenuItem,
            this.etapeNormeeToolStripMenuItem,
            this.decisionToolStripMenuItem,
            this.workflowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.familleToolStripMenuItem.Text = "Famille";
            // 
            // medicamentToolStripMenuItem
            // 
            this.medicamentToolStripMenuItem.Name = "medicamentToolStripMenuItem";
            this.medicamentToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.medicamentToolStripMenuItem.Text = "Medicament";
            // 
            // etapeToolStripMenuItem
            // 
            this.etapeToolStripMenuItem.Name = "etapeToolStripMenuItem";
            this.etapeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.etapeToolStripMenuItem.Text = "Etape";
            // 
            // etapeNormeeToolStripMenuItem
            // 
            this.etapeNormeeToolStripMenuItem.Name = "etapeNormeeToolStripMenuItem";
            this.etapeNormeeToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.etapeNormeeToolStripMenuItem.Text = "EtapeNormee";
            // 
            // decisionToolStripMenuItem
            // 
            this.decisionToolStripMenuItem.Name = "decisionToolStripMenuItem";
            this.decisionToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.decisionToolStripMenuItem.Text = "Decision";
            // 
            // workflowToolStripMenuItem
            // 
            this.workflowToolStripMenuItem.Name = "workflowToolStripMenuItem";
            this.workflowToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.workflowToolStripMenuItem.Text = "Workflow";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(618, 832);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etapeNormeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workflowToolStripMenuItem;
    }
}