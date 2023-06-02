using CrudwithRepositary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudwithRepositary
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<product> products { get; set; }
        public DbSet<output> outputs { get; set; }
        public DbSet<Input> inputs { get; set; }
        public DbSet<appointments> appointments { get; set; }
    }
}
