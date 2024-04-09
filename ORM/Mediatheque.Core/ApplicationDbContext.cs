using Mediatheque.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Core
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Port=3306;Database=mediatheque;Uid=root;Pwd=;";
            var serverVersion = new MySqlServerVersion(new Version(10, 4, 32));
            optionsBuilder.UseMySql(connectionString, serverVersion)
                .LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

        public DbSet<CD> CDs { get; set; }
    }
}
