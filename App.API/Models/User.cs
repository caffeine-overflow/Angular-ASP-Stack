namespace App.API.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public byte[] passwordhash { get; set; }
        public byte[] passwordSalt { get; set; }
    }
}