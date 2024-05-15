﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimulationMicoHospital.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationMicoHospital.Data.DAL
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<AppUser> Users { get; set; } 

        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}