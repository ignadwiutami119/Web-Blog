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
    public class AddModel : PageModel
    {
        private readonly ILogger<AddModel> _logger;
        private readonly UserManager<IdentityUser> _UserManager;
        private readonly SignInManager<IdentityUser> _SignInManager;

        public AddModel(
            ILogger<AddModel> logger,
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
            ViewData["Data"] = get;
        }

        public void OnPost(string title, string highlight, string content, string image)
        {
           Articles articles = new Articles(){
               title = title,
               highlight = highlight,
               content = content,
               image = image,
               Published_at = DateTime.Now,
               Edited_at = DateTime.Now
           };
           _appDbContext.Add(articles);
           _appDbContext.SaveChanges();
           var get = from a in _appDbContext.Articles select a;
           ViewData["Data"] = get;
        }
    }
}
