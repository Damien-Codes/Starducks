namespace Starducks
{
    partial class FormAccueil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTDéconnexion = new System.Windows.Forms.Button();
            this.BTBoissons = new System.Windows.Forms.Button();
            this.BTAccueil = new System.Windows.Forms.Button();
            this.LBId = new System.Windows.Forms.Label();
            this.lBIdR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BTDéconnexion);
            this.panel1.Controls.Add(this.BTBoissons);
            this.panel1.Controls.Add(this.BTAccueil);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 933);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Starducks.Properties.Resources.StartsDucks;
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BTDéconnexion
            // 
            this.BTDéconnexion.Location = new System.Drawing.Point(106, 652);
            this.BTDéconnexion.Margin = new System.Windows.Forms.Padding(4);
            this.BTDéconnexion.Name = "BTDéconnexion";
            this.BTDéconnexion.Size = new System.Drawing.Size(331, 94);
            this.BTDéconnexion.TabIndex = 2;
            this.BTDéconnexion.Text = "Deconnexion";
            this.BTDéconnexion.UseVisualStyleBackColor = true;
            this.BTDéconnexion.Click += new System.EventHandler(this.BTDéconnexion_Click);
            // 
            // BTBoissons
            // 
            this.BTBoissons.Location = new System.Drawing.Point(106, 446);
            this.BTBoissons.Margin = new System.Windows.Forms.Padding(4);
            this.BTBoissons.Name = "BTBoissons";
            this.BTBoissons.Size = new System.Drawing.Size(331, 94);
            this.BTBoissons.TabIndex = 1;
            this.BTBoissons.Text = "Boissons";
            this.BTBoissons.UseVisualStyleBackColor = true;
            this.BTBoissons.Click += new System.EventHandler(this.BTBoissons_Click);
            // 
            // BTAccueil
            // 
            this.BTAccueil.Location = new System.Drawing.Point(106, 250);
            this.BTAccueil.Margin = new System.Windows.Forms.Padding(4);
            this.BTAccueil.Name = "BTAccueil";
            this.BTAccueil.Size = new System.Drawing.Size(331, 94);
            this.BTAccueil.TabIndex = 0;
            this.BTAccueil.Text = "Accueil";
            this.BTAccueil.UseVisualStyleBackColor = true;
            // 
            // LBId
            // 
            this.LBId.AutoSize = true;
            this.LBId.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBId.Location = new System.Drawing.Point(930, 223);
            this.LBId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBId.Name = "LBId";
            this.LBId.Size = new System.Drawing.Size(190, 69);
            this.LBId.TabIndex = 52;
            this.LBId.Text = "gubhij";
            this.LBId.Click += new System.EventHandler(this.LBId_Click);
            // 
            // lBIdR
            // 
            this.lBIdR.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBIdR.ForeColor = System.Drawing.Color.OliveDrab;
            this.lBIdR.Location = new System.Drawing.Point(730, 292);
            this.lBIdR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBIdR.Name = "lBIdR";
            this.lBIdR.Size = new System.Drawing.Size(725, 483);
            this.lBIdR.TabIndex = 51;
            this.lBIdR.Text = "Vous pouvez reservez une ou plusieurs boissons pour vous réchauffez ou bien pour " +
    "passer de bon temps en notre compagnies.";
            this.lBIdR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(854, 69);
            this.label1.TabIndex = 50;
            this.label1.Text = "Bienvenue chez Staducks ^__^";
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.LBId);
            this.Controls.Add(this.lBIdR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccueil";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAccueil";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTAccueil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTDéconnexion;
        private System.Windows.Forms.Button BTBoissons;
        private System.Windows.Forms.Label LBId;
        private System.Windows.Forms.Label lBIdR;
        private System.Windows.Forms.Label label1;
    }
}