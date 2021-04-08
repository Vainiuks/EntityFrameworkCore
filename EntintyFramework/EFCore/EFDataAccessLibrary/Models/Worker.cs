using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataAccessLibrary.Models
{
   public class Worker
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [MaxLength(35)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(35)]
        public string Hobbies { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Email> Emails { get; set; } = new List<Email>();
        public List<Position> Positions { get; set; } = new List<Position>();
    }
}
