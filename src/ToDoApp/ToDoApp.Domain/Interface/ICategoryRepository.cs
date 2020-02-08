using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain.Interface
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<QueryResult<Category>> GetAll(UserParams userParama);
        Task<Category> GetById(Guid Id);
    }
}
