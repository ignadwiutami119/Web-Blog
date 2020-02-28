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

namespace WebApp.Pages {
    [Authorize]
    public class UserModel : PageModel {
        private readonly ILogger<UserModel> _logger;
        private readonly UserManager<IdentityUser> _UserManager;
        private readonly SignInManager<IdentityUser> _SignInManager;

        public UserModel (
            ILogger<UserModel> logger,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ApplicationDbContext applicationDbContext
        ) {
            _logger = logger;
            _UserManager = userManager;
            _SignInManager = signInManager;
            _appDbContext = applicationDbContext;
        }

        private ApplicationDbContext _appDbContext;

        public void OnGet (int _crntpage=1) {
            if (!_appDbContext.Pagings.Any ()) {
                Paging page = new Paging () {
                    showitem = 2,
                    curent_page = 1
                };
                _appDbContext.Pagings.Add (page);
                _appDbContext.SaveChanges ();
            }
            var _page = _appDbContext.Pagings.Find(1);
            _page.curent_page = _crntpage;
            _appDbContext.SaveChanges ();
            if (_page.curent_page == 1) {
                var take = _page.showitem;
                var show = (from c in _appDbContext.Articles orderby c.Published_at descending select c).Take (take);
                ViewData["Data"] = show;
                var is_it_login = _UserManager.GetUserId (User);
                ViewData["Data_user"] = is_it_login;
                var recent_post = (from a in _appDbContext.Articles orderby a.Published_at descending select a).Take (5);
                ViewData["Recent"] = recent_post;
            } else {
                var take = _page.showitem;
                var show = (from a in _appDbContext.Articles orderby a.Published_at descending select a).Skip(take * (_page.curent_page - 1)).Take(take);
                ViewData["Data"] = show;
                var is_it_login = _UserManager.GetUserId (User);
                ViewData["Data_user"] = is_it_login;
                var recent_post = (from c in _appDbContext.Articles orderby c.Published_at descending select c).Take (5);
                ViewData["Recent"] = recent_post;
            }
        }
        public void OnPost (string search) {
            if (search != null) {
                var get = from a in _appDbContext.Articles where a.content.Contains(search) select a;
                var is_it_login = _UserManager.GetUserId (User);
                var recent_post = (from a in _appDbContext.Articles orderby a.Published_at descending select a).Take (5);
                ViewData["Recent"] = recent_post;
                ViewData["Data"] = get;
                ViewData["Data_user"] = is_it_login;
            } else {
                var get = (from a in _appDbContext.Articles orderby a.Published_at descending select a).Take (2);
                var is_it_login = _UserManager.GetUserId (User);
                var recent_post = (from a in _appDbContext.Articles orderby a.Published_at descending select a).Take (5);
                ViewData["Data"] = get;
                ViewData["Data_user"] = is_it_login;
                ViewData["Recent"] = recent_post;
            }
        }
    }
}