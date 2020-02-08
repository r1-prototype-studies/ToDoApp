using System;
using System.Collections.Generic;

namespace ToDoApp.Domain.Entities
{
    public class SubCategory
    {
        public Guid ID { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public List<ToDo> ToDos { get; set; }
        public List<Note> Notes { get; set; }
        public List<Link> Links { get; set; }
        public List<File> Files { get; set; }
        public SubCategory()
        {
            ToDos = new List<ToDo>();
            Notes = new List<Note>();
            Links = new List<Link>();
            Files = new List<File>();
        }

    }
}