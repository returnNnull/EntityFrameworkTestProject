using EntityFrameworkTestProject.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTestProject
{
    internal class LocalDataBase : DbContext
    {

        public DbSet<User> Users { get; set; }

        public LocalDataBase()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlite($"Data Source= localDb.db");
    }
}
