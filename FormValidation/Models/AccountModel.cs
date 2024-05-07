using System.ComponentModel.DataAnnotations;

namespace FormValidation.Models
{
    public class AccountModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(8)]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string ? Name { get; set; }

        [Required]
        [EmailAddress]
        public string ? Email { get; set; }

        [Required]
        [StringLength(20)]
        public string ? Password { get; set; }

        [Required]
        public string ? Website { get; set; }

        [Required]
        [Range(12, 50)]
        public string ? Age { get; set; }
    }
}
