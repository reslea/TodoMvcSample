using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Todo.Web.Models;

namespace Todo.Web.Mappings
{
    public class TodoMapping
    {
        public static MapperConfiguration GetTodoConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EF.Entities.Todo, TodoModel>();
                //.ForMember(m => m.Title, opts => opts.MapFrom(t => t.Title));
                cfg.CreateMap<TodoModel, EF.Entities.Todo>();
            });
        }
    }
}