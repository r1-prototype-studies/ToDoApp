using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain.Interface
{
    public interface ISubCategoryRepository : IGenericRepository<SubCategory>
    {
        Task<QueryResult<SubCategory>> GetAll(UserParams userParama);
        Task<QueryResult<SubCategory>> GetBySubCategoryId(Guid Id, UserParams userParama);
        Task<SubCategory> GetById(Guid Id);
    }
}
