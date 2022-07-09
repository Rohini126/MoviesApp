using System;
using System.Collections.Generic;
using System.Text;

namespace MovieServices.MovieDAL.CustomModels
{
    public class CreateActor
    {
        public string Actorname { get; set; }
        public string ActorBio { get; set; }
        public string dateOfbirth { get; set; }
        public string Gender { get; set; }
    }
}
