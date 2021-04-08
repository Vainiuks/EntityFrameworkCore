using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    public class Email
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        [Column(TypeName = "varchar(60)")]
        public string EmailAddress { get; set; }

    }
}
