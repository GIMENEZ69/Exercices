
namespace GestStagiare
{
    partial class FCreationStag
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtStag = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtSection = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DTPNaissance = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Stagiaires :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Stagiare :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom Stagiaire :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Section :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de Naissance :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtStag
            // 
            this.TxtStag.Location = new System.Drawing.Point(210, 75);
            this.TxtStag.Name = "TxtStag";
            this.TxtStag.Size = new System.Drawing.Size(142, 20);
            this.TxtStag.TabIndex = 5;
            this.TxtStag.TextChanged += new System.EventHandler(this.TxtStag_TextChanged);
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(210, 127);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(168, 20);
            this.TxtNom.TabIndex = 6;
            this.TxtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged_1);
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(210, 172);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(168, 20);
            this.TxtPrenom.TabIndex = 7;
            this.TxtPrenom.TextChanged += new System.EventHandler(this.TxtPrenom_TextChanged);
            // 
            // TxtSection
            // 
            this.TxtSection.Location = new System.Drawing.Point(210, 220);
            this.TxtSection.MaxLength = 5;
            this.TxtSection.Name = "TxtSection";
            this.TxtSection.Size = new System.Drawing.Size(138, 20);
            this.TxtSection.TabIndex = 8;
            this.TxtSection.TextChanged += new System.EventHandler(this.TxtSection_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enregistrer Stagiaire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 48);
            this.button2.TabIndex = 11;
            this.button2.Text = "Terminer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DTPNaissance
            // 
            this.DTPNaissance.Location = new System.Drawing.Point(210, 269);
            this.DTPNaissance.Name = "DTPNaissance";
            this.DTPNaissance.Size = new System.Drawing.Size(159, 20);
            this.DTPNaissance.TabIndex = 12;
            this.DTPNaissance.ValueChanged += new System.EventHandler(this.DTPNaissance_ValueChanged);
            // 
            // FCreationStag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 590);
            this.Controls.Add(this.DTPNaissance);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtSection);
            this.Controls.Add(this.TxtPrenom);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.TxtStag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FCreationStag";
            this.Text = "Creation d\'un stagiaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtStag;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtSection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker DTPNaissance;
    }
}