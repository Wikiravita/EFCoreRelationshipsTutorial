﻿using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace EFCoreRelationshipsTutorial.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
