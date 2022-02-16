using System.ComponentModel.DataAnnotations;
namespace Dojo_Survey.Models
{
    public class User
    {
        [Required]
        [MinLength(3)]
        public string name { get; set; }

        [Required]
        public string location{ get; set; }

        [Required]
        public string language{ get; set; }

        [Required]
        [MinLength(20)]
        public string comments{ get; set; }
    }
}

