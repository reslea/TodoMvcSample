using Todo.Web.Controllers;
using Xunit;
using Moq;
using Todo.Services;
using Todo.EF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Todo.Tests
{
    public class TodoControllerTests
    {
        TodoController todoController;

        public TodoControllerTests()
        {

        }

        [Fact]
        public void GetAllTodosReturnsFullList()
        {
            var testList = new List<EF.Entities.Todo>()
            {

            };

            var mockTodoService = new Mock<ITodoService>();
            mockTodoService.Setup(s => s.GetAll()).Returns(testList);

            var fakeTodoService = mockTodoService.Object;

            todoController = new TodoController(fakeTodoService);
            var actionResult = todoController.List();
        }
    }
}
