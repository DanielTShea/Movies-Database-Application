
namespace _1630SemesterProject
{
    partial class FormAddMovies
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
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelRottenTomatoesScore = new System.Windows.Forms.Label();
            this.labelEarnings = new System.Windows.Forms.Label();
            this.labelAddTitle = new System.Windows.Forms.Label();
            this.textBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxRTScore = new System.Windows.Forms.TextBox();
            this.textBoxEarnings = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.AutoSize = true;
            this.labelMovieTitle.Location = new System.Drawing.Point(315, 176);
            this.labelMovieTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(87, 20);
            this.labelMovieTitle.TabIndex = 0;
            this.labelMovieTitle.Text = "Movie Title:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(348, 210);
            this.labelYear.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(47, 20);
            this.labelYear.TabIndex = 1;
            this.labelYear.Text = "Year:";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(327, 247);
            this.labelDirector.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(69, 20);
            this.labelDirector.TabIndex = 2;
            this.labelDirector.Text = "Director:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(338, 282);
            this.labelGenre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(58, 20);
            this.labelGenre.TabIndex = 3;
            this.labelGenre.Text = "Genre:";
            // 
            // labelRottenTomatoesScore
            // 
            this.labelRottenTomatoesScore.AutoSize = true;
            this.labelRottenTomatoesScore.Location = new System.Drawing.Point(220, 316);
            this.labelRottenTomatoesScore.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelRottenTomatoesScore.Name = "labelRottenTomatoesScore";
            this.labelRottenTomatoesScore.Size = new System.Drawing.Size(183, 20);
            this.labelRottenTomatoesScore.TabIndex = 4;
            this.labelRottenTomatoesScore.Text = "Rotten Tomatoes Score:";
            // 
            // labelEarnings
            // 
            this.labelEarnings.AutoSize = true;
            this.labelEarnings.Location = new System.Drawing.Point(246, 355);
            this.labelEarnings.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEarnings.Name = "labelEarnings";
            this.labelEarnings.Size = new System.Drawing.Size(153, 20);
            this.labelEarnings.TabIndex = 5;
            this.labelEarnings.Text = "Box Office Earnings:";
            // 
            // labelAddTitle
            // 
            this.labelAddTitle.AutoSize = true;
            this.labelAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTitle.Location = new System.Drawing.Point(233, 117);
            this.labelAddTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAddTitle.Name = "labelAddTitle";
            this.labelAddTitle.Size = new System.Drawing.Size(131, 26);
            this.labelAddTitle.TabIndex = 6;
            this.labelAddTitle.Text = "Add Movie ";
            // 
            // textBoxMovieTitle
            // 
            this.textBoxMovieTitle.Location = new System.Drawing.Point(402, 174);
            this.textBoxMovieTitle.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxMovieTitle.MaxLength = 50;
            this.textBoxMovieTitle.Name = "textBoxMovieTitle";
            this.textBoxMovieTitle.Size = new System.Drawing.Size(186, 26);
            this.textBoxMovieTitle.TabIndex = 1;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(402, 210);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxYear.MaxLength = 4;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(185, 26);
            this.textBoxYear.TabIndex = 2;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(402, 245);
            this.textBoxDirector.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxDirector.MaxLength = 50;
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(185, 26);
            this.textBoxDirector.TabIndex = 3;
            // 
            // textBoxRTScore
            // 
            this.textBoxRTScore.Location = new System.Drawing.Point(402, 317);
            this.textBoxRTScore.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxRTScore.MaxLength = 3;
            this.textBoxRTScore.Name = "textBoxRTScore";
            this.textBoxRTScore.Size = new System.Drawing.Size(185, 26);
            this.textBoxRTScore.TabIndex = 5;
            // 
            // textBoxEarnings
            // 
            this.textBoxEarnings.Location = new System.Drawing.Point(402, 354);
            this.textBoxEarnings.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxEarnings.MaxLength = 15;
            this.textBoxEarnings.Name = "textBoxEarnings";
            this.textBoxEarnings.Size = new System.Drawing.Size(185, 26);
            this.textBoxEarnings.TabIndex = 6;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Green;
            this.ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.ButtonAdd.Location = new System.Drawing.Point(215, 435);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(93, 35);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(322, 435);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(93, 35);
            this.ButtonClear.TabIndex = 8;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(587, 435);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(94, 34);
            this.ButtonClose.TabIndex = 9;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
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
            this.comboBoxGenre.Location = new System.Drawing.Point(402, 278);
            this.comboBoxGenre.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(186, 28);
            this.comboBoxGenre.TabIndex = 4;
            // 
            // FormAddMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 631);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.textBoxEarnings);
            this.Controls.Add(this.textBoxRTScore);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMovieTitle);
            this.Controls.Add(this.labelAddTitle);
            this.Controls.Add(this.labelEarnings);
            this.Controls.Add(this.labelRottenTomatoesScore);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMovieTitle);
            this.Location = new System.Drawing.Point(800, 400);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormAddMovies";
            this.Text = "Add Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelRottenTomatoesScore;
        private System.Windows.Forms.Label labelEarnings;
        private System.Windows.Forms.Label labelAddTitle;
        private System.Windows.Forms.TextBox textBoxMovieTitle;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxRTScore;
        private System.Windows.Forms.TextBox textBoxEarnings;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.ComboBox comboBoxGenre;
    }
}