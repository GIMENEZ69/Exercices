
namespace GestStagiare
{
    partial class FMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionStagiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cretionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheStagiareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeStagiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SL = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.gestionStagiaireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1092, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegarderToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // gestionStagiaireToolStripMenuItem
            // 
            this.gestionStagiaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cretionToolStripMenuItem,
            this.ficheStagiareToolStripMenuItem,
            this.listeStagiaireToolStripMenuItem});
            this.gestionStagiaireToolStripMenuItem.Name = "gestionStagiaireToolStripMenuItem";
            this.gestionStagiaireToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.gestionStagiaireToolStripMenuItem.Text = "Gestion Stagiaire";
            this.gestionStagiaireToolStripMenuItem.Click += new System.EventHandler(this.gestionStagiaireToolStripMenuItem_Click);
            // 
            // cretionToolStripMenuItem
            // 
            this.cretionToolStripMenuItem.Name = "cretionToolStripMenuItem";
            this.cretionToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cretionToolStripMenuItem.Text = "Creation";
            this.cretionToolStripMenuItem.Click += new System.EventHandler(this.cretionToolStripMenuItem_Click);
            // 
            // ficheStagiareToolStripMenuItem
            // 
            this.ficheStagiareToolStripMenuItem.Name = "ficheStagiareToolStripMenuItem";
            this.ficheStagiareToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ficheStagiareToolStripMenuItem.Text = "Fiche Stagiare";
            this.ficheStagiareToolStripMenuItem.Click += new System.EventHandler(this.ficheStagiareToolStripMenuItem_Click);
            // 
            // listeStagiaireToolStripMenuItem
            // 
            this.listeStagiaireToolStripMenuItem.Name = "listeStagiaireToolStripMenuItem";
            this.listeStagiaireToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listeStagiaireToolStripMenuItem.Text = "Liste Stagiaire";
            this.listeStagiaireToolStripMenuItem.Click += new System.EventHandler(this.listeStagiaireToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1092, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // SL
            // 
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(118, 17);
            this.SL.Text = "toolStripStatusLabel1";
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 529);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "Application des gestions des stagiaires";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionStagiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cretionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheStagiareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeStagiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel SL;
    }
}

