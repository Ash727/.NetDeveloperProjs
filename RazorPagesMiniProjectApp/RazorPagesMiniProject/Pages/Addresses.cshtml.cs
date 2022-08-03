using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DemoLibrary;

namespace RaazorPagesMiniProjec.Pages
{
    public class AddressesModel : PageModel
    {
        [BindProperty]
        public AddressModel UserAddress { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectPermanent("./Index");
        }
    }
}
