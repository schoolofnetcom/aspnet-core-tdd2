using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MVC_TDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_TDD.Data
{
    public class MyContext : DbContext, IDisposable
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AulaEF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        //public MyContext()
        //    : base(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString)
        //{

        //}
    }
}
