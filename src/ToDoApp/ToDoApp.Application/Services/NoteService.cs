﻿using AutoMapper;
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
    public class NoteService : INoteService
    {
        private readonly INoteRepository _repo;
        private readonly IMapper _mapper;

        public NoteService(INoteRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task Add<FileModel>(FileModel entity)
        {
            var newEntity = _mapper.Map<Note>(entity);
            await _repo.Add(newEntity);
        }

        public async Task Delete(Guid id)
        {
            var entity = await _repo.GetById(id);
            await _repo.Delete(entity);
        }

        public async Task<QueryResult<NoteModel>> GetAll(UserParamsModel userParams)
        {
            var result = new QueryResult<NoteModel>();
            var entities = await _repo.GetAll(_mapper.Map<UserParams>(userParams));

            var models = _mapper.Map<List<Note>, List<NoteModel>>(entities.Items);

            result.Items = models;
            result.TotalItems = entities.TotalItems;
            result.CurrentPage = entities.CurrentPage;
            result.TotalPage = entities.TotalPage;

            return result;
        }

        public async Task<NoteModel> GetById(Guid Id)
        {
            var entity = await _repo.GetById(Id);
            return _mapper.Map<NoteModel>(entity);
        }

        public async Task<QueryResult<NoteModel>> GetBySubCategoryId(Guid Id, UserParamsModel userParams)
        {
            var result = new QueryResult<NoteModel>();
            var entities = await _repo.GetBySubCategoryId(Id, _mapper.Map<UserParams>(userParams));

            var fileModels = _mapper.Map<List<Note>, List<NoteModel>>(entities.Items);

            result.Items = fileModels;
            result.TotalItems = entities.TotalItems;
            result.CurrentPage = entities.CurrentPage;
            result.TotalPage = entities.TotalPage;

            return result;
        }

            public async Task Update<NoteModel>(NoteModel entity)
        {
            await _repo.Update(_mapper.Map<Note>(entity));
        }
    }
}
