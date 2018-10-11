using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using EricABP.Configuration;
using EricABP.Web;

namespace EricABP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EricABPDbContextFactory : IDesignTimeDbContextFactory<EricABPDbContext>
    {
        public EricABPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EricABPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EricABPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EricABPConsts.ConnectionStringName));

            return new EricABPDbContext(builder.Options);
        }
    }
}
