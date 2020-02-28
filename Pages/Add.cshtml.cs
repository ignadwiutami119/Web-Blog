using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages {
    [Authorize]
    public class AddModel : PageModel {
        private readonly ILogger<AddModel> _logger;
        private readonly UserManager<IdentityUser> _UserManager;
        private readonly SignInManager<IdentityUser> _SignInManager;
        private readonly IWebHostEnvironment _Environtment;

        public AddModel (
            IWebHostEnvironment environment,
            ILogger<AddModel> logger,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ApplicationDbContext applicationDbContext
        ) {
            _logger = logger;
            _UserManager = userManager;
            _SignInManager = signInManager;
            _appDbContext = applicationDbContext;
            _Environtment = environment;
        }

        private ApplicationDbContext _appDbContext;

        public void OnGet () {
            var get = from a in _appDbContext.Articles select a;
            ViewData["Data"] = get;
        }

        public void OnPost (string title, string highlight, string content, IFormFile image) {
            var path = "wwwroot//image";
            Directory.CreateDirectory(path);
            var Filename = Path.Combine (path, Path.GetFileName (image.FileName));
            image.CopyTo (new FileStream (Filename, FileMode.Create));
            var file = Filename.Substring(8).Replace(@"\","/");
            Articles articles = new Articles () {
                title = title,
                highlight = highlight,
                content = content,
                image = file,
                Published_at = DateTime.Now,
                Edited_at = DateTime.Now
            };
            _appDbContext.Add (articles);
            _appDbContext.SaveChanges ();
            var get = from a in _appDbContext.Articles select a;
            ViewData["Data"] = get;
        }
    }
}