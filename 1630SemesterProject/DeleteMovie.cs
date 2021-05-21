using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1630SemesterProject
{
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
            // Disabling delete button on form load
            ButtonDelete.Enabled = false;
            // Center window on screen
            // Source: https://stackoverflow.com/questions/21171764/how-to-position-the-opening-form-at-specific-location-in-c-sharp-windows-forms
            this.StartPosition = FormStartPosition.Manual;

        }

        // Instantiating deleteMovie entry
        private MovieEntry deleteMovie = new MovieEntry();

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            // Find button click to create connection to SQL database to search for database entry
            string connectionString = MovieManagerApplication.GetConnectionString();
            string sqlCommand = "SELECT  Id, Title,  Year , Director, Genre, RottenTomatoesScore, TotalEarned  FROM  Movies " + "WHERE Title = @Title";
            string[] movieGenres = { "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };
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
                                deleteMovie.Id = reader.GetInt32(0);
                                deleteMovie.Title = reader.GetString(1);
                                deleteMovie.Year = reader.GetInt32(2);
                                deleteMovie.Director = reader.GetString(3);
                                if (reader.GetInt32(4) > 0 && reader.GetInt32(4) < 9)
                                {
                                    int genreValue = reader.GetInt32(4);
                                    deleteMovie.Genre = movieGenres[genreValue];
                                }
                                if (!reader.IsDBNull(5))
                                    deleteMovie.RottenTomatoesScore = reader.GetInt32(5);
                                if (!reader.IsDBNull(6))
                                    deleteMovie.TotalEarned = reader.GetDecimal(6);
                                ButtonDelete.Enabled = true;

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

            // Output of found values to form
            textBoxMovieTitle.Text = deleteMovie.Title;
            textBoxYear.Text = deleteMovie.Year.ToString();
            textBoxDirector.Text = deleteMovie.Director;
            comboBoxGenre.Text = deleteMovie.Genre;
            textBoxRTScore.Text = deleteMovie.RottenTomatoesScore.ToString();
            textBoxEarnings.Text = deleteMovie.TotalEarned.ToString();
        }

        private void ButtonDelete_Click_1(object sender, EventArgs e)
        {
            // Messagebox to ensure user is correctly deleting item
            var userClose = MessageBox.Show("Are you sure you want to delete this entry from the database?", "Delete Entry?", MessageBoxButtons.YesNo);

            if (userClose == DialogResult.Yes)

            // User input validtion for values of form
            {
                bool ifValid = false;
                if (textBoxMovieTitle.Text != deleteMovie.Title)
                {
                    MessageBox.Show("You cannot change the name of the movie you want to delete. Please change it back.");

                }
                else

                {
                    ifValid = true;
                }

                if (ifValid)
                {
                    // Connecting to SQL database to delete entry
                    string connectionString = MovieManagerApplication.GetConnectionString();
                    string sqlCommand = "DELETE FROM Movies " + "WHERE Id = @Id";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                            {
                                command.Parameters.Add("Id", SqlDbType.Int).Value = deleteMovie.Id;
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

                    deleteMovie.ClearMovieEntry();
                    ClearFields();
                    ButtonDelete.Enabled = false;
                }
            }
        }

        public void ClearFields()
        {
            // Method to clear contents of form
            textBoxMovieTitle.Clear();
            textBoxYear.Clear();
            textBoxDirector.Clear();
            textBoxRTScore.Clear();
            textBoxEarnings.Clear();
            comboBoxGenre.Text = null;
        }

        private void ButtonClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
