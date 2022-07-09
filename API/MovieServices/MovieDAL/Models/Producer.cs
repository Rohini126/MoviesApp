using System;
using System.Collections.Generic;
using System.Text;

namespace MovieServices.MovieDAL.Models
{
    public partial class Producer
    {
        public long producerId { get; set; }
        public string ProducerName { get; set; }
        public string producerBio { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public string Companyname { get; set; }
        public string Gender { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
