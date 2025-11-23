using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly Repo.IProductRepo _productRepo;
        public ProductController(Repo.IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        public List<Models.Product> Get() => _productRepo.GetAllProducts();

    }
}
