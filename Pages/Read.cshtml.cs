using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApp.Data;

namespace WebApp.Pages
{
    public class ReadModel : PageModel
    {
        private readonly ILogger<ReadModel> _logger;
        private readonly UserManager<IdentityUser> _UserManager;
        private readonly SignInManager<IdentityUser> _SignInManager;

        public ReadModel(
            ILogger<ReadModel> logger,
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

        public void OnGet(int id)
        {
            var get = _appDbContext.Articles.Find(id);
            ViewData["Data"] = get;
        }
    }
}
