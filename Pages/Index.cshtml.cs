using Years.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Years.Data;
using Years.Interfaces;
using Years.ViewModels.User;
using Microsoft.AspNetCore.Identity;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IUserService _userService;
    private readonly UserManager<IdentityUser> _userManager;

    public ListUserViewModel Records { get; set; }
    public string Result { get; set; }

    [BindProperty]
    public User User2 { get; set; }

    public IndexModel(ILogger<IndexModel> logger, IUserService userService, UserManager<IdentityUser> userManager)
    {
        _logger = logger;
        _userService = userService;
        _userManager = userManager;
        
    }

    public void OnGet()
    {
        Records = _userService.GetTodayPeople();
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            Result = $"{User2.Name} urodził się w {User2.Year} roku. ";
            if (User2.IsLeapYear())
                Result += "To był rok przestępny.";
            else
                Result += "To nie był rok przestępny.";

                
                User2.Result = User2.IsLeapYear();
                User2.CreatedTime = DateTime.UtcNow;
                User2.UId = _userManager.GetUserId(User);
                _userService.Insert(User2);
            
            
        }
        Records = _userService.GetTodayPeople();

        return Page();
    }
}
