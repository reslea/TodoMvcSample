using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.EF;
using Todo.EF.Entities;

namespace Todo.Services
{
    public class AuthService : IAuthService
    {
        private readonly TodoContext context;

        public AuthService()
        {
            context = new TodoContext();
        }

        public Guid? Login(string username, string password)
        {
            return context.Users
                .Where(u => u.Name == username && u.Password == password)
                .Select(u => u.Id)
                .FirstOrDefault();
        }

        public Guid? Register(string username, string password)
        {
            var dbUser = new User
            {
                Id = Guid.NewGuid(),
                Name = username,
                Password = password
            };

            context.Users.Add(dbUser);
            context.SaveChanges();
            return dbUser.Id;
        }
    }
}
