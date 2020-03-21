using System.Collections.Generic;
using System.Threading.Tasks;
using App.API.Models;

namespace App.API.Data
{
    public interface IDatingRepository
    {
        void add<T>(T entity) where T : class;
        void delete<T>(T entity) where T : class;
        Task<bool> saveAll();
        Task<IEnumerable<User>> getUsers();
        Task<User> getUser(int id);

    }
}