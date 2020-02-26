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
    public class AdminModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly UserManager<IdentityUser> _UserManager;
        private readonly SignInManager<IdentityUser> _SignInManager;

        public AdminModel(
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

        public void OnGet()
        {
            var get = from a in _appDbContext.Articles select a;
            ViewData["Data"] = get;
        }

        public void OnPost(string id, string title, string content, string image, string highlight, string edit)
        {
           if(id.Contains("rmv")){
               var get_id = id.Replace("rmv-","");
               var article_id = Convert.ToInt32(get_id);
               var a = _appDbContext.Articles.Find(article_id);
               _appDbContext.Remove(a);
               _appDbContext.SaveChanges();
           }
           else if(edit.Contains("update")){
               var a = _appDbContext.Articles.Find(Convert.ToInt32(id));
               a.title = title;
               a.content = content;
               a.highlight = highlight;
               a.Edited_at = DateTime.Now;
               a.image = image;
               _appDbContext.SaveChanges();
           }
           var get = from a in _appDbContext.Articles select a;
           ViewData["Data"] = get;
        }
    }
}
