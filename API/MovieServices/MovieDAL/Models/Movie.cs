using System;
using System.Collections.Generic;
using System.Text;

namespace MovieServices.MovieDAL.Models
{
    public partial class Movie
    {
        public Movie()
        {
            MovieActorMappingX = new HashSet<MovieActorMapping>();
        }
        public long MovieId { get; set; }
        public string MovieName { get; set; }
        public string MoviePlot { get; set; }
        public string PosterData { get; set; } //Base64 saved in string format
        public long? ProducerXid { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public byte status { get; set; }

        public Producer ProducerX { get; set; }
        public ICollection<MovieActorMapping> MovieActorMappingX { get; set; }


    }
}
