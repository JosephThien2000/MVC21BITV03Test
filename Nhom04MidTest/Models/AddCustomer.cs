using System.ComponentModel.DataAnnotations;
namespace Nhom04MidTest.Models
{
    public class AddCustomer
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public DateTime BirthDate { get; set;}
        [Required]
        public bool IsYoungDriver { get; set; }
    }
}