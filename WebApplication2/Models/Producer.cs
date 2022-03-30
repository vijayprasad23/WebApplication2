using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string companyName { get; set; }

        public DateTime dateRegistered { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}