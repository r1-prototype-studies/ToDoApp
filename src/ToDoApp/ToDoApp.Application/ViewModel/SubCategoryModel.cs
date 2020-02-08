using System;
using System.Collections.Generic;

namespace ToDoApp.Application.ViewModel
{
    public class SubCategoryModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public List<ToDoModel> Todos { get; set; }
        public List<NoteModel> Notes { get; set; }
        public List<LinkModel> Links { get; set; }
        public List<FileModel> Files { get; set; }

        public SubCategoryModel()
        {
            Todos = new List<ToDoModel>();
            Notes = new List<NoteModel>();
            Links = new List<LinkModel>();
            Files = new List<FileModel>();
        }
    }
}