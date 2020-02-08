using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.ViewModel;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Application.Services.Interface
{
    public interface INoteService : IGenericService
    {
        Task<QueryResult<NoteModel>> GetAll(UserParamsModel userParams);
        Task<QueryResult<NoteModel>> GetBySubCategoryId(Guid Id, UserParamsModel userParams);
        Task<NoteModel> GetById(Guid Id);
    }
}
