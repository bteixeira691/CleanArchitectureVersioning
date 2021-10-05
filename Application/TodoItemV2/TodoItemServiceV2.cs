using Application.Contract.TodoItem;
using AutoMapper;
using Domain.TodoItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.TodoItemV2
{
    public class TodoItemServiceV2 : ITodoItemServiceV2
    {
        private readonly IRepository<Domain.TodoItem.TodoItem> _repository;
        private readonly IMapper _mapper;

        public TodoItemServiceV2(IRepository<Domain.TodoItem.TodoItem> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> CreateTodoItemAsync(TodoItemCreatoDtoV2 todoItemCreatoDto)
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

        public async Task<IList<TodoItemDtoV2>> GetTodoItemAsync()
        {
            try
            {
                var todoItem = await _repository.GetAll();

                var listTodo = _mapper.Map<IList<TodoItemDtoV2>>(todoItem);
                return listTodo;

            }
            catch (Exception e)
            {
                return new List<TodoItemDtoV2>();
            }
        }
    }
}
