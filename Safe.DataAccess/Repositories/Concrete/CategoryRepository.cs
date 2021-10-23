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
                Id = c.Id,
                CategoryName = c.CategoryName,
                AmountPerMonth = c.AmountPerMonth
            }).ToList();

            return categories;
        }

        public CategoryDto GetCategoryById(int Id)
        {
            var category = _context.Categories.Where(c => c.Id == Id).Select(c => new CategoryDto
            {
                Id = c.Id,
                CategoryName = c.CategoryName,
                AmountPerMonth = c.AmountPerMonth
            }).FirstOrDefault();

            return category;
        }

        public void CreateCategory(CategoryDto categoryDto)
        {
            var category = new CategoryDto
            {
                CategoryName = categoryDto.CategoryName,
                AmountPerMonth = categoryDto.AmountPerMonth
            };

            _context.Add(category);
            _context.SaveChanges();
        }
    }
}
