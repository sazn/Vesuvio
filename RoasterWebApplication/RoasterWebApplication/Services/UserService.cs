using RoasterWebApplication.Helpers;
using RoasterWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoasterWebApplication.Services
{
    public class UserService : IUserService
    {
        private readonly RosterDBContext _context;
        public UserService(RosterDBContext context)
        {
            _context = context;        
        }
       
        public async Task<User> Authenticate(string username, string password)
        {
            var user = await Task.Run(() => _context.Users.SingleOrDefault(x => x.Username == username && x.Password == password));

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so return user details without password
            return user.WithoutPassword();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
