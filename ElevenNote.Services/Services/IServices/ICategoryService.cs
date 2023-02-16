using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevenNote.Models.CategoryModels;

namespace ElevenNote.Services.Services.IServices
{
    public interface ICategoryService
    {
        Task<bool> CreateCategory(CategoryCreate model);
        Task<List<CategoryListItem>> GetCategories();
        Task<CategoryDetail> GetCategory(int id);
    }
}