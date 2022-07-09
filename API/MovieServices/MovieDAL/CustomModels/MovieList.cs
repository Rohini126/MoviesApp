using System;
using System.Collections.Generic;
using System.Text;

namespace MovieServices.MovieDAL.CustomModels
{
    public class MovieList
    {
        public long MovieId { get; set; }
        public string MovieName { get; set; }
        public string MoviePlot { get; set; }
        public List<string> Actors { get; set; }
        public string producerName { get; set; }
        public string posterData { get; set; }
        public string releasedate { get; set; }
    }

}
