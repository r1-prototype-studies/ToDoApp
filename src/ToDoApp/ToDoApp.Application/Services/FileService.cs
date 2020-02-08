using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Services.Interface;
using ToDoApp.Application.ViewModel;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Interface;

namespace ToDoApp.Application.Services
{
    public class FileService : IFileService
    {
        private readonly IFileRepository _repo;
        private readonly IMapper _mapper;

        public FileService(IFileRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task Add<FileModel>(FileModel entity)
        {
            var newEntity = _mapper.Map<File>(entity);
            await _repo.Add(newEntity);
        }

        public async Task Delete(Guid id)
        {
            var file = await _repo.GetById(id);
            await _repo.Delete(file);
        }

        public async Task<QueryResult<FileModel>> GetAll(UserParamsModel userParams)
        {
            var result = new QueryResult<FileModel>();
            var files = await _repo.GetAll(_mapper.Map<UserParams>(userParams));

            var fileModels = _mapper.Map<List<File>, List<FileModel>>(files.Items);

            result.Items = fileModels;
            result.TotalItems = files.TotalItems;
            result.CurrentPage = files.CurrentPage;
            result.TotalPage = files.TotalPage;

            return result;
        }

        public async Task<FileModel> GetById(Guid Id)
        {
            var file = await _repo.GetById(Id);
            return _mapper.Map<FileModel>(file);
        }

        public async Task<QueryResult<FileModel>> GetBySubCategoryId(Guid Id, UserParamsModel userParams)
        {
            var result = new QueryResult<FileModel>();
            var entities = await _repo.GetBySubCategoryId(Id, _mapper.Map<UserParams>(userParams));

            var fileModels = _mapper.Map<List<File>, List<FileModel>>(entities.Items);

            result.Items = fileModels;
            result.TotalItems = entities.TotalItems;
            result.CurrentPage = entities.CurrentPage;
            result.TotalPage = entities.TotalPage;

            return result;
        }

        public async Task Update<FileModel>(FileModel entity)
        {
            await _repo.Update(_mapper.Map<File>(entity));
        }
    }
}
