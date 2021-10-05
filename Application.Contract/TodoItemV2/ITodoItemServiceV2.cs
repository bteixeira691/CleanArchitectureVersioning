using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.TodoItem
{
    public interface ITodoItemServiceV2
    {
        Task<IList<TodoItemDtoV2>> GetTodoItemAsync();
        Task<bool> CreateTodoItemAsync(TodoItemCreatoDtoV2 todoItemCreatoDto);
    }
}
