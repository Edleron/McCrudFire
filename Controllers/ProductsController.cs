using Microsoft.AspNetCore.Mvc;

namespace McCrudFire.Controllers
{
    [Route("Products")]
    public class ProductsController : ControllerBase 
    {
        [Route("MerhabaOne")]
        public string MerhabaOne()
        {
            return "Merhaba - 1";
        }

        [Route("MerhabaTwo")]
        public string MerhabaTwo()
        {
            return "Merhaba - 2";
        }
    }
}
