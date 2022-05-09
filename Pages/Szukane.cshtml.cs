using Microsoft.AspNetCore.Mvc.RazorPages;
using Years.Interfaces;
using Years.Models;
using Years.ViewModels.User;


namespace Years.Pages
{
    

    public class SzukaneModel : PageModel
    {

        private readonly IUserService _userService;

        public ListUserViewModel Records { get; set; }

        public SzukaneModel(IUserService userService)
        {
            _userService = userService;
        }

        public void OnGet()
        {
            Records = _userService.GetPeople();
        }
    }
}
