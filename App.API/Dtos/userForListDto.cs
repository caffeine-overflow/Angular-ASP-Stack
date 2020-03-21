using System;

namespace App.API.Dtos
{
    public class userForListDto
    {
        public int id { get; set; }
        public string username { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public DateTime created { get; set; }
        public DateTime lastactive { get; set; }
        public string city { get; set; }
        public string photoUrl { get; set; }
    }
}