using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages
{
    public class UserModel : PageModel
    {
        private readonly ILogger<UserModel> _logger;
        private readonly UserManager<IdentityUser> _UserManager;
        private readonly SignInManager<IdentityUser> _SignInManager;

        public UserModel(
            ILogger<UserModel> logger,
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

        public void OnGet()
        {   
            var get = from a in _appDbContext.Articles select a;
            var is_it_login = _UserManager.GetUserId(User);
            ViewData["Data"] = get;
            ViewData["Data_user"] = is_it_login;
        }
    }
}
