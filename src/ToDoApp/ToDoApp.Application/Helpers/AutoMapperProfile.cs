using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Application.ViewModel;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryModel>().ReverseMap();
            CreateMap<Category, CategoryDetailModel>().ReverseMap();
            CreateMap<SubCategory, SubCategoryModel>().ReverseMap();
            CreateMap<Link, LinkModel>().ReverseMap();
            CreateMap<Note, NoteModel>().ReverseMap();
            CreateMap<ToDo, ToDoModel>().ReverseMap();
            CreateMap<File, FileModel>().ReverseMap();
            CreateMap<UserParams, UserParamsModel>().ReverseMap();

        }
    }
}
