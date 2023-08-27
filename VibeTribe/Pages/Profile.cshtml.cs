using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VibeTribe.Data;

public class ProfileModel : PageModel
{
    private readonly UserManager<ApplicationUser> _userManager;

    public ProfileModel(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public string Username { get; set; }
    public string ProfileImageUrl { get; set; }
    public string Email { get; set; }
    public DateTime DateJoined { get; set; }
    public string Bio { get; set; }

    public async Task OnGetAsync()
    {
        var user = await _userManager.GetUserAsync(User); // Fetch the logged-in user's data.

        if (user != null)
        {
            Username = user.UserName;
            Email = user.Email;
            ProfileImageUrl = user.ProfileImageUrl;
            DateJoined = user.DateJoined;
            Bio = user.Bio;
        }
    }
}
