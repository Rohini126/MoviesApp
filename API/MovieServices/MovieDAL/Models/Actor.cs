using System;
using System.Collections.Generic;
using System.Text;

namespace MovieServices.MovieDAL.Models
{
    public partial class Actor
    {
      
        public long ActorId { get; set; }
        public string Actorname { get; set; }
        public string ActorBio { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
