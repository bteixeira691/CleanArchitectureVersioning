﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract.TodoItem
{
    public class TodoItemDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
    }
}
