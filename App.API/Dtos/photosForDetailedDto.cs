using System;

namespace App.API.Dtos
{
    public class photosForDetailedDto
    {
        public int id { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public DateTime dateadded { get; set; }
        public bool ismain { get; set; }
    }
}