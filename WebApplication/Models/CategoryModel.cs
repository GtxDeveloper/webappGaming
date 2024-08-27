using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entities;

namespace WebApplication.Models
{
    public class CategoryModel
    {
        private readonly GamePortalDbContext _gamePortalDbContext;

        public CategoryModel(GamePortalDbContext gamePortalDbContext)
        {
            _gamePortalDbContext = gamePortalDbContext;

            foreach (Category oneCategory in _gamePortalDbContext.Categories)
            {
                oneCategory.Childs = new List<Category>();
                foreach (Category anotherCategory in _gamePortalDbContext.Categories)
                {
                    if (oneCategory.Id == anotherCategory.ParentId)
                    {
                        oneCategory.Childs.Add(anotherCategory);
                    }
                }
            }
        }
        public List<Category> GetCategories()
        {
            return _gamePortalDbContext.Categories.OrderBy(x => x.Id).ToList();
        }
        public List<Category> GetParentCategories()
        {
            return _gamePortalDbContext.Categories.Where(c => c.ParentId == null).OrderBy(x => x.Id).ToList();
        }
        public Category GetCategoryById(int Id)
        {
            return _gamePortalDbContext.Categories.FirstOrDefault(t => t.Id == Id);
        }
        public Category GetCategoryBySlug(string slug)
        {
            return _gamePortalDbContext.Categories.FirstOrDefault(t => t.Slug == slug);
        }
    }
}
