using Application.Contract.TodoItem;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    public class TodoItemController : ControllerBase
    {
        private readonly ITodoItemService _todoItemService;

        public TodoItemController(ITodoItemService todoItemService, ITodoItemServiceV2 todoItemServiceV2)
        {
            _todoItemService = todoItemService;
        }

        [HttpGet]
        [MapToApiVersion("1.0")]
        public async Task<IList<TodoItemDto>> GetTodoItems()
        {
            return await _todoItemService.GetTodoItemAsync();
        }

        [HttpPost]
        [MapToApiVersion("1.0")]
        public async Task<bool> CreateTodoItem(TodoItemCreatoDto todoItemCreatoDto)
        {
            return await _todoItemService.CreateTodoItemAsync(todoItemCreatoDto);
        }
    }
}
