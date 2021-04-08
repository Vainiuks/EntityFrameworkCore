using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataAccessLibrary.Models
{
   public class Address
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(70)]
        public string StreetName { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        public string ZipCode { get; set; }

    }
}
