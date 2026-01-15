using System.ComponentModel.DataAnnotations;

namespace WebForms.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string UserName { get; set; }

        [Required, MaxLength(255)]
        public string PasswordHash { get; set; }

        [Required, MaxLength(100)]
        public string FullName { get; set; }
    }
}