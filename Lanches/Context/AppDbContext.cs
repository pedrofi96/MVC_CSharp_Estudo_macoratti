﻿using Lanches.Models;
using Microsoft.EntityFrameworkCore;

namespace Lanches.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }

        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }



    }
}
