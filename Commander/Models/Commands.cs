using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commander.Models
{
    public class Command
    {        

        public int Id { get; set; }
      
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string Line { get; set; }
       
        [Required]
        [MaxLength(250)]
        public string Platform { get; set; }

    }
}