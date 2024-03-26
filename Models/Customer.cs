using System.ComponentModel.DataAnnotations;

namespace REST_API___APS.NET_Core.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(10)]
        public required string Name { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        [MinLength(10)]
        public required string Address { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        [MinLength(6)]
        public required string City { get; set; } = string.Empty;
    }
}
