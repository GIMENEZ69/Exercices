
namespace Init_WinForm
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
            this.components = new System.ComponentModel.Container();
            this.CmdFermer = new System.Windows.Forms.Button();
            this.LblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CmdFermer
            // 
            this.CmdFermer.BackColor = System.Drawing.Color.Yellow;
            this.CmdFermer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdFermer.ForeColor = System.Drawing.Color.Sienna;
            this.CmdFermer.Location = new System.Drawing.Point(224, 196);
            this.CmdFermer.Name = "CmdFermer";
            this.CmdFermer.Size = new System.Drawing.Size(167, 41);
            this.CmdFermer.TabIndex = 0;
            this.CmdFermer.Text = "Fermer la fenêtre";
            this.CmdFermer.UseVisualStyleBackColor = false;
            this.CmdFermer.Click += new System.EventHandler(this.CmdFermer_Click);
            // 
            // LblTime
            // 
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.Location = new System.Drawing.Point(52, 47);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(443, 45);
            this.LblTime.TabIndex = 1;
            this.LblTime.Text = "label1";
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(528, 262);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.CmdFermer);
            this.Name = "Form1";
            this.Text = "Mon Horloge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdFermer;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Timer timer1;
    }
}

