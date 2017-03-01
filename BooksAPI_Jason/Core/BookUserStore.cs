using Microsoft.AspNet.Identity.EntityFramework;

namespace BooksAPI_Jason.Core
{
    public class BookUserStore : UserStore<IdentityUser>
    {
        public BookUserStore() : base(new BooksContext())
        {
        }
    }
}