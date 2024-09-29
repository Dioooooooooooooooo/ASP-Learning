using System.ComponentModel.DataAnnotations;

namespace WebAPi.Models
{
    public class Users
    {
        [Key]
        public int userId { get; set; }

        [Required]
        public string name { get; set; } = "";

        [Required]
        public string address { get; set; } = "";
    }


    public class People
    {
        [Key]
        public int userId { get; set; }

        [Required]
        public string name { get; set; } = "";

        [Required]
        public string address { get; set; } = "";
    }
}
