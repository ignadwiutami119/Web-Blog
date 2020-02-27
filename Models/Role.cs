using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class RoleAdmin
    {
       
        public int id {get; set;}
        public string role {get; set;}
        public string userId {get; set;}
    }
}