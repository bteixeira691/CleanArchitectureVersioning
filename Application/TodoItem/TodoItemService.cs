using Application.Contract.TodoItem;
using AutoMapper;
using Domain.TodoItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.TodoItem
{
    public class TodoItemService : ITodoItemService
    {
        private readonly IRepository<Domain.TodoItem.TodoItem> _repository;
        private readonly IMapper _mapper;

        public TodoItemService(IRepository<Domain.TodoItem.TodoItem> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> CreateTodoItemAsync(TodoItemCreatoDto todoItemCreatoDto)
        {
            try
            {
                var todoItem = _mapper.Map<Domain.TodoItem.TodoItem>(todoItemCreatoDto);
                await _repository.Insert(todoItem);
                return true;
            }
            catch (Exception e)
            {
                return false;
            } 

        }

        public async Task<IList<TodoItemDto>> GetTodoItemAsync()
        {
            try
            {
                var todoItem = await _repository.GetAll();

                var listTodo = _mapper.Map<IList<TodoItemDto>>(todoItem);
                return listTodo;

            }
            catch (Exception e)
            {
                return new List<TodoItemDto>();
            }
        }
    }
}
