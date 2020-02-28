using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Articles> Articles {get;set;}
        public DbSet<Paging> Pagings {get;set;}
        public DbSet<Comments> Comments {get;set;}
        public DbSet<RoleAdmin> RoleAdmins {get;set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {     
        }
    }
}
