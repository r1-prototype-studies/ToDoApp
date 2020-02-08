using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.ViewModel;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Services.Interface
{
    public interface ISubCategoryService : IGenericService
    {
        Task<QueryResult<SubCategoryModel>> GetAll(UserParamsModel userParams);
        Task<QueryResult<SubCategoryModel>> GetBySubCategoryId(Guid Id, UserParamsModel userParams);
        Task<SubCategoryModel> GetById(Guid Id);
    }
}
