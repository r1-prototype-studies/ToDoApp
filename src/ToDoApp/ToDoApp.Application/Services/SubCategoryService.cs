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
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository _repo;
        private readonly IMapper _mapper;

        public SubCategoryService(ISubCategoryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task Add<FileModel>(FileModel entity)
        {
            var newEntity = _mapper.Map<SubCategory>(entity);
            await _repo.Add(newEntity);
        }

        public async Task Delete(Guid id)
        {
            var entity = await _repo.GetById(id);
            await _repo.Delete(entity);
        }

        public async Task<QueryResult<SubCategoryModel>> GetAll(UserParamsModel userParams)
        {
            var result = new QueryResult<SubCategoryModel>();
            var entities = await _repo.GetAll(_mapper.Map<UserParams>(userParams));

            var models = _mapper.Map<List<SubCategory>, List<SubCategoryModel>>(entities.Items);

            result.Items = models;
            result.TotalItems = entities.TotalItems;
            result.CurrentPage = entities.CurrentPage;
            result.TotalPage = entities.TotalPage;

            return result;
        }

        public async Task<SubCategoryModel> GetById(Guid Id)
        {
            var entity = await _repo.GetById(Id);
            return _mapper.Map<SubCategoryModel>(entity);
        }

        public async Task<QueryResult<SubCategoryModel>> GetBySubCategoryId(Guid Id, UserParamsModel userParams)
        {
            var result = new QueryResult<SubCategoryModel>();
            var entities = await _repo.GetBySubCategoryId(Id, _mapper.Map<UserParams>(userParams));

            var fileModels = _mapper.Map<List<SubCategory>, List<SubCategoryModel>>(entities.Items);

            result.Items = fileModels;
            result.TotalItems = entities.TotalItems;
            result.CurrentPage = entities.CurrentPage;
            result.TotalPage = entities.TotalPage;

            return result;
        }

            public async Task Update<SubCategoryModel>(SubCategoryModel entity)
        {
            await _repo.Update(_mapper.Map<SubCategory>(entity));
        }
    }
}
