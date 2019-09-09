using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace PachiMaze.Models
{
    public class Score
    {
        public int ID { get; set; }

        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        public int Value { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Time { get; set; }
    }
}
