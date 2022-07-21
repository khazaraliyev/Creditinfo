using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL_DB
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Contract> Contracts { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
    }
}
