namespace AppSharedMemory
{
    partial class frmLogs
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
            this.dtgLogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLogs
            // 
            this.dtgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLogs.Location = new System.Drawing.Point(55, 25);
            this.dtgLogs.Name = "dtgLogs";
            this.dtgLogs.RowHeadersWidth = 62;
            this.dtgLogs.RowTemplate.Height = 28;
            this.dtgLogs.Size = new System.Drawing.Size(903, 610);
            this.dtgLogs.TabIndex = 0;
            // 
            // frmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 664);
            this.ControlBox = false;
            this.Controls.Add(this.dtgLogs);
            this.Name = "frmLogs";
            this.Text = "Gestion des logs";
            ((System.ComponentModel.ISupportInitialize)(this.dtgLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLogs;
    }
}