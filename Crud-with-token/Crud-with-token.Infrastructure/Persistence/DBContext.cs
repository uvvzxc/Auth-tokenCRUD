using Crud_with_token.Domain.Models.AuthModels;
using Microsoft.EntityFrameworkCore;

namespace Crud_with_token.Infrastructure.Persistence
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
            => Database.Migrate();

        public virtual DbSet<User> Users { get; set; }
    }
}
