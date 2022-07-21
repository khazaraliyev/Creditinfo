using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Contract> Contracts { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }
    }
}
