using System.ComponentModel.DataAnnotations;

namespace WebAPI.ViewModel
{
    public class ContactViewModel
    {
        [Required]
        public string ContactName { get; set; }
        
        [Required]
        public string ContactTel { get; set; }

        [Required]
        [EmailAddress]
        public string ContactEmail { get; set; }
    }
}
