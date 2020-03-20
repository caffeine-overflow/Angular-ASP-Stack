using System.Collections.Generic;
using System.Linq;
using App.API.Models;
using Newtonsoft.Json;

namespace App.API.Data
{
    public class seed
    {
        public static void seedUsers(DataContext context)
        {
            if (!context.Users.Any())
            {
                var userData = System.IO.File.ReadAllText("Data/userDataSeed.json");
                var users = JsonConvert.DeserializeObject<List<User>>(userData);

                foreach (var user in users)
                {
                    byte[] passwordhash, passwordSalt;
                    createPasswordHash("password", out passwordhash, out passwordSalt);
                    user.passwordhash = passwordhash;
                    user.passwordSalt = passwordSalt;
                    user.username = user.username.ToLower();
                    context.Users.Add(user);
                }
                context.SaveChanges();
            }
        }

        private static void createPasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}