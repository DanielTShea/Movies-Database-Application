using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;



namespace _1630SemesterProject
{
    public partial class FormUpdate : Form
    {
        private void LockForm()
        {
            // Method to lock fields of the form
            // Sourced from CSCI-1630 lecture video
            textBoxYear.Enabled = false;
            textBoxDirector.Enabled = false;
            textBoxRTScore.Enabled = false;
            textBoxEarnings.Enabled = false;
            comboBoxGenre.Enabled = false;
            ButtonUpdate.Enabled = false;
        }


        public FormUpdate()
        {
            // Disabling form upon opening
            InitializeComponent();
            LockForm();
            this.StartPosition = FormStartPosition.Manual;
            // Center window on screen
            // Source: https://stackoverflow.com/questions/21171764/how-to-position-the-opening-form-at-specific-location-in-c-sharp-windows-forms
            this.StartPosition = FormStartPosition.Manual;

        }


        private Boolean AlreadyInDatabase(String movie)
        {
            // Method to check if user entry already exists in database
            Boolean inDatabase = false;
            MovieEntry updateEntryCheck = new MovieEntry();
            string connectionString = MovieManagerApplication.GetConnectionString();
            string sqlCommand = "SELECT  Id, Title  FROM  Movies " + "WHERE Title = @Title";
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
                            reader.Read();
                            updateEntryCheck.Id = reader.GetInt32(0);
                            if (updateEntryCheck.Id != updateMovieEntry.Id)
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


        private MovieEntry updateMovieEntry = new MovieEntry();


        public void ClearFields()
        {
            // Method to clear form data
            textBoxMovieTitle.Clear();
            textBoxYear.Clear();
            textBoxDirector.Clear();
            textBoxRTScore.Clear();
            textBoxEarnings.Clear();
            comboBoxGenre.Text = null;
        }
  

        private void ButtonFind_Click_1(object sender, EventArgs e)
        {
            // Connecting to SQL database to read in values from user search
            string connectionString = MovieManagerApplication.GetConnectionString();
            string sqlCommand = "SELECT  Id, Title,  Year , Director, Genre, RottenTomatoesScore, TotalEarned  FROM  Movies " + "WHERE Title = @Title";
            string[] movieGenres = { "null", "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };
            string searchValue = textBoxMovieTitle.Text;
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
                            {
                                updateMovieEntry.Id = reader.GetInt32(0);
                                updateMovieEntry.Title = reader.GetString(1);
                                updateMovieEntry.Year = reader.GetInt32(2);
                                updateMovieEntry.Director = reader.GetString(3);
                                if (reader.GetInt32(4) > 0 && reader.GetInt32(4) < 9)
                                {
                                    int genreValue = reader.GetInt32(4);
                                    updateMovieEntry.Genre = movieGenres[genreValue];
                                }
                                if (!reader.IsDBNull(5))
                                    updateMovieEntry.RottenTomatoesScore = reader.GetInt32(5);
                                if (!reader.IsDBNull(6))
                                    updateMovieEntry.TotalEarned = reader.GetDecimal(6);
                                textBoxYear.Enabled = true;
                                textBoxDirector.Enabled = true;
                                textBoxRTScore.Enabled = true;
                                textBoxEarnings.Enabled = true;
                                comboBoxGenre.Enabled = true;
                                ButtonUpdate.Enabled = true;

                            }
                            else
                                MessageBox.Show("Your movie was not found in the database.");


                        }
                        connection.Close();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database conection failed. Error {ex.Message}");
            }

            // Output of values to form
            textBoxMovieTitle.Text = updateMovieEntry.Title;
            textBoxYear.Text = updateMovieEntry.Year.ToString();
            textBoxDirector.Text = updateMovieEntry.Director;
            comboBoxGenre.Text = updateMovieEntry.Genre;
            textBoxRTScore.Text = updateMovieEntry.RottenTomatoesScore.ToString();
            textBoxEarnings.Text = updateMovieEntry.TotalEarned.ToString();

        }

