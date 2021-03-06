using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Articles
    {
        public int id {get; set;}
        public DateTime Published_at { get; set; }
        public DateTime Edited_at {get; set;}
        public string image {get; set;}
        public string highlight {get; set;}
        public string content {get; set;}
        public string title {get; set;}
        public ICollection<Comments> comments { get; set; }

    }
}