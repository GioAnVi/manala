using Microsoft.EntityFrameworkCore;
using Manala.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manala.Infraestructure.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }

        public DbSet<Paciente> MyProperty { get; set; }
    }
}
