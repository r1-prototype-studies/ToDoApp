using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.ViewModel;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Services.Interface
{
    public interface IFileService : IGenericService
    {
        Task<QueryResult<FileModel>> GetAll(UserParamsModel userParams);
        Task<QueryResult<FileModel>> GetBySubCategoryId(Guid Id, UserParamsModel userParams);
        Task<FileModel> GetById(Guid Id);
    }
}
