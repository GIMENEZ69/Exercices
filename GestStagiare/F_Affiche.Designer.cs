
namespace GestStagiare
{
    partial class F_Affiche
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
            this.DTPNaissance = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtSection = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtStag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DTPNaissance
            // 
            this.DTPNaissance.Location = new System.Drawing.Point(207, 256);
            this.DTPNaissance.Name = "DTPNaissance";
            this.DTPNaissance.Size = new System.Drawing.Size(159, 20);
            this.DTPNaissance.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 48);
            this.button2.TabIndex = 23;
            this.button2.Text = "Terminer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtSection
            // 
            this.TxtSection.Location = new System.Drawing.Point(207, 207);
            this.TxtSection.MaxLength = 5;
            this.TxtSection.Name = "TxtSection";
            this.TxtSection.Size = new System.Drawing.Size(138, 20);
            this.TxtSection.TabIndex = 21;
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(207, 159);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(168, 20);
            this.TxtPrenom.TabIndex = 20;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(207, 114);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(168, 20);
            this.TxtNom.TabIndex = 19;
            // 
            // TxtStag
            // 
            this.TxtStag.Location = new System.Drawing.Point(207, 62);
            this.TxtStag.Name = "TxtStag";
            this.TxtStag.Size = new System.Drawing.Size(142, 20);
            this.TxtStag.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date de Naissance :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Section :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prénom Stagiaire :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nom Stagiare :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "N° Stagiaires :";
            // 
            // F_Affiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 541);
            this.Controls.Add(this.DTPNaissance);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtSection);
            this.Controls.Add(this.TxtPrenom);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.TxtStag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_Affiche";
            this.Text = "Affichage du Stagiaire N°";
            this.Load += new System.EventHandler(this.F_Affiche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPNaissance;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtSection;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtStag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}