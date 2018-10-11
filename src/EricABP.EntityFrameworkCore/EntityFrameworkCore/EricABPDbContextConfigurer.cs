using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace EricABP.EntityFrameworkCore
{
    public static class EricABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EricABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EricABPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
