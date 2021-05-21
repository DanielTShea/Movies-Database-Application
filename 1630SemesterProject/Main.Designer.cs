
namespace _1630SemesterProject
{
    partial class MovieManagerApplication
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Refresh1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaintenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewDatabase = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.MaintenceToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1650, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Refresh1ToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // Refresh1ToolStripMenuItem
            // 
            this.Refresh1ToolStripMenuItem.Name = "Refresh1ToolStripMenuItem";
            this.Refresh1ToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.Refresh1ToolStripMenuItem.Text = "Refresh";
            this.Refresh1ToolStripMenuItem.Click += new System.EventHandler(this.Refresh1ToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click_1);
            // 
            // MaintenceToolStripMenuItem
            // 
            this.MaintenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMovieToolStripMenuItem,
            this.UpdateMovieToolStripMenuItem,
            this.DeleteMovieToolStripMenuItem});
            this.MaintenceToolStripMenuItem.Name = "MaintenceToolStripMenuItem";
            this.MaintenceToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.MaintenceToolStripMenuItem.Text = "Maintenance";
            // 
            // AddMovieToolStripMenuItem
            // 
            this.AddMovieToolStripMenuItem.Name = "AddMovieToolStripMenuItem";
            this.AddMovieToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.AddMovieToolStripMenuItem.Text = "Add Movie";
            this.AddMovieToolStripMenuItem.Click += new System.EventHandler(this.AddMovieToolStripMenuItem_Click);
            // 
            // UpdateMovieToolStripMenuItem
            // 
            this.UpdateMovieToolStripMenuItem.Name = "UpdateMovieToolStripMenuItem";
            this.UpdateMovieToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.UpdateMovieToolStripMenuItem.Text = "Update Movie";
            this.UpdateMovieToolStripMenuItem.Click += new System.EventHandler(this.UpdateMovieToolStripMenuItem_Click_1);
            // 
            // DeleteMovieToolStripMenuItem
            // 
            this.DeleteMovieToolStripMenuItem.Name = "DeleteMovieToolStripMenuItem";
            this.DeleteMovieToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.DeleteMovieToolStripMenuItem.Text = "Delete Movie";
            this.DeleteMovieToolStripMenuItem.Click += new System.EventHandler(this.DeleteMovieToolStripMenuItem_Click_1);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutInformationToolStripMenuItem});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // AboutInformationToolStripMenuItem
            // 
            this.AboutInformationToolStripMenuItem.Name = "AboutInformationToolStripMenuItem";
            this.AboutInformationToolStripMenuItem.Size = new System.Drawing.Size(263, 34);
            this.AboutInformationToolStripMenuItem.Text = "About Information";
            this.AboutInformationToolStripMenuItem.Click += new System.EventHandler(this.AboutInformationToolStripMenuItem_Click_1);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(14, 50);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(223, 29);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Movies Master list";
            // 
            // dataGridViewDatabase
            // 
            this.dataGridViewDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatabase.Location = new System.Drawing.Point(10, 95);
            this.dataGridViewDatabase.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridViewDatabase.Name = "dataGridViewDatabase";
            this.dataGridViewDatabase.RowHeadersWidth = 123;
            this.dataGridViewDatabase.RowTemplate.Height = 46;
            this.dataGridViewDatabase.Size = new System.Drawing.Size(1609, 695);
            this.dataGridViewDatabase.TabIndex = 2;
            // 
            // MovieManagerApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 942);
            this.Controls.Add(this.dataGridViewDatabase);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(600, 300);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "MovieManagerApplication";
            this.Text = "Movie Manager Application";
            this.Load += new System.EventHandler(this.MovieManagerApplication_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MaintenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ToolStripMenuItem Refresh1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutInformationToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewDatabase;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
    }
}

