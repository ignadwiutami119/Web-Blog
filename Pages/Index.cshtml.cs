using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly UserManager<IdentityUser> _UserManager;
        private readonly SignInManager<IdentityUser> _SignInManager;

        public IndexModel(
            ILogger<IndexModel> logger,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ApplicationDbContext applicationDbContext
        ){
            _logger = logger;
            _UserManager = userManager;
            _SignInManager = signInManager;
            _appDbContext = applicationDbContext;
        }

        private ApplicationDbContext _appDbContext;

        public IActionResult OnGet()
        {   
            var id = _UserManager.GetUserId(User);
            var get_user_list = _UserManager.Users.ToList();
            var adminId = get_user_list[0].Id;

            if(!_appDbContext.RoleAdmins.Any()) {
            var role =  new RoleAdmin(){
                userId = adminId,
                role = "admin"
            };
            _appDbContext.Add(role);
            _appDbContext.SaveChanges();
            }

            var getAdmin = from a in _appDbContext.RoleAdmins select a;
            foreach (var item in getAdmin)
            {
                if(id == item.userId) {
                    return new RedirectToPageResult("AdminHome");
                }
            }
            // if(id == adminId) {
            //     return new RedirectToPageResult("Admin");
            // }
            return new RedirectToPageResult("User");
        }
    }
}
