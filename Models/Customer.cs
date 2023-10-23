using System.ComponentModel.DataAnnotations;
namespace WebRepo.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public string adress { get; set; }

    }
}
