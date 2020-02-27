using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Comments
    {
        public int id {get; set;}
        public string comment {get; set;}
        public DateTime created_at {get; set;}

        [ForeignKey ("ArticlesID")]
        public int? ArticlesID { get; set; } = null;
        public Articles cart { get; set; }
        public string email { get; set; }
    }
}