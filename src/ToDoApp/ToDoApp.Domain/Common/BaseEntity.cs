using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Domain.Common
{
    public class BaseEntity
    {
        public DateTime Created { get; set; }
        public BaseEntity()
        {
            Created = DateTime.UtcNow;
        }
    }
}
