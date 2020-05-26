using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.EF.Entities
{
    public class User
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
