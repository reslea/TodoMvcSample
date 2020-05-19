using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.EF.Entities
{
    public class Todo
    {
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Title { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public bool IsDone { get; set; }
    }
}
