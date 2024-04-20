namespace Starducks
{
    partial class FormReserveBoissonsView
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReserver = new System.Windows.Forms.Button();
            this.BTVoirBoissons = new System.Windows.Forms.Button();
            this.BTBoissons = new System.Windows.Forms.Button();
            this.BTAccueil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTDéconnexion = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 46);
            this.label5.TabIndex = 75;
            this.label5.Text = "Nos Boissons";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(457, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 546);
            this.dataGridView1.TabIndex = 74;
            // 
            // btnReserver
            // 
            this.btnReserver.Location = new System.Drawing.Point(501, 713);
            this.btnReserver.Margin = new System.Windows.Forms.Padding(4);
            this.btnReserver.Name = "btnReserver";
            this.btnReserver.Size = new System.Drawing.Size(465, 268);
            this.btnReserver.TabIndex = 73;
            this.btnReserver.Text = "Réservé une boissons";
            this.btnReserver.UseVisualStyleBackColor = true;
            this.btnReserver.Click += new System.EventHandler(this.btnReserver_Click);
            // 
            // BTVoirBoissons
            // 
            this.BTVoirBoissons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTVoirBoissons.Location = new System.Drawing.Point(1117, 713);
            this.BTVoirBoissons.Margin = new System.Windows.Forms.Padding(4);
            this.BTVoirBoissons.Name = "BTVoirBoissons";
            this.BTVoirBoissons.Size = new System.Drawing.Size(462, 259);
            this.BTVoirBoissons.TabIndex = 67;
            this.BTVoirBoissons.Text = "Voir les Boissons";
            this.BTVoirBoissons.UseVisualStyleBackColor = true;
            this.BTVoirBoissons.Click += new System.EventHandler(this.BTVoirBoissons_Click);
            // 
            // BTBoissons
            // 
            this.BTBoissons.Location = new System.Drawing.Point(71, 600);
            this.BTBoissons.Margin = new System.Windows.Forms.Padding(4);
            this.BTBoissons.Name = "BTBoissons";
            this.BTBoissons.Size = new System.Drawing.Size(290, 94);
            this.BTBoissons.TabIndex = 1;
            this.BTBoissons.Text = "Boissons";
            this.BTBoissons.UseVisualStyleBackColor = true;
            // 
            // BTAccueil
            // 
            this.BTAccueil.Location = new System.Drawing.Point(71, 335);
            this.BTAccueil.Margin = new System.Windows.Forms.Padding(4);
            this.BTAccueil.Name = "BTAccueil";
            this.BTAccueil.Size = new System.Drawing.Size(290, 94);
            this.BTAccueil.TabIndex = 0;
            this.BTAccueil.Text = "Accueil";
            this.BTAccueil.UseVisualStyleBackColor = true;
            this.BTAccueil.Click += new System.EventHandler(this.BTAccueil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(870, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 46);
            this.label1.TabIndex = 63;
            this.label1.Text = "Nos Boissons";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.BTDéconnexion);
            this.panel1.Controls.Add(this.BTBoissons);
            this.panel1.Controls.Add(this.pictureBoxImage);
            this.panel1.Controls.Add(this.BTAccueil);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 1067);
            this.panel1.TabIndex = 61;
            // 
            // BTDéconnexion
            // 
            this.BTDéconnexion.Location = new System.Drawing.Point(71, 840);
            this.BTDéconnexion.Margin = new System.Windows.Forms.Padding(4);
            this.BTDéconnexion.Name = "BTDéconnexion";
            this.BTDéconnexion.Size = new System.Drawing.Size(290, 94);
            this.BTDéconnexion.TabIndex = 2;
            this.BTDéconnexion.Text = "Deconnexion";
            this.BTDéconnexion.UseVisualStyleBackColor = true;
            this.BTDéconnexion.Click += new System.EventHandler(this.BTDéconnexion_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Image = global::Starducks.Properties.Resources.StartsDucks;
            this.pictureBoxImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(412, 267);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 43;
            this.pictureBoxImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormReserveBoissonsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1898, 1029);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReserver);
            this.Controls.Add(this.BTVoirBoissons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormReserveBoissonsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReserveBoissonsView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReserver;
        private System.Windows.Forms.Button BTVoirBoissons;
        private System.Windows.Forms.Button BTBoissons;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button BTAccueil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTDéconnexion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}