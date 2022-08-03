using System.ComponentModel.DataAnnotations;

namespace MVCMiniProject.Models
{
    public class AddressModel
    {
        [Required]
        [Display(Name = "StreetAddress")]
        public string StreetAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
            
        [Required]
        [Display(Name = "Province")]
        public string Province { get; set; }

        [Required]
        [Display(Name = "PostalCode")]
        [StringLength(7)]
        [MinLength(2)]
        public string PostalCode { get; set; } 

    }
}
