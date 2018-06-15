using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Bestwise.WJCourt.Configuration;
using Bestwise.WJCourt.Web;

namespace Bestwise.WJCourt.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class WJCourtDbContextFactory : IDesignTimeDbContextFactory<WJCourtDbContext>
    {
        public WJCourtDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WJCourtDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            WJCourtDbContextConfigurer.Configure(builder, configuration.GetConnectionString(WJCourtConsts.ConnectionStringName));

            return new WJCourtDbContext(builder.Options);
        }
    }
}
