using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphql_app
{
    public class Service
    {
        public List<Todo> GetTodos()
        {
            return new List<Todo>() { 
                new Todo { Id = 1, UserId = 1, Completed = true, Title = "get milk" },
                new Todo { Id = 1, UserId = 1, Completed = true, Title = "file tax returns by 24 dec" }
            };
        }
    }
}
