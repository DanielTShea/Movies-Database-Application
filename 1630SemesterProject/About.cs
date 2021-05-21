using System;
using System.Drawing;
using System.Windows.Forms;

namespace _1630SemesterProject
{
    public partial class FormAbout : Form
    {

       
        
        public FormAbout()
        {
            InitializeComponent();

            // Center window on screen
            // Source: https://stackoverflow.com/questions/21171764/how-to-position-the-opening-form-at-specific-location-in-c-sharp-windows-forms
            this.StartPosition = FormStartPosition.Manual;

            // Below code to change formatting of text in About form
            // Received coding support from Owen Okuley on this form
            RichTextBoxAbout.SelectionStart = 0;
            RichTextBoxAbout.SelectionLength = 25;
            RichTextBoxAbout.SelectionFont = new System.Drawing.Font("Times New Roman", 16);
            RichTextBoxAbout.SelectionColor = Color.Blue;



            RichTextBoxAbout.SelectionStart = 26;
            RichTextBoxAbout.SelectionLength = 129;
            RichTextBoxAbout.SelectionFont = new System.Drawing.Font("Times New Roman", 12);
            RichTextBoxAbout.SelectionColor = Color.Black;
            


            RichTextBoxAbout.SelectionStart = 129;
            RichTextBoxAbout.SelectionLength = 181;
            RichTextBoxAbout.SelectionFont = new System.Drawing.Font("Times New Roman", 12);
            RichTextBoxAbout.SelectionFont = new Font(RichTextBoxAbout.Font, FontStyle.Bold);

            RichTextBoxAbout.SelectionStart = 182;
            RichTextBoxAbout.SelectionLength = 209;
            RichTextBoxAbout.SelectionFont = new System.Drawing.Font("Times New Roman", 12);
            RichTextBoxAbout.SelectionColor = Color.Black;



            this.RichTextBoxAbout.SelectionStart = this.RichTextBoxAbout.Text.Length;
            ;

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
