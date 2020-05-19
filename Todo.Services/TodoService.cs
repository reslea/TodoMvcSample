using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.EF;
using Todo.EF.Entities;

namespace Todo.Services
{
    public class TodoService : ITodoService
    {

        private readonly TodoContext context;

        public TodoService()
        {
            context = new TodoContext();
        }

        public void Create(EF.Entities.Todo todo)
        {
            context.Todos.Add(todo);
            context.SaveChanges();
        }

        public IEnumerable<EF.Entities.Todo> GetAll()
        {
            return context.Todos;
        }
    }
}
