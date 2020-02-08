using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain.Interface
{
    public interface ILinkRepository : IGenericRepository<Link>
    {
        Task<QueryResult<Link>> GetAll(UserParams userParama);
        Task<QueryResult<Link>> GetBySubCategoryId(Guid Id, UserParams userParama);
        Task<Link> GetById(Guid Id);
    }
}
