using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TodoItem
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
