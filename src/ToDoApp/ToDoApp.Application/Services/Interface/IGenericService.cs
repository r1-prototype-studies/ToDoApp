using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Application.Services.Interface
{
    public interface IGenericService
    {
        Task Add<T>(T entity);
        Task Update<T>(T entity);
        Task Delete(Guid id);

    }
}
