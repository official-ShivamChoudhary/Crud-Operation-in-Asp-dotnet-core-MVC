using Crud_Operation_in_mvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Crud_Operation_in_mvc.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<Employee> employees { get; set; }
        public DbSet<Registrartion> registrartions { get; set; }



    }
}