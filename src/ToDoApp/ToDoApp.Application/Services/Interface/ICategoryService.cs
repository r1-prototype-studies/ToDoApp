using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.ViewModel;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Services.Interface
{
    public interface ICategoryService : IGenericService
    {
        Task<QueryResult<CategoryModel>> GetAll(UserParamsModel userParams);
        Task<CategoryDetailModel> GetById(Guid Id);
    }
}
