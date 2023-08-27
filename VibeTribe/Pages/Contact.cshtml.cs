using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VibeTribe.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;

        public ContactModel(ILogger<ContactModel> logger)
        {
            _logger = logger;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public void OnPost()
        {
            Name = Request.Form["Name"];
            Email = Request.Form["Email"];
            Message = Request.Form["Message"];

            _logger.LogInformation($"Received message from {Name} ({Email}): {Message}");
        }
    }
}