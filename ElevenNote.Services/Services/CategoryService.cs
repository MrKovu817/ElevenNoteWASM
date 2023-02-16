using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ElevenNote.Data.DatabaseContext;
using ElevenNote.Data.Entities;
using ElevenNote.Models.CategoryModels;
using ElevenNote.Services.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ElevenNote.Services.Services
{
    
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _dbContext;
        private IMapper _mapper;

        public CategoryService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<bool> CreateCategory(CategoryCreate model)
        {
            var category = _mapper.Map<Category>(model);
            await _dbContext.Categories.AddAsync(category);
            return await _dbContext.SaveChangesAsync() >0;
        }

        public async Task<List<CategoryListItem>> GetCategories()
        {
            // return await _dbContext.Categories.Select(c=>_mapper.Map<CategoryListItem>(c)).ToListAsync();
            return _mapper.Map<List<CategoryListItem>>(await _dbContext.Categories.ToListAsync());
        }

        public async Task<CategoryDetail> GetCategory(int id)
        {
            // return _mapper.Map<CategoryDetail>(await _dbContext.Categories.FindAsync(id));
            var category = await _dbContext.Categories.FindAsync(id);
            if(category is null) return new CategoryDetail();
            return _mapper.Map<CategoryDetail>(category);
        }
    }
}