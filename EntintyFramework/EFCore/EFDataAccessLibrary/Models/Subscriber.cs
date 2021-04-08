using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    public class Subscriber
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ExpiryDate { get; set; }
        public Worker Worker { get; set; }

        public int WorkerId { get; set; }

    }
}
