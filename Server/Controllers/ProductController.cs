using J7z_E_Commerce.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace J7z_E_Commerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductController(DataContext dataContext)
        {
            _context = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var products = await _context.products.ToListAsync();
            return Ok(products);
        }

    }
}
