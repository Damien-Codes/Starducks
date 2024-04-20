namespace Starducks
{
    partial class FormReserveBoissons
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BTDéconnexion = new System.Windows.Forms.Button();
            this.BTBoissons = new System.Windows.Forms.Button();
            this.BTAccueil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lBIdV = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BTDéconnexion
            // 
            this.BTDéconnexion.Location = new System.Drawing.Point(58, 668);
            this.BTDéconnexion.Name = "BTDéconnexion";
            this.BTDéconnexion.Size = new System.Drawing.Size(248, 76);
            this.BTDéconnexion.TabIndex = 2;
            this.BTDéconnexion.Text = "Deconnexion";
            this.BTDéconnexion.UseVisualStyleBackColor = true;
            this.BTDéconnexion.Click += new System.EventHandler(this.BTDéconnexion_Click);
            // 
            // BTBoissons
            // 
            this.BTBoissons.Location = new System.Drawing.Point(54, 461);
            this.BTBoissons.Name = "BTBoissons";
            this.BTBoissons.Size = new System.Drawing.Size(248, 76);
            this.BTBoissons.TabIndex = 1;
            this.BTBoissons.Text = "Boissons";
            this.BTBoissons.UseVisualStyleBackColor = true;
            this.BTBoissons.Click += new System.EventHandler(this.BTBoissons_Click);
            // 
            // BTAccueil
            // 
            this.BTAccueil.Location = new System.Drawing.Point(54, 263);
            this.BTAccueil.Name = "BTAccueil";
            this.BTAccueil.Size = new System.Drawing.Size(248, 76);
            this.BTAccueil.TabIndex = 0;
            this.BTAccueil.Text = "Accueil";
            this.BTAccueil.UseVisualStyleBackColor = true;
            this.BTAccueil.Click += new System.EventHandler(this.BTAccueil_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.BTDéconnexion);
            this.panel1.Controls.Add(this.BTBoissons);
            this.panel1.Controls.Add(this.pictureBoxImage);
            this.panel1.Controls.Add(this.BTAccueil);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 865);
            this.panel1.TabIndex = 46;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Image = global::Starducks.Properties.Resources.StartsDucks;
            this.pictureBoxImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(425, 217);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 43;
            this.pictureBoxImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(517, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1032, 558);
            this.label2.TabIndex = 48;
            this.label2.Text = "Vous pouvez reservez une ou plusieurs boissons, pour vous réchauffez ou bien pour" +
    " passer du bon temps en notre compagnies.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 55);
            this.label1.TabIndex = 47;
            this.label1.Text = "Bienvenue chez Staducks ^__^";
            // 
            // lBIdV
            // 
            this.lBIdV.AutoSize = true;
            this.lBIdV.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBIdV.Location = new System.Drawing.Point(1332, 111);
            this.lBIdV.Name = "lBIdV";
            this.lBIdV.Size = new System.Drawing.Size(72, 55);
            this.lBIdV.TabIndex = 49;
            this.lBIdV.Text = "ID";
            this.lBIdV.Click += new System.EventHandler(this.lBIdV_Click);
            // 
            // FormReserveBoissons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 865);
            this.Controls.Add(this.lBIdV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormReserveBoissons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReserveBoissons";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BTDéconnexion;
        private System.Windows.Forms.Button BTBoissons;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button BTAccueil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lBIdV;
    }
}