using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AkijBashirGroup.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]*$")]
        public string? FullName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [RegularExpression("^[0-9]*$")]
        public string? MobileNumber { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]*$")]
        public string? Address { get; set; }

        [Required]
        [MinLength(6)]
        public string? Username { get; set; }

        [Required]
        [MinLength(8)]
        public string? Password { get; set; }
		public DateTime? CreateDate { get; set; }
		public DateTime? UpdateDate { get; set; }
    }
}
