using Final_Progect_Modul25.database_classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EntityFrame
{
    public class AppContext : DbContext
    {
        // Объекты такблицы users
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DateTime CreateDate { get; set; }

        public AppContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=FinalProjectModul25;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}