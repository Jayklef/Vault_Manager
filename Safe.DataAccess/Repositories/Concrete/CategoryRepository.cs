using Safe.DataAccess.Dtos;
using Safe.DataAccess.Repositories.Interface;
using Safe.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Repositories.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly SafeContext _context;

        public CategoryRepository(SafeContext context)
        {
            _context = context;
        }

        public List<CategoryDto> GetAllCategories()
        {
            var categories = _context.Categories.Select(c => new CategoryDto
            {
                id = c.id,
                categoryName = c.categoryName,
                amountPerMonth = c.amountPerMonth
            }).ToList();

            return categories;
        }

        public CategoryDto GetCategoryById(int id)
        {
            var category = _context.Categories.Where(c => c.id == id).Select(c => new CategoryDto
            {
                id = c.id,
                categoryName = c.categoryName,
                amountPerMonth = c.amountPerMonth
            }).FirstOrDefault();

            return category;
        }

        public void CreateCategory(CategoryDto categoryDto)
        {
            var category = new CategoryDto
            {
                categoryName = categoryDto.categoryName,
                amountPerMonth = categoryDto.amountPerMonth
            };

            _context.Add(category);
            _context.SaveChanges();
        }
    }
}
