using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1630SemesterProject
{
    public partial class MovieManagerApplication : Form
    {
        public MovieManagerApplication()
        {
            InitializeComponent();
            // Center window on screen
            // Source: https://stackoverflow.com/questions/21171764/how-to-position-the-opening-form-at-specific-location-in-c-sharp-windows-forms
            this.StartPosition = FormStartPosition.Manual;
            
        }

        public static string GetConnectionString()
        // Method to construct ConnectionString to SQL database
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = @"coursemaster1.csbchotp6tva.us-east-2.rds.amazonaws.com,1433";
            builder.InitialCatalog = "CSCI1630";
            builder.UserID = "rw1630";
            builder.Password = "Project!";

            return builder.ConnectionString;
        }

        // Instantiation of list to store database entries
        private  List<MovieEntry> movieEntries = new List<MovieEntry>();

        private void ReadAllSQLTable(string connectionString, string sqlCommand)
        {
            // Connection to SQL database and loop to read and store all entries in list
            string[] movieGenres = { "null", "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movieEntry = new MovieEntry();
                                movieEntry.Id = reader.GetInt32(0);
                                movieEntry.Title = reader.GetString(1);
                                movieEntry.Year = reader.GetInt32(2);
                                movieEntry.Director = reader.GetString(3);
                                if (reader.GetInt32(4) > 0 && reader.GetInt32(4) <= 9)
                                {
                                    int genreValue = reader.GetInt32(4);
                                    movieEntry.Genre = movieGenres[genreValue];
                                }
                                if (!reader.IsDBNull(5))
                                    movieEntry.RottenTomatoesScore = reader.GetInt32(5);
                                if (!reader.IsDBNull(6))
                                    movieEntry.TotalEarned = reader.GetDecimal(6);
                                movieEntries.Add(movieEntry);
                            }

                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database conection failed. Error {ex.Message}");
            }
        }


        private void MovieManagerApplication_Load(object sender, EventArgs e)
        {
            // Connecting to SQL databse to populate datagrid with values from SQL database
            string connectionString = GetConnectionString();
            string sqlCommand = "SELECT  Id, Title,  Year , Director, Genre, RottenTomatoesScore, TotalEarned  FROM  Movies  ORDER   BY  Title";

            ReadAllSQLTable(connectionString, sqlCommand);
            dataGridViewDatabase.DataSource = movieEntries;

            // Source of below code to hide and resize columns https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.autosizecolumnsmode?view=net-5.0
            dataGridViewDatabase.Columns["Id"].Visible = false;
            dataGridViewDatabase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

    

        private void Refresh1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Connecting to SQL database to refresh contents of datagrid
            movieEntries.Clear();
            string connectionString = GetConnectionString();
            string sqlCommand = "SELECT  Id, Title,  Year , Director, Genre, RottenTomatoesScore, TotalEarned  FROM  Movies  ORDER   BY  Title";

            ReadAllSQLTable(connectionString, sqlCommand);
            dataGridViewDatabase.DataSource = null;
            dataGridViewDatabase.DataSource = movieEntries;

            // Source of below code to hide and resize columns https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.autosizecolumnsmode?view=net-5.0
            dataGridViewDatabase.Columns["Id"].Visible = false;
            dataGridViewDatabase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CloseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Button click to ensure user wants to close program
            var userClose = MessageBox.Show("Are you sure you want to close?", "Close?", MessageBoxButtons.YesNo);

            if (userClose == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void AddMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddMovies formAddMovie = new FormAddMovies();
            formAddMovie.ShowDialog();
        }

        private void UpdateMovieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormUpdate formUpdateMovie = new FormUpdate();
            formUpdateMovie.ShowDialog();
        }

        private void DeleteMovieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDelete formDeleteMovie = new FormDelete();
            formDeleteMovie.ShowDialog();
        }

        private void AboutInformationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormAbout formAboutApplication = new FormAbout();
            formAboutApplication.ShowDialog();
        }
    }
}
