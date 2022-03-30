using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }
        [Display(Name = "Last Name"), Required, MaxLength(50)]
        public string lastName { get; set; }
        [Display(Name = "First Name"), Required, MaxLength(50)]
        public string firstName { get; set; }
        [Display(Name = "Company"), Required, MaxLength(50)]
        public string companyName { get; set; }
        [Display(Name = "Date Registered"), DataType(DataType.Date)]
        public DateTime dateRegistered { get; set; }
        [NotMapped]
        public string fullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }
        public ICollection<Movie> Movies { get; set; }
    }
}