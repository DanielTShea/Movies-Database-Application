using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1630SemesterProject
{
    public class MovieEntry
    {
        // Public class to store movie entry column data
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public Nullable<int>RottenTomatoesScore { get; set; }
        public Nullable<decimal> TotalEarned { get; set; }


        public void ClearMovieEntry()
        {
            // Method to clear movie entry 
            Id = 0;
            Title = null;
            Year = 0;
            Director = null;
            Genre = null;
            RottenTomatoesScore = null;
            TotalEarned = null;

        }
    }
}
