

using infrastructure.Data;
using core.Entites;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class productsController :ControllerBase  // they're gonna derive from a framework class called controllerbase 
    {
        private readonly StoredContext _storedContext;
        public productsController(StoredContext storedContext)
        {
            _storedContext = storedContext;
        }
     

        [HttpGet]
        public ActionResult<List<Product>> GetProduct(){         // we're gonna return some data from our database so we will use ActionResul and we speciied what thing we're returning in our action result 
var products = _storedContext.prodcut.ToList();
return products;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProdcutByID(int id){

return await _storedContext.prodcut.FindAsync(id);
        }
    }
}