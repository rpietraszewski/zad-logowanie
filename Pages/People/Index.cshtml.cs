#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Years.Data;
using Years.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;


namespace Years.Pages.People
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Years.Data.PeopleContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public string user_id;

        public IndexModel(ILogger<IndexModel> logger, Years.Data.PeopleContext context, UserManager<IdentityUser> userManager)
        {
            _logger =  logger;
            _context = context;
            _userManager = userManager;
        }

        public IList<User> User2 { get;set; }

        public async Task OnGetAsync()
        {
            user_id = _userManager.GetUserId(User);
            User2 = await _context.User.Take(20).OrderByDescending(x => x.CreatedTime).ToListAsync();
        }
    }
}
