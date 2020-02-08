using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain.Interface
{
    public interface IFileRepository : IGenericRepository<File>
    {
        Task<QueryResult<File>> GetAll(UserParams userParams);
        Task<QueryResult<File>> GetBySubCategoryId(Guid Id, UserParams userParams);
        Task<File> GetById(Guid Id);
    }
}
