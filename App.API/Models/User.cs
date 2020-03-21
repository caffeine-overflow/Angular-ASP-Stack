using System;
using System.Collections.Generic;

namespace App.API.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public byte[] passwordhash { get; set; }
        public byte[] passwordSalt { get; set; }
        public string gender { get; set; }
        public DateTime dateofbirth { get; set; }
        public DateTime created { get; set; }
        public DateTime lastactive { get; set; }
        public string aboutme { get; set; }
        public string lookingfor { get; set; }
        public string interests { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public ICollection<Photo> photos { get; set; }

    }
}