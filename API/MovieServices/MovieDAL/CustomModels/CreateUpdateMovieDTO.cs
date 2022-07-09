using System;
using System.Collections.Generic;
using System.Text;

namespace MovieServices.MovieDAL.CustomModels
{
    public class CreateUpdateMovieDTO
    {
        public long MovieId { get; set; }
        public string MovieName { get; set; }
        public string MoviePlot { get; set; }
        public List<long> ActorId { get; set; }
        public long producerId { get; set; }
        public string posterData { get; set; }
        public string releasedate { get; set; }
    }
}
