using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Todo.Web.Models
{
    public class TodoModel
    {
        public int Id { get; set; }

        [Required, MaxLength(255)]
        public string Title { get; set; }

        public DateTime? DueDate { get; set; } = DateTime.Today.AddDays(1);

        public bool IsDone { get; set; } = false;
    }
}