using System.ComponentModel.DataAnnotations;
using WebApplication.Interface;

namespace WebApplication.Modules
{
    public class Student : IEntity
    {
        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [StringLength(10)]
        public string MobileNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
