namespace J7z_E_Commerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var responce = new ServiceResponse<List<Product>>()
            {
                Data = await _context.products.ToListAsync(),
            };

            return responce;
        }
    }
}
