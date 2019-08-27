using System.ComponentModel.DataAnnotations;

namespace PachiMaze.Models
{
    public class Score
    {
        public int ScoreId { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
