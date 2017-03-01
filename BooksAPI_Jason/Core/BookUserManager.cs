using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BooksAPI_Jason.Core
{
    public class BookUserManager : UserManager<IdentityUser>
    {
        public BookUserManager() : base(new BookUserStore())
        {
        }
    }
}