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
    public class RoleModel : PageModel
    {
        private readonly ILogger<RoleModel> _logger;
        private readonly UserManager<IdentityUser> _UserManager;
        private readonly SignInManager<IdentityUser> _SignInManager;

        public RoleModel(
            ILogger<RoleModel> logger,
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
            var get_user_list = _UserManager.Users.ToList();
            ViewData["Data_user"] = get_user_list;
        }

        public void OnPost(string id, string role)
        {   Console.WriteLine(id);
            Console.WriteLine(role);
            Console.WriteLine("TESTTEST");
            if(role == "admin") 
            {
               var get_id = id.Replace("set-","");
               var is_it_new = from a in _appDbContext.RoleAdmins where get_id == a.userId select a;
               if(!is_it_new.Any())
               {
                Console.WriteLine("DISINI");
                var Admin = new RoleAdmin {
                   role = "admin",
                   userId = get_id
               };
               _appDbContext.Add(Admin);
               _appDbContext.SaveChanges();
               }
            }

            else if(role == "user"){
                var get_id = id.Replace("set-","");
                var is_it_new = from a in _appDbContext.RoleAdmins where get_id == a.userId select a;
                if(is_it_new != null){
                    foreach (var a in is_it_new)
                    {
                        _appDbContext.Remove(a);
                    }
                        _appDbContext.SaveChanges(); }
            }
            var get_user_list = _UserManager.Users.ToList();
            ViewData["Data_user"] = get_user_list;
        }
    }
}


// if(is_it_new == null) {
//                 if(role == "admin") 
//                 {
//                    var Admin = new RoleAdmin {
//                    role = "admin",
//                    userId = get_id
//                 };
//                    _appDbContext.Add(Admin);
//                    _appDbContext.SaveChanges();
//                 }
//                 else if(role == "user"){
//                    var Admin = new RoleAdmin {
//                    role = "user",
//                    userId = get_id
//                 };
//                _appDbContext.Add(Admin);
//                _appDbContext.SaveChanges();
//                }
//             }
//             else if(is_it_new != null)
//             {
//                 if(role == "admin") 
//                 {
//                    var get_user =  from a in _appDbContext.RoleAdmins where a.userId == id select a;
                   
//                    _appDbContext.SaveChanges();
//                 }
//                 else if(role == "user"){
//                    var Admin = new RoleAdmin {
//                    role = "user",
//                    userId = get_id
//                 };
//                _appDbContext.SaveChanges(); }
//             }
