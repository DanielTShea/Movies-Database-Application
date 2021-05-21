
namespace _1630SemesterProject
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.ButtonClose = new System.Windows.Forms.Button();
            this.RichTextBoxAbout = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(1132, 663);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(89, 35);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // RichTextBoxAbout
            // 
            this.RichTextBoxAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxAbout.ForeColor = System.Drawing.Color.Black;
            this.RichTextBoxAbout.Location = new System.Drawing.Point(37, 26);
            this.RichTextBoxAbout.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.RichTextBoxAbout.Name = "RichTextBoxAbout";
            this.RichTextBoxAbout.ReadOnly = true;
            this.RichTextBoxAbout.Size = new System.Drawing.Size(871, 610);
            this.RichTextBoxAbout.TabIndex = 2;
            this.RichTextBoxAbout.Text = resources.GetString("RichTextBoxAbout.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 664);
            this.Controls.Add(this.RichTextBoxAbout);
            this.Controls.Add(this.ButtonClose);
            this.Location = new System.Drawing.Point(800, 400);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormAbout";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.RichTextBox RichTextBoxAbout;
    }
}