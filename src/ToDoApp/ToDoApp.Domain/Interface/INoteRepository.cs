using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain.Interface
{
    public interface INoteRepository : IGenericRepository<Note>
    {
        Task<QueryResult<Note>> GetAll(UserParams userParama);
        Task<QueryResult<Note>> GetBySubCategoryId(Guid Id, UserParams userParama);
        Task<Note> GetById(Guid Id);
    }
}
