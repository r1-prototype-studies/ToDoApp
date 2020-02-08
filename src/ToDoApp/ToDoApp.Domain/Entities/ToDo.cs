using System;
using ToDoApp.Domain.Common;

namespace ToDoApp.Domain.Entities
{
    public class ToDo : BaseEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Status ToDoStatus { get; set; }
        public ToDo()
        {
            ToDoStatus = Status.Created;
        }

    }
}