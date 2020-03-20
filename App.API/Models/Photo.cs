using System;

namespace App.API.Models
{
    public class Photo
    {
        public int id { get; set; }
        public string url { get; set; }
        public int description { get; set; }
        public DateTime dateadded { get; set; }
        public bool ismain { get; set; }
    }
}