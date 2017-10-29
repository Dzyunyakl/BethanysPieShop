using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext categoryRepository)
        {
            _appDbContext = categoryRepository;
        }

        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
