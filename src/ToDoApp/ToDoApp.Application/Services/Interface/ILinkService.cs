using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.ViewModel;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Services.Interface
{
    public interface ILinkService : IGenericService
    {
        Task<QueryResult<LinkModel>> GetAll(UserParamsModel userParams);
        Task<QueryResult<LinkModel>> GetBySubCategoryId(Guid Id, UserParamsModel userParams);
        Task<LinkModel> GetById(Guid Id);
    }
}
