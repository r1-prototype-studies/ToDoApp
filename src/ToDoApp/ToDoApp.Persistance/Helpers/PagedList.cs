using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Persistance.Helpers
{
    public class PagedList<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public QueryResult<T> Items { get; set; }
    }
}
