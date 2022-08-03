using System.ComponentModel.DataAnnotations;

namespace MVCMessagWall.Models
{
    public class MessageModel
    {
        [Required]
        [StringLength (10, MinimumLength =5)]
        [Display(Name = "Really Cool message")]
        public string Message { get; set; }
    }
}
