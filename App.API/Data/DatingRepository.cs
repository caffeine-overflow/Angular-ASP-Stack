using System.Collections.Generic;
using System.Threading.Tasks;
using App.API.Models;
using Microsoft.EntityFrameworkCore;

namespace App.API.Data
{
    public class DatingRepository : IDatingRepository
    {

        private readonly DataContext _context;
        public DatingRepository(DataContext context)
        {
            _context = context;
        }

        public void add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<User> getUser(int id)
        {
            var user = await _context.Users.Include(p => p.photos).FirstOrDefaultAsync(u => u.id == id);
            return user;
        }

        public async Task<IEnumerable<User>> getUsers()
        {
            var users = await _context.Users.Include(p => p.photos).ToListAsync();
            return users;
        }

        public async Task<bool> saveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}