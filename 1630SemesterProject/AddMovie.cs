using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace _1630SemesterProject
{
    public partial class FormAddMovies : Form
    {
        public FormAddMovies()
        {
            InitializeComponent();
            // Center window on screen
            // Source: https://stackoverflow.com/questions/21171764/how-to-position-the-opening-form-at-specific-location-in-c-sharp-windows-forms
            this.StartPosition = FormStartPosition.Manual;

        }

        // Instance of class MovieEntry for Add Movie Form
        private MovieEntry addMovie = new MovieEntry();

       
        
        public Boolean IsEarningsValid(String earningsText)
        {
            // Method to ensure earnings value with only has 2 digit after decimal point
            // Source https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=net-5.0
            Regex earningsValid = new Regex(@"^\d{0,12}$|^\d{0,12}\.\d{0,2}$");
            if (earningsValid.IsMatch(earningsText))
                return false;
            else
                return true;

        }
        

        public Boolean AlreadyInDatabase(String movie)
        {
            // Method to check to see if movie title is already in the database
            Boolean inDatabase = false;
            string connectionString = MovieManagerApplication.GetConnectionString();
            string sqlCommand = "SELECT  Id, Title,  Year , Director, Genre, RottenTomatoesScore, TotalEarned  FROM  Movies " + "WHERE Title = @Title";
            string searchValue = movie;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                    {
                        command.Parameters.Add("Title", SqlDbType.VarChar, 50).Value = searchValue;
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                                inDatabase = true;
                        }
                        connection.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database conection failed. Error {ex.Message}");
            }
            return inDatabase;
        }


        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // If else statements to validate input from user
            bool isValid = false;
            int RTScore = 0; 

            if (String.IsNullOrEmpty(textBoxMovieTitle.Text))
            {
                MessageBox.Show("This value is required. Please enter a movie title");
            }
            else if (((String.IsNullOrEmpty(textBoxYear.Text)) || ((!int.TryParse(textBoxYear.Text, out int intYear)) ||
            (intYear > 2021))))
            {
                MessageBox.Show("The value is required. Please enter a valid year");
            }
            else if (String.IsNullOrEmpty(textBoxDirector.Text))
            {
                MessageBox.Show("This value is required. Please enter the name of the movie's director");
            }
            else if (comboBoxGenre.SelectedItem == null)
            {
                MessageBox.Show("This value is required. Please select the genre of the movie");
            }
            else if (textBoxRTScore.Text.Length > 0 && !int.TryParse(textBoxRTScore.Text, out RTScore)
                || (RTScore > 100 || RTScore < 0))
            {
                MessageBox.Show("The entry is invalid. Please enter a Rotten Tomatoes score less than or equal to 100.");
            }
            else if (textBoxEarnings.Text.Length > 0 && !decimal.TryParse(textBoxEarnings.Text, out decimal earnings))
            {
                MessageBox.Show("The entry is invalid. Please enter a valid earnings currency value.");
            }
            else if (textBoxEarnings.Text.Length > 0 && IsEarningsValid(textBoxEarnings.Text))
            {
                MessageBox.Show("The entry is too large. Please enter an earnings value less than 1 trillion (1,000,000,000,000.00).");
            }
            else if (AlreadyInDatabase(textBoxMovieTitle.Text))
            {
                MessageBox.Show("This movie is already in the database. Please select a new entry.");
            }
            else
            {
                isValid = true;
            }

            
            if(isValid){
               
                // Adding form input into addMovie instance
                addMovie.Title = textBoxMovieTitle.Text;
                addMovie.Year = int.Parse(textBoxYear.Text);
                addMovie.Director = textBoxDirector.Text;
                addMovie.Genre = comboBoxGenre.Text;
                if (textBoxRTScore.Text.Length > 0 && int.TryParse(textBoxRTScore.Text, out int RTScore1))
                {
                    addMovie.RottenTomatoesScore = RTScore1;
                }
                else { 

                    addMovie.RottenTomatoesScore = null;
                }
                if (textBoxEarnings.Text.Length > 0 && decimal.TryParse(textBoxEarnings.Text, out decimal earnings))
                {
                    addMovie.TotalEarned = earnings;
                }
                else { 
                    addMovie.TotalEarned = null;
                }

                // Created array to convert text values of genre back into coded integers
                string[] movieGenres = { "null","Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };
                int updatedGenre = Array.IndexOf(movieGenres, addMovie.Genre);
                
                string connectionString = "Data Source=coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433;Initial Catalog=CSCI1630;User ID=rw1630;Password=Project!;";
                string sqlCommand = "INSERT INTO Movies (Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned) " + "VALUES (@Title, @Year, @Director, @Genre, @RottenTomatoesScore, @TotalEarned)";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                        {
                            command.Parameters.Add("Title", SqlDbType.VarChar, 50).Value = addMovie.Title;
                            command.Parameters.Add("Year", SqlDbType.Int).Value = addMovie.Year;
                            command.Parameters.Add("Director", SqlDbType.VarChar, 50).Value = addMovie.Director;
                            command.Parameters.Add("Genre", SqlDbType.Int).Value = updatedGenre;
                            object dBRottenTomatoesscore = addMovie.RottenTomatoesScore;
                            if (dBRottenTomatoesscore == null)
                            { dBRottenTomatoesscore = DBNull.Value; }
                            command.Parameters.Add("RottenTomatoesScore", SqlDbType.Int).Value = dBRottenTomatoesscore;
                            object dBEarnings = addMovie.TotalEarned;
                            if (dBEarnings == null)
                            { dBEarnings = DBNull.Value; }
                            command.Parameters.Add("TotalEarned", SqlDbType.Decimal).Value = dBEarnings;
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Database has been updated");
                            addMovie.ClearMovieEntry();
                            ClearFields();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database conection failed. Error {ex.Message}");
                }
            }
        }


        public void ClearFields()
        {
            // Method to clear fields in form
            textBoxMovieTitle.Clear();
            textBoxYear.Clear();
            textBoxDirector.Clear();
            textBoxRTScore.Clear();
            textBoxEarnings.Clear();
            comboBoxGenre.SelectedItem = null;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
