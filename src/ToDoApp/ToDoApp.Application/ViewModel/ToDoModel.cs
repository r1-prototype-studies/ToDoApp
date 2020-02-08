using System;
using ToDoApp.Domain.Common;

namespace ToDoApp.Application.ViewModel
{
    public class ToDoModel
    {
        public Guid Id { get; set; }
        public Guid SubCategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Status ToDoStatus { get; set; }
    }
}