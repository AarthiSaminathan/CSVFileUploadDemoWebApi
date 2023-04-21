using CSVFileDpUploadWepApi.Model;
using Microsoft.EntityFrameworkCore;

namespace CSVFileDpUploadWepApi
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
         public DbSet<Cities> cities { get; set; }

    }
}
