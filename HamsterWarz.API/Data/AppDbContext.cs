﻿using HamsterWarz.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWarz.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context) { }

        public DbSet<Hamster> Hamsters { get; set; }
        public DbSet<MatchData> MatchesData { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
            
        //    modelBuilder.Entity<MatchData>().HasOne(h1 => h1.Winner)
        //        .WithOne()
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<MatchData>().HasOne(h2 => h2.Loser)
        //        .WithOne()
        //        .OnDelete(DeleteBehavior.Restrict);
        //}
    }
}
