using Manala.Infraestructure.Data;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Manala.API
{
    public class SampleContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<DataContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString, b => b.MigrationsAssembly("Manala.API"));

            return new DataContext(builder.Options);
        }
    }
}
