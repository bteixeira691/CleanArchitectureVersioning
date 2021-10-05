using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.EntityFrameworkCore
{
    public class MyProjectNameDbContext : DbContext
    {

        public MyProjectNameDbContext(DbContextOptions options): base(options)
        {
        }


        public DbSet<Domain.TodoItem.TodoItem> TodoItems { get; set; }

     
    }
}
