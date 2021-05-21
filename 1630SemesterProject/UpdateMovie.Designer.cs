
namespace _1630SemesterProject
{
    partial class FormUpdate
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
            this.labelUpdateTitle = new System.Windows.Forms.Label();
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelRTScore = new System.Windows.Forms.Label();
            this.labelEarnings = new System.Windows.Forms.Label();
            this.textBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxRTScore = new System.Windows.Forms.TextBox();
            this.textBoxEarnings = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonFind = new System.Windows.Forms.Button();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelUpdateTitle
            // 
            this.labelUpdateTitle.AutoSize = true;
            this.labelUpdateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateTitle.Location = new System.Drawing.Point(204, 95);
            this.labelUpdateTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelUpdateTitle.Name = "labelUpdateTitle";
            this.labelUpdateTitle.Size = new System.Drawing.Size(311, 29);
            this.labelUpdateTitle.TabIndex = 0;
            this.labelUpdateTitle.Text = "Update Movie Information";
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.AutoSize = true;
            this.labelMovieTitle.Location = new System.Drawing.Point(282, 159);
            this.labelMovieTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(87, 20);
            this.labelMovieTitle.TabIndex = 1;
            this.labelMovieTitle.Text = "Movie Title:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(322, 192);
            this.labelYear.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(47, 20);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Year:";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(301, 228);
            this.labelDirector.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(69, 20);
            this.labelDirector.TabIndex = 3;
            this.labelDirector.Text = "Director:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(312, 266);
            this.labelGenre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(58, 20);
            this.labelGenre.TabIndex = 4;
            this.labelGenre.Text = "Genre:";
            // 
            // labelRTScore
            // 
            this.labelRTScore.AutoSize = true;
            this.labelRTScore.Location = new System.Drawing.Point(198, 303);
            this.labelRTScore.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelRTScore.Name = "labelRTScore";
            this.labelRTScore.Size = new System.Drawing.Size(183, 20);
            this.labelRTScore.TabIndex = 5;
            this.labelRTScore.Text = "Rotten Tomatoes Score:";
            // 
            // labelEarnings
            // 
            this.labelEarnings.AutoSize = true;
            this.labelEarnings.Location = new System.Drawing.Point(224, 344);
            this.labelEarnings.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEarnings.Name = "labelEarnings";
            this.labelEarnings.Size = new System.Drawing.Size(153, 20);
            this.labelEarnings.TabIndex = 6;
            this.labelEarnings.Text = "Box Office Earnings:";
            // 
            // textBoxMovieTitle
            // 
            this.textBoxMovieTitle.Location = new System.Drawing.Point(373, 155);
            this.textBoxMovieTitle.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxMovieTitle.MaxLength = 50;
            this.textBoxMovieTitle.Name = "textBoxMovieTitle";
            this.textBoxMovieTitle.Size = new System.Drawing.Size(177, 26);
            this.textBoxMovieTitle.TabIndex = 1;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(373, 226);
            this.textBoxDirector.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxDirector.MaxLength = 50;
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(177, 26);
            this.textBoxDirector.TabIndex = 4;
            // 
            // textBoxRTScore
            // 
            this.textBoxRTScore.Location = new System.Drawing.Point(373, 302);
            this.textBoxRTScore.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxRTScore.MaxLength = 3;
            this.textBoxRTScore.Name = "textBoxRTScore";
            this.textBoxRTScore.Size = new System.Drawing.Size(177, 26);
            this.textBoxRTScore.TabIndex = 7;
            // 
            // textBoxEarnings
            // 
            this.textBoxEarnings.Location = new System.Drawing.Point(373, 342);
            this.textBoxEarnings.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxEarnings.MaxLength = 15;
            this.textBoxEarnings.Name = "textBoxEarnings";
            this.textBoxEarnings.Size = new System.Drawing.Size(177, 26);
            this.textBoxEarnings.TabIndex = 8;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(374, 190);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxYear.MaxLength = 4;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(176, 26);
            this.textBoxYear.TabIndex = 3;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.Green;
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.Location = new System.Drawing.Point(182, 418);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(94, 38);
            this.ButtonUpdate.TabIndex = 9;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click_1);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(290, 419);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(93, 38);
            this.ButtonClear.TabIndex = 10;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click_1);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(556, 418);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(93, 38);
            this.ButtonClose.TabIndex = 11;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click_1);
            // 
            // ButtonFind
            // 
            this.ButtonFind.Location = new System.Drawing.Point(562, 155);
            this.ButtonFind.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(88, 33);
            this.ButtonFind.TabIndex = 2;
            this.ButtonFind.Text = "Find";
            this.ButtonFind.UseVisualStyleBackColor = true;
            this.ButtonFind.Click += new System.EventHandler(this.ButtonFind_Click_1);
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "Animation",
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Western"});
            this.comboBoxGenre.Location = new System.Drawing.Point(373, 264);
            this.comboBoxGenre.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(177, 28);
            this.comboBoxGenre.TabIndex = 6;
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 631);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.ButtonFind);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxEarnings);
            this.Controls.Add(this.textBoxRTScore);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.textBoxMovieTitle);
            this.Controls.Add(this.labelEarnings);
            this.Controls.Add(this.labelRTScore);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMovieTitle);
            this.Controls.Add(this.labelUpdateTitle);
            this.Location = new System.Drawing.Point(800, 400);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormUpdate";
            this.Text = "Update Movie Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUpdateTitle;
        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelRTScore;
        private System.Windows.Forms.Label labelEarnings;
        private System.Windows.Forms.TextBox textBoxMovieTitle;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxRTScore;
        private System.Windows.Forms.TextBox textBoxEarnings;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonFind;
        private System.Windows.Forms.ComboBox comboBoxGenre;
    }
}