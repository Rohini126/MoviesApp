using System;
using System.Collections.Generic;
using System.Text;

namespace MovieServices.MovieDAL.Models
{
    public partial class MovieActorMapping
    {
        public long MappingId { get; set; }
        public long MovieXid { get; set; }
        public long ActorXid { get; set; }
   
        public Actor ActorX { get; set; }
        public Movie MovieX { get; set; }

    }
}
