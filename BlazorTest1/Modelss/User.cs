using System.ComponentModel.DataAnnotations;

namespace BlazorTest1.Modelss
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }


        [Required]
        [StringLength(255)]
        public string Password { get; set; }
    }
}
