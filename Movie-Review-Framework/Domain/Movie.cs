using System.Collections.Generic;

namespace Movie_Review_Framework.Domain
{
    public class Movie
    {
        public Movie(string movieName,string directorName,string releaseYear)
        {
            MovieName = movieName;
            DirectorName = directorName;
            ReleaseYear = releaseYear;
        }
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string DirectorName { get; set; }
        public string ReleaseYear { get; set; }
        public virtual ICollection<MovieReview> Reviews { get; set; }
    }
}