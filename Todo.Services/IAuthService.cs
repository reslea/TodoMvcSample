using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.EF.Entities;

namespace Todo.Services
{
    public interface IAuthService
    {
        Guid? Login(string username, string password);

        Guid? Register(string username, string password);
    }
}
