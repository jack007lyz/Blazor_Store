namespace J7z_E_Commerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var responce = new ServiceResponse<Product>();
            var product = await _context.products.FindAsync(productId);
            if (product == null)
            {
                responce.Success = false;
                responce.Message = "This product does not exist.";
            } 
            else
            {
                responce.Data = product;
            }

            return responce;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var responce = new ServiceResponse<List<Product>>()
            {
                Data = await _context.products.ToListAsync(),
            };

            return responce;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _context.products.Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower())).ToListAsync(),
            };

            return response;
        }
    }
}
