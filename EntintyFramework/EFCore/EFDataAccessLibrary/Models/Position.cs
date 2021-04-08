using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    public class Position
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string PositionName { get; set; }
        public List<Worker> WorkerName { get; set; } = new List<Worker>();

    }
}
