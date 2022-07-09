using System;
using System.Collections.Generic;
using System.Text;

namespace MovieServices.MovieDAL.CustomModels
{
    public class CreateProducer
    {
        public string Producername { get; set; }
        public string ProducerBio { get; set; }
        public string dateOfbirth { get; set; }
        public string Gender { get; set; }
        public string companyname { get; set; }
    }
}
