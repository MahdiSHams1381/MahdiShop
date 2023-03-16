using Microsoft.EntityFrameworkCore;

namespace MahdiShop.Data.Context
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }
    }
}
