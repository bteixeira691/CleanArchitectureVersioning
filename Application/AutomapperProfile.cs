using Application.Contract.TodoItem;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap< TodoItemCreatoDto, Domain.TodoItem.TodoItem>()
                .ForMember(s=>s.Id, a=>a.MapFrom(map => Guid.NewGuid()));
            CreateMap<Domain.TodoItem.TodoItem, TodoItemDto>().ReverseMap();


            CreateMap<TodoItemCreatoDtoV2, Domain.TodoItem.TodoItem>()
               .ForMember(s => s.Id, a => a.MapFrom(map => Guid.NewGuid()));
            CreateMap<Domain.TodoItem.TodoItem, TodoItemDtoV2>().ReverseMap();

        }
    }
}
