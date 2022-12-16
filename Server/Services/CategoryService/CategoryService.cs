using J7z_E_Commerce.Shared;

namespace J7z_E_Commerce.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {
            var responce = new ServiceResponse<List<Category>>()
            {
                Data = await _context.Categories.ToListAsync(),
            };

            return responce;
        }
    }
}
