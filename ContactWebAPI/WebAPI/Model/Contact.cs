using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [Required]
        public string ContactName { get; set; }

        [Required]
        public string ContactTel { get; set; }

        [Required]
        public string ContactEmail { get; set; }


    }
}
