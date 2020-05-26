using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.EF.Entities;

namespace Todo.EF
{
    public class TodoContext : DbContext
    {
        public DbSet<Entities.Todo> Todos { get; set; }

        public DbSet<User> Users { get; set; }

        public TodoContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TodoContext>());
        }
    }
}
