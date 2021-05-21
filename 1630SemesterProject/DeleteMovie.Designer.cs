
namespace _1630SemesterProject
{
    partial class FormDelete
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
            this.labelDeleteTitle = new System.Windows.Forms.Label();
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelRTScore = new System.Windows.Forms.Label();
            this.labelEarnings = new System.Windows.Forms.Label();
            this.textBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxRTScore = new System.Windows.Forms.TextBox();
            this.textBoxEarnings = new System.Windows.Forms.TextBox();
            this.ButtonFind = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelDeleteTitle
            // 
            this.labelDeleteTitle.AutoSize = true;
            this.labelDeleteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteTitle.Location = new System.Drawing.Point(204, 106);
            this.labelDeleteTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelDeleteTitle.Name = "labelDeleteTitle";
            this.labelDeleteTitle.Size = new System.Drawing.Size(304, 29);
            this.labelDeleteTitle.TabIndex = 0;
            this.labelDeleteTitle.Text = "Delete Movie Information";
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.AutoSize = true;
            this.labelMovieTitle.Location = new System.Drawing.Point(295, 167);
            this.labelMovieTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(87, 20);
            this.labelMovieTitle.TabIndex = 1;
            this.labelMovieTitle.Text = "Movie Title:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(335, 209);
            this.labelYear.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(47, 20);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Year:";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(314, 249);
            this.labelDirector.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(69, 20);
            this.labelDirector.TabIndex = 3;
            this.labelDirector.Text = "Director:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(325, 284);
            this.labelGenre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(58, 20);
            this.labelGenre.TabIndex = 4;
            this.labelGenre.Text = "Genre:";
            // 
            // labelRTScore
            // 
            this.labelRTScore.AutoSize = true;
            this.labelRTScore.Location = new System.Drawing.Point(207, 323);
            this.labelRTScore.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelRTScore.Name = "labelRTScore";
            this.labelRTScore.Size = new System.Drawing.Size(183, 20);
            this.labelRTScore.TabIndex = 5;
            this.labelRTScore.Text = "Rotten Tomatoes Score:";
            // 
            // labelEarnings
            // 
            this.labelEarnings.AutoSize = true;
            this.labelEarnings.Location = new System.Drawing.Point(233, 359);
            this.labelEarnings.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEarnings.Name = "labelEarnings";
            this.labelEarnings.Size = new System.Drawing.Size(153, 20);
            this.labelEarnings.TabIndex = 6;
            this.labelEarnings.Text = "Box Office Earnings:";
            // 
            // textBoxMovieTitle
            // 
            this.textBoxMovieTitle.Location = new System.Drawing.Point(382, 165);
            this.textBoxMovieTitle.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxMovieTitle.MaxLength = 50;
            this.textBoxMovieTitle.Name = "textBoxMovieTitle";
            this.textBoxMovieTitle.Size = new System.Drawing.Size(180, 26);
            this.textBoxMovieTitle.TabIndex = 1;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(382, 207);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxYear.MaxLength = 4;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.ReadOnly = true;
            this.textBoxYear.Size = new System.Drawing.Size(180, 26);
            this.textBoxYear.TabIndex = 3;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(382, 246);
            this.textBoxDirector.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxDirector.MaxLength = 50;
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.ReadOnly = true;
            this.textBoxDirector.Size = new System.Drawing.Size(180, 26);
            this.textBoxDirector.TabIndex = 4;
            // 
            // textBoxRTScore
            // 
            this.textBoxRTScore.Location = new System.Drawing.Point(382, 321);
            this.textBoxRTScore.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxRTScore.MaxLength = 3;
            this.textBoxRTScore.Name = "textBoxRTScore";
            this.textBoxRTScore.ReadOnly = true;
            this.textBoxRTScore.Size = new System.Drawing.Size(180, 26);
            this.textBoxRTScore.TabIndex = 6;
            // 
            // textBoxEarnings
            // 
            this.textBoxEarnings.Location = new System.Drawing.Point(382, 357);
            this.textBoxEarnings.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxEarnings.Name = "textBoxEarnings";
            this.textBoxEarnings.ReadOnly = true;
            this.textBoxEarnings.Size = new System.Drawing.Size(180, 26);
            this.textBoxEarnings.TabIndex = 7;
            // 
            // ButtonFind
            // 
            this.ButtonFind.Location = new System.Drawing.Point(575, 167);
            this.ButtonFind.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(90, 34);
            this.ButtonFind.TabIndex = 2;
            this.ButtonFind.Text = "Find";
            this.ButtonFind.UseVisualStyleBackColor = true;
            this.ButtonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Green;
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(197, 445);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(101, 37);
            this.ButtonDelete.TabIndex = 8;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click_1);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(313, 446);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(101, 35);
            this.ButtonClear.TabIndex = 9;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click_1);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(590, 445);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(99, 34);
            this.ButtonClose.TabIndex = 10;
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
            this.comboBoxGenre.Location = new System.Drawing.Point(382, 284);
            this.comboBoxGenre.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(180, 28);
            this.comboBoxGenre.TabIndex = 5;
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 631);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonFind);
            this.Controls.Add(this.textBoxEarnings);
            this.Controls.Add(this.textBoxRTScore);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMovieTitle);
            this.Controls.Add(this.labelEarnings);
            this.Controls.Add(this.labelRTScore);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMovieTitle);
            this.Controls.Add(this.labelDeleteTitle);
            this.Location = new System.Drawing.Point(800, 400);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormDelete";
            this.Text = "Delete Movie Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeleteTitle;
        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelRTScore;
        private System.Windows.Forms.Label labelEarnings;
        private System.Windows.Forms.TextBox textBoxMovieTitle;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxRTScore;
        private System.Windows.Forms.TextBox textBoxEarnings;
        private System.Windows.Forms.Button ButtonFind;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.ComboBox comboBoxGenre;
    }
}