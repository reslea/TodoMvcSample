using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Todo.EF;
using Todo.Web.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Todo.Web.Mappings;
using Todo.Services;

namespace Todo.Web.Controllers
{
    public class TodoController : Controller
    {
        private readonly IMapper mapper;
        private readonly ITodoService todoService;

        public TodoController(ITodoService todoService)
        {
            mapper = new Mapper(TodoMapping.GetTodoConfiguration());
            this.todoService = todoService;
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(TodoModel model)
        {
            if (!ModelState.IsValid) return RedirectToAction(nameof(Add));

            var dbTodo = mapper.Map<EF.Entities.Todo>(model);

            todoService.Create(dbTodo);
            return RedirectToAction(nameof(List));
        }

        [HttpGet]
        public ActionResult List()
        {
            var todos = todoService.GetAll();

            var todoModels = mapper.Map<IEnumerable<TodoModel>>(todos);

            return View(todoModels);
        }
    }

    public class TodoFabric
    {
        public TodoModel GetDefaultTodo() => new TodoModel();
    }
}