using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string CompanyName { get; set; }

        [Required]
        [MaxLength(40)]
        public string CompanyAddress { get; set; }

        [Required]
        [MaxLength(15)]
        [Column(TypeName = "varchar(15)")]
        public string CompanyPhoneNumber { get; set; }

        public List<Worker> Workers { get; set; } = new List<Worker>();


    }
}
