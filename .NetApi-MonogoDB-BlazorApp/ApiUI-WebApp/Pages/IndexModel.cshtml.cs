using ApiUI_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace SampleAPI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory; // IHttpclient factory is able to be used becuase of dependency injetion in the program.cs at builder.Services.AddHttpClient();

        [BindProperty]
        public int Counters { get; set; }

        [BindProperty]
        public ContactModel contactModel { get; set; } = new ContactModel();

        List<ContactModel> contacts = new List<ContactModel>();

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async void OnGet()
        {
  
        }


        private async Task GetAllContacts()
        {
            var _client = _httpClientFactory.CreateClient();
            var response = await _client.GetAsync("https://localhost:7143/api/Contacts");

            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true,

                };

                //List<ContactModel> contacts;
                string responseText = await response.Content.ReadAsStringAsync();
                contacts = JsonSerializer.Deserialize<List<ContactModel>>(responseText, options);
        
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }

        }
    }
}