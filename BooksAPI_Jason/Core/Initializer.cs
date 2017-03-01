
using System.Data.Entity;

namespace BooksAPI_Jason.Core
{
    public class Initializer : MigrateDatabaseToLatestVersion<BooksContext, Configuration>
    {
    }
}