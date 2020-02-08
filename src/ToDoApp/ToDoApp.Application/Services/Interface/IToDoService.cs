using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.ViewModel;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Services.Interface
{
    public interface IToDoService : IGenericService
    {
        Task<QueryResult<ToDoModel>> GetAll(UserParamsModel userParams);
        Task<QueryResult<ToDoModel>> GetBySubCategoryId(Guid Id, UserParamsModel userParams);
        Task<ToDoModel> GetById(Guid Id);
    }
}
