using DataLayer.Models;
using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }
        public User Add(User item)
        {
            _context.Users.Add(item);
            _context.SaveChanges();
            return item;
        }

        public User Delete(User item)
        {
            _context.Remove(item);
            _context.SaveChanges();
            return item;
        }

        public User GetItem(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetItems()
        {
            return _context.Users.ToList();
        }

        public User Update(User item)
        {
            _context.Users.Update(item);
            _context.SaveChanges();
            return item;
        }
    }
}
