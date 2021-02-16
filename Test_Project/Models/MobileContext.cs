using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Test_Project.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

        /* По умолчанию у нас база данных отсутствуют. 
         * Поэтому в конструктор MobileContext определен вызов Database.EnsureCreated(),
         * который при отсутствии базы данных автоматически создает ее */
        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
