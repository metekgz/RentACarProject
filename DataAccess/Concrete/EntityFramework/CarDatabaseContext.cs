﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarDatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-E87MSCU; Database=RentACar;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors{ get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}