        private void ButtonUpdate_Click_1(object sender, EventArgs e)
        {
            // Validating user input is correct format
            bool isValid = false;
            int RTScore = 0;
            decimal earnings = 0;

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
                || (RTScore > 100 || RTScore <0))
            {
                MessageBox.Show("The entry is invalid. Please enter a Rotten Tomatoes score less than or equal to 100.");
            }
            else if (textBoxEarnings.Text.Length > 0 && !decimal.TryParse(textBoxEarnings.Text, out earnings))
            {
                MessageBox.Show("The entry is invalid. Please enter a valid earnings currency value.");
            }
            else if (textBoxEarnings.Text.Length > 0 && IsEarningsValid(textBoxEarnings.Text))
            {
                MessageBox.Show("The entry is too large. Please enter an earnings value less than 1 trillion (1,000,000,000,000.00)");
            }
            else if (AlreadyInDatabase(textBoxMovieTitle.Text))
            {
                MessageBox.Show("This movie is already in the database. Please select a new entry.");
            }
            else
            {
                isValid = true;
            }


            if (isValid)
            {

                // Adding form input into addMovie instance
                updateMovieEntry.Title = textBoxMovieTitle.Text;
                updateMovieEntry.Year = int.Parse(textBoxYear.Text);
                updateMovieEntry.Director = textBoxDirector.Text;
                updateMovieEntry.Genre = comboBoxGenre.Text;
                if (textBoxRTScore.Text.Length > 0 && int.TryParse(textBoxRTScore.Text, out int RTScore1))
                {
                    updateMovieEntry.RottenTomatoesScore = RTScore;
                }
                else
                { 
                    updateMovieEntry.RottenTomatoesScore = null; 
                }
                if (textBoxEarnings.Text.Length > 0 && decimal.TryParse(textBoxEarnings.Text, out earnings))
                {
                    updateMovieEntry.TotalEarned = earnings;
                }
                else 
                { 
                    updateMovieEntry.TotalEarned = null;
                }
                // Translating string  genre data back into integer coding
                string[] movieGenres = { "null", "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };
                int updatedGenre = Array.IndexOf(movieGenres, updateMovieEntry.Genre);

                // Connecting to Database to update entry
                string connectionString = MovieManagerApplication.GetConnectionString();
                string sqlCommand = "UPDATE Movies SET Title = @Title, Year = @Year, Director = @Director, Genre = @Genre, RottenTomatoesScore = @RottenTomatoesScore, TotalEarned = @TotalEarned " + "WHERE Id = @Id"; ;
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                        {
                            command.Parameters.Add("Id", SqlDbType.Int).Value = updateMovieEntry.Id;
                            command.Parameters.Add("Title", SqlDbType.VarChar, 50).Value = updateMovieEntry.Title;
                            command.Parameters.Add("Year", SqlDbType.Int).Value = updateMovieEntry.Year;
                            command.Parameters.Add("Director", SqlDbType.VarChar, 50).Value = updateMovieEntry.Director;
                            command.Parameters.Add("Genre", SqlDbType.Int).Value = updatedGenre;
                            object dBRottenTomatoesscore = updateMovieEntry.RottenTomatoesScore;
                            if (dBRottenTomatoesscore == null)
                            { dBRottenTomatoesscore = DBNull.Value; }
                            command.Parameters.Add("RottenTomatoesScore", SqlDbType.Int).Value = dBRottenTomatoesscore;
                            object dBEarnings = updateMovieEntry.TotalEarned;
                            if (dBEarnings == null)
                            { dBEarnings = DBNull.Value; }
                            command.Parameters.Add("TotalEarned", SqlDbType.Decimal).Value = dBEarnings;
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Database has been updated");



                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database conection failed. Error {ex.Message}");
                }
                updateMovieEntry.ClearMovieEntry();
                ClearFields();
                LockForm();

            }
        }

        private void ButtonClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ButtonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
        
