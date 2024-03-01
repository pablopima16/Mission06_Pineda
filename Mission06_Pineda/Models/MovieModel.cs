using System.ComponentModel.DataAnnotations;

namespace Mission06_Pineda.Models
{
    public class MovieModel
    {
        [Key] public int Id { get; set; }
        public string Rating { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Year { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }
        public string Director { get; set; }
        public string? Director2 { get; set; }
        public string? Director3 { get; set; }
        public string? Director4 { get; set; }
    }
}
