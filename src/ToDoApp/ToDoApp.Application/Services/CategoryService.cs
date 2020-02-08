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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task Add<CategoryModel>(CategoryModel entity)
        {
            var newCategory = _mapper.Map<Category>(entity);
            await _repo.Add(newCategory);
        }

        public async Task Delete(Guid id)
        {
            var category = await _repo.GetById(id);
            await _repo.Delete(category);
        }

        public async Task<QueryResult<CategoryModel>> GetAll(UserParamsModel userParams)
        {
            var result = new QueryResult<CategoryModel>();
            var categories = await _repo.GetAll(_mapper.Map<UserParams>(userParams));

            var categoriesModels = _mapper.Map<List<Category>, List<CategoryModel>>(categories.Items);

            result.Items = categoriesModels;
            result.TotalItems = categories.TotalItems;
            result.CurrentPage = categories.CurrentPage;
            result.TotalPage = categories.TotalPage;

            return result;
        }

        public async Task<CategoryDetailModel> GetById(Guid Id)
        {
            var category = await _repo.GetById(Id);
            return _mapper.Map<CategoryDetailModel>(category);
        }

        public async Task Update<CategoryModel>(CategoryModel entity)
        {
            await _repo.Update(_mapper.Map<Category>(entity));
        }
    }
}
