using System;
using System.Collections.Generic;
using App.API.Models;

namespace App.API.Dtos
{
    public class userForDetailedDto
    {
        public int id { get; set; }
        public string username { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public DateTime created { get; set; }
        public DateTime lastactive { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string photoUrl { get; set; }
        public string lookingfor { get; set; }
        public string interests { get; set; }
        public ICollection<photosForDetailedDto> photos { get; set; }

    }
}