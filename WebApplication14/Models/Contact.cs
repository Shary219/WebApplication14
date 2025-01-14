using System.ComponentModel.DataAnnotations;
using mysqlproject.Controllers.data;
namespace WebApplication14.Models
{
    public class Contact
    {
        [Key]
        public string email { get; set; }
        [Required]
        //[Key]
        public string name { get; set; }
        [Required]
        public string subject { get; set; }
        [Required]
        public string Message { get; set; } 

    }
}
