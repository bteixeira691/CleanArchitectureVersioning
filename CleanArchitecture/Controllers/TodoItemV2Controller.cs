using Application.Contract.TodoItem;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Controllers
{

    [ApiController]
    [ApiVersion("2.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    public class TodoItemV2Controller : ControllerBase
    {
        private readonly ITodoItemServiceV2 _todoItemServiceV2;
        public TodoItemV2Controller(ITodoItemServiceV2 todoItemServiceV2)
        {
            _todoItemServiceV2 = todoItemServiceV2;
        }

        [HttpGet]
        [MapToApiVersion("2.0")]
        public async Task<IList<TodoItemDtoV2>> GetTodoItems()
        {
            return await _todoItemServiceV2.GetTodoItemAsync();
        }

        [HttpPost]
        [MapToApiVersion("2.0")]
        public async Task<bool> CreateTodoItem(TodoItemCreatoDtoV2 todoItemCreatoDto)
        {
            return await _todoItemServiceV2.CreateTodoItemAsync(todoItemCreatoDto);
        }

    }
}
