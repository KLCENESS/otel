namespace otel
{
    partial class HatirlatmaListe
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
            this.HatirlatmaListeGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.HatirlatmaListeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HatirlatmaListeGrid
            // 
            this.HatirlatmaListeGrid.AllowUserToAddRows = false;
            this.HatirlatmaListeGrid.AllowUserToDeleteRows = false;
            this.HatirlatmaListeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.HatirlatmaListeGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.HatirlatmaListeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HatirlatmaListeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HatirlatmaListeGrid.Location = new System.Drawing.Point(0, 0);
            this.HatirlatmaListeGrid.MultiSelect = false;
            this.HatirlatmaListeGrid.Name = "HatirlatmaListeGrid";
            this.HatirlatmaListeGrid.ReadOnly = true;
            this.HatirlatmaListeGrid.RowHeadersWidth = 51;
            this.HatirlatmaListeGrid.RowTemplate.Height = 24;
            this.HatirlatmaListeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HatirlatmaListeGrid.Size = new System.Drawing.Size(1182, 450);
            this.HatirlatmaListeGrid.TabIndex = 2;
            // 
            // HatirlatmaListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 450);
            this.Controls.Add(this.HatirlatmaListeGrid);
            this.Name = "HatirlatmaListe";
            this.RightToLeftLayout = true;
            this.Text = "Hatırlatma Listesi";
            this.Load += new System.EventHandler(this.HatirlatmaListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HatirlatmaListeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView HatirlatmaListeGrid;
    }
}