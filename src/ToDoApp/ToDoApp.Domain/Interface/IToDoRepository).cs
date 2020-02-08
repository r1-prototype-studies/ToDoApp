using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain.Interface
{
    public interface IToDoRepository : IGenericRepository<ToDo>
    {
        Task<QueryResult<ToDo>> GetAll(UserParams userParama);
        Task<QueryResult<ToDo>> GetBySubCategoryId(Guid Id, UserParams userParama);
        Task<ToDo> GetById(Guid Id);
    }
}
