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
        {   var get_comment = from a in _appDbContext.Comments where a.ArticlesID == id select a;
            var get = _appDbContext.Articles.Find(id);
            var get_user = _UserManager.GetUserName(User);
            ViewData["Data_Comment"] = get_comment;
            ViewData["Data"] = get;
            ViewData["Data_user"] = get_user;
        }
        public void OnPost(int id, string comment)
        {   var getuser = _UserManager.GetUserName(User);
            var obj = new Comments{
                ArticlesID = id,
                comment = comment,
                email = getuser,
                created_at = DateTime.Now
            };
            _appDbContext.Add(obj);
            _appDbContext.SaveChanges();
            var get = _appDbContext.Articles.Find(id);
            ViewData["Data"] = get;
            var get_comment = from a in _appDbContext.Comments where a.ArticlesID == id select a;
            ViewData["Data_Comment"] = get_comment;
            var get_user = _UserManager.GetUserName(User);
            ViewData["Data_user"] = get_user;
        }
    }
}
