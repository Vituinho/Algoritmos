using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SiteProdutos.Models;

namespace SiteProdutos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
