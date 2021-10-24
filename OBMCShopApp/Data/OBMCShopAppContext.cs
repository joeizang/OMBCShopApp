using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OBMCShopApp.Models;

namespace OBMCShopApp.Data
{
    public class OBMCShopAppContext : IdentityDbContext
    {
        public OBMCShopAppContext(DbContextOptions<OBMCShopAppContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> Users { get; set; }

        public DbSet<ApplicationRole> Roles { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductSold> ProductsSold { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<Shelf> Shelves { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Sale>()
                .HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<Product>()
                .HasQueryFilter(x => !x.IsDeleted);
            builder.Entity<Shelf>()
                .HasQueryFilter(s => !s.IsDeleted);
            builder.Entity<ProductSold>()
                .HasQueryFilter(p => p.IsDeleted);
            // SEED ROLES FOR APPLICATION
            
            
            builder.Entity<Shelf>()
                .HasData(
                    new Shelf
                    {
                        Id = 1,
                        ShelfNumber = "1",
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        Id = 2,
                        ShelfNumber = "2",
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        Id = 3,
                        ShelfNumber = "3",
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        Id = 4,
                        ShelfNumber = "4",
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        Id = 5,
                        ShelfNumber = "5",
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        Id = 6,
                        ShelfNumber = "6",
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        Id = 7,
                        ShelfNumber = "7",
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "8",
                        Id = 8,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "9",
                        Id = 9,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "10",
                        Id = 10,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "11",
                        Id = 11,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "12",
                        Id = 12,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "13",
                        Id = 13,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "14",
                        Id = 14,
                        ShelfDescription = "Has the following products"
                    }, new Shelf
                    {
                        
                        ShelfNumber = "15",
                        Id = 15,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "16",
                        Id = 16,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "17",
                        Id = 17,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "18",
                        Id = 18,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "19",
                        Id = 19,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "20",
                        Id = 20,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "21",
                        Id = 21,
                        ShelfDescription = "Has the following products"
                    }, 
                    new Shelf
                    {
                        
                        ShelfNumber = "22",
                        Id = 22,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "23",
                        Id = 23,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "24",
                        Id = 24,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "25",
                        Id = 25,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "26",
                        Id = 26,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "27",
                        Id = 27,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "28",
                        Id = 28,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "29",
                        Id = 29,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "30",
                        Id = 30,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "31",
                        Id = 31,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "32",
                        Id = 32,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "33",
                        Id = 33,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "34",
                        Id = 34,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "35",
                        Id = 35,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "36",
                        Id = 36,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "37",
                        Id = 37,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "38",
                        Id = 38,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "39",
                        Id = 39,
                        ShelfDescription = "Has the following products"
                    }, new Shelf
                    {
                        
                        ShelfNumber = "40",
                        Id = 40,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "41",
                        Id = 41,
                        ShelfDescription = "Has the following products"
                    },
                    new Shelf
                    {
                        
                        ShelfNumber = "42",
                        Id = 42,
                        ShelfDescription = "Has the following products"
                    }
                );
        }
    }
}