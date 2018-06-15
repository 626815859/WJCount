using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Bestwise.WJCourt.EntityFrameworkCore
{
    public static class WJCourtDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WJCourtDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WJCourtDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
