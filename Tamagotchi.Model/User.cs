using System.ComponentModel.DataAnnotations;

namespace Tamagotchi.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string AuthCode { get; set; }

        public string SessionKey { get; set; }
    }
}