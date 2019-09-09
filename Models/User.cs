using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace PachiMaze.Models
{
    public class User
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Screen Name cannot be longer than 20 characters.")]
        public string ScreenName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
