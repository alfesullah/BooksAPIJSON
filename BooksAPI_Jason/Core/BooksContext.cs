using BooksAPI_Jason.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace BooksAPI_Jason.Core
{
    public class BooksContext : IdentityDbContext
    {
        public BooksContext()
        : base("BooksContext")
        {
            //this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}