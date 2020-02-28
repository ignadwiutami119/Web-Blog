using System;

namespace WebApp.Models
{
    public class Paging
    {
        public int id { get; set; }
        public int showitem { get; set; } = 4;
        public int curent_page { get; set; } = 1;
    }
}