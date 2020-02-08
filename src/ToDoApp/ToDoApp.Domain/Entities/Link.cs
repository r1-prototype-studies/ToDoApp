using System;
using ToDoApp.Domain.Common;

namespace ToDoApp.Domain.Entities
{
    public class Link: BaseEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}