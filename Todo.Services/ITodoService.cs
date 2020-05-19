using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Services
{
    public interface ITodoService
    {
        void Create(EF.Entities.Todo todo);

        IEnumerable<EF.Entities.Todo> GetAll();
    }
}
