using Safe.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Repositories.Interface
{
    public interface ICategoryRepository
    {
        List<CategoryDto> GetAllCategories();
        CategoryDto GetCategoryById(int Id);
        void CreateCategory(CategoryDto categoryDto);
    }
}
