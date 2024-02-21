using System.ComponentModel.DataAnnotations;

namespace Mission06_Pineda.Models
{
	public class Application
	{
		[Key]
		public int ApplicationID { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Tittle { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }


		public bool Edited { get; set; }
		public string? Lent { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }

	}
}
