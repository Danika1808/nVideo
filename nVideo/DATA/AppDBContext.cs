﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using nVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nVideo.DATA
{
    public class AppDBContext : IdentityDbContext<User>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options){

        }

        public DbSet<Catalog_Category> Categories { get; set; }
        public DbSet<Catalog_Entity> Entities { get; set; }
        public DbSet<Catalog_Attribute> Attributes { get; set; }
        public DbSet<Catalog_Value> Values { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}