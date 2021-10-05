using Application.Contract.TodoItem;
using Application.TodoItem;
using Application.TodoItemV2;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class Startup
    {
        public static void ConfigureApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<ITodoItemService, TodoItemService>();
            services.AddScoped<ITodoItemServiceV2, TodoItemServiceV2>();

        }
    }
}
