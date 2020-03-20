using System;

namespace App.API.Models
{
    public class Photo
    {
        public int id { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public DateTime dateadded { get; set; }
        public bool ismain { get; set; }
        public User user { get; set; }
        public int userid { get; set; }

    }
}