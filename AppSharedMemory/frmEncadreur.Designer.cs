namespace AppSharedMemory
{
    partial class frmEncadreur
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtSpecialite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgEncadreur = new System.Windows.Forms.DataGridView();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncadreur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Specialite";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(68, 172);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(285, 26);
            this.txtNom.TabIndex = 3;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(68, 273);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(285, 26);
            this.txtPrenom.TabIndex = 4;
            // 
            // txtSpecialite
            // 
            this.txtSpecialite.Location = new System.Drawing.Point(68, 373);
            this.txtSpecialite.Name = "txtSpecialite";
            this.txtSpecialite.Size = new System.Drawing.Size(285, 26);
            this.txtSpecialite.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.label4.Location = new System.Drawing.Point(267, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(608, 55);
            this.label4.TabIndex = 6;
            this.label4.Text = "GESTION ENCADREURS";
            // 
            // dtgEncadreur
            // 
            this.dtgEncadreur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEncadreur.Location = new System.Drawing.Point(498, 172);
            this.dtgEncadreur.Name = "dtgEncadreur";
            this.dtgEncadreur.RowHeadersWidth = 62;
            this.dtgEncadreur.RowTemplate.Height = 28;
            this.dtgEncadreur.Size = new System.Drawing.Size(502, 455);
            this.dtgEncadreur.TabIndex = 7;
            // 
            // btnAjout
            // 
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(68, 438);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(167, 42);
            this.btnAjout.TabIndex = 8;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            // 
            // btnModif
            // 
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModif.Location = new System.Drawing.Point(68, 511);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(167, 42);
            this.btnModif.TabIndex = 9;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            // 
            // btnSupp
            // 
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.Location = new System.Drawing.Point(68, 585);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(167, 42);
            this.btnSupp.TabIndex = 10;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(498, 124);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(129, 42);
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // frmEncadreur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 698);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.dtgEncadreur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSpecialite);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEncadreur";
            this.Text = "Encadreur";
            this.Load += new System.EventHandler(this.frmEncadreur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEncadreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtSpecialite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgEncadreur;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnSelect;
    }
}