using System.ComponentModel.DataAnnotations;
namespace FriendApp.Models
{
    public class Profile
    {
        [Required]
        public Enumerable name  { get; set; }
    }
}
