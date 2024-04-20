namespace Starducks
{
    partial class FormBoissons
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
            this.BTDéconnexion = new System.Windows.Forms.Button();
            this.BTBoissons = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.BTAccueil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTAjout = new System.Windows.Forms.Button();
            this.BTModifier = new System.Windows.Forms.Button();
            this.BTSupprimer = new System.Windows.Forms.Button();
            this.BTVoirBoissons = new System.Windows.Forms.Button();
            this.TBPrix = new System.Windows.Forms.TextBox();
            this.TBNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUploadImg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.BTDéconnexion);
            this.panel1.Controls.Add(this.BTBoissons);
            this.panel1.Controls.Add(this.pictureBoxImage);
            this.panel1.Controls.Add(this.BTAccueil);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 866);
            this.panel1.TabIndex = 1;
            // 
            // BTDéconnexion
            // 
            this.BTDéconnexion.Location = new System.Drawing.Point(63, 539);
            this.BTDéconnexion.Name = "BTDéconnexion";
            this.BTDéconnexion.Size = new System.Drawing.Size(248, 76);
            this.BTDéconnexion.TabIndex = 2;
            this.BTDéconnexion.Text = "Deconnexion";
            this.BTDéconnexion.UseVisualStyleBackColor = true;
            this.BTDéconnexion.Click += new System.EventHandler(this.BTDéconnexion_Click);
            // 
            // BTBoissons
            // 
            this.BTBoissons.Location = new System.Drawing.Point(63, 403);
            this.BTBoissons.Name = "BTBoissons";
            this.BTBoissons.Size = new System.Drawing.Size(248, 76);
            this.BTBoissons.TabIndex = 1;
            this.BTBoissons.Text = "Boissons";
            this.BTBoissons.UseVisualStyleBackColor = true;
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
            // BTAccueil
            // 
            this.BTAccueil.Location = new System.Drawing.Point(63, 258);
            this.BTAccueil.Name = "BTAccueil";
            this.BTAccueil.Size = new System.Drawing.Size(248, 76);
            this.BTAccueil.TabIndex = 0;
            this.BTAccueil.Text = "Accueil";
            this.BTAccueil.UseVisualStyleBackColor = true;
            this.BTAccueil.Click += new System.EventHandler(this.BTAccueil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(522, 540);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nos Boissons";
            // 
            // BTAjout
            // 
            this.BTAjout.Location = new System.Drawing.Point(801, 433);
            this.BTAjout.Name = "BTAjout";
            this.BTAjout.Size = new System.Drawing.Size(136, 47);
            this.BTAjout.TabIndex = 34;
            this.BTAjout.Text = "Ajouter";
            this.BTAjout.UseVisualStyleBackColor = true;
            this.BTAjout.Click += new System.EventHandler(this.BTAjout_Click);
            // 
            // BTModifier
            // 
            this.BTModifier.Location = new System.Drawing.Point(801, 528);
            this.BTModifier.Name = "BTModifier";
            this.BTModifier.Size = new System.Drawing.Size(136, 47);
            this.BTModifier.TabIndex = 35;
            this.BTModifier.Text = "Modifier";
            this.BTModifier.UseVisualStyleBackColor = true;
            this.BTModifier.Click += new System.EventHandler(this.BTModifier_Click);
            // 
            // BTSupprimer
            // 
            this.BTSupprimer.Location = new System.Drawing.Point(801, 611);
            this.BTSupprimer.Name = "BTSupprimer";
            this.BTSupprimer.Size = new System.Drawing.Size(136, 47);
            this.BTSupprimer.TabIndex = 36;
            this.BTSupprimer.Text = "Supprimer";
            this.BTSupprimer.UseVisualStyleBackColor = true;
            this.BTSupprimer.Click += new System.EventHandler(this.BTSupprimer_Click);
            // 
            // BTVoirBoissons
            // 
            this.BTVoirBoissons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTVoirBoissons.Location = new System.Drawing.Point(954, 457);
            this.BTVoirBoissons.Name = "BTVoirBoissons";
            this.BTVoirBoissons.Size = new System.Drawing.Size(116, 179);
            this.BTVoirBoissons.TabIndex = 37;
            this.BTVoirBoissons.Text = "Voir les Boissons";
            this.BTVoirBoissons.UseVisualStyleBackColor = true;
            this.BTVoirBoissons.Click += new System.EventHandler(this.BTVoirBoissons_Click);
            // 
            // TBPrix
            // 
            this.TBPrix.Location = new System.Drawing.Point(530, 493);
            this.TBPrix.Name = "TBPrix";
            this.TBPrix.Size = new System.Drawing.Size(121, 20);
            this.TBPrix.TabIndex = 38;
            // 
            // TBNom
            // 
            this.TBNom.Location = new System.Drawing.Point(530, 433);
            this.TBNom.Name = "TBNom";
            this.TBNom.Size = new System.Drawing.Size(121, 20);
            this.TBNom.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Image";
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.Location = new System.Drawing.Point(671, 567);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(120, 61);
            this.btnUploadImg.TabIndex = 44;
            this.btnUploadImg.Text = "Charger une image";
            this.btnUploadImg.UseVisualStyleBackColor = true;
            this.btnUploadImg.Click += new System.EventHandler(this.btnUploadImg_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(462, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(591, 301);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormBoissons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 839);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUploadImg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBNom);
            this.Controls.Add(this.TBPrix);
            this.Controls.Add(this.BTVoirBoissons);
            this.Controls.Add(this.BTSupprimer);
            this.Controls.Add(this.BTModifier);
            this.Controls.Add(this.BTAjout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormBoissons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBoissons";
            this.Load += new System.EventHandler(this.FormBoissons_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTDéconnexion;
        private System.Windows.Forms.Button BTBoissons;
        private System.Windows.Forms.Button BTAccueil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTAjout;
        private System.Windows.Forms.Button BTModifier;
        private System.Windows.Forms.Button BTSupprimer;
        private System.Windows.Forms.Button BTVoirBoissons;
        private System.Windows.Forms.TextBox TBPrix;
        private System.Windows.Forms.TextBox TBNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button btnUploadImg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}