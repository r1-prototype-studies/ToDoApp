using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Domain.Entities
{
    public class Category
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public List<SubCategory> SubCategories { get; set; }
        public Category()
        {
            SubCategories = new List<SubCategory>();
        }
    }
}
