using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorMessageWall.Pages
{
    public class MessageWallModel : PageModel
    {
        [BindProperty]
        public string Message { get; set; }

        [BindProperty]
        public List<string> Messages { get; set; } = new List<string>();

        public void OnGet()
        {
        }

        /// <summary>
        /// On Post just like On Get occurs when  a post is made to the page 
        /// </summary>
        /// <returns></returns>
        public IActionResult OnPost()
        {
            Console.WriteLine($"{Message}");
            Messages.Add(Message);
            return Page();
        }

    }
}
