﻿using System;

namespace ToDoApp.Application.ViewModel
{
    public class NoteModel
    {
        public Guid Id { get; set; }
        public Guid SubCategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}