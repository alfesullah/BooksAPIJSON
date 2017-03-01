using BooksAPI_Jason.Core;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Http;

namespace BooksAPI_Jason.Controllers
{
    public class BooksController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
           

            using (var context = new BooksContext())
            {
                context.Configuration.ProxyCreationEnabled = false;

                return Ok(await context.Books.Include(x => x.Reviews).ToListAsync());
            }
        }
    }
} 