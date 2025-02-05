using System.ComponentModel.DataAnnotations;

namespace ClassVue.Shared.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
