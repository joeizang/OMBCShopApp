﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OBMCShopApp.Data;

#nullable disable

namespace OBMCShopApp.Migrations
{
    [DbContext(typeof(OBMCShopAppContext))]
    [Migration("20220209210512_AddDateOnly")]
    partial class AddDateOnly
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OBMCShopApp.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("text");

                    b.Property<string>("Comments")
                        .HasColumnType("text");

                    b.Property<decimal>("CostPrice")
                        .HasColumnType("numeric(12,2)");

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<decimal>("RetailPrice")
                        .HasColumnType("numeric(12,2)");

                    b.Property<int>("ShelfId")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("SupplyDate")
                        .HasColumnType("date");

                    b.Property<int>("UnitMeasure")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("UpdatedAt")
                        .HasColumnType("date");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("ShelfId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OBMCShopApp.Models.ProductSold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<int?>("SaleId")
                        .HasColumnType("integer");

                    b.Property<string>("ShelfNumber")
                        .HasColumnType("text");

                    b.Property<DateOnly>("UpdatedAt")
                        .HasColumnType("date");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("SaleId");

                    b.ToTable("ProductsSold");
                });

            modelBuilder.Entity("OBMCShopApp.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("numeric");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("ModeOfPayment")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("SaleDate")
                        .HasColumnType("date");

                    b.Property<string>("SalesPerson")
                        .HasColumnType("text");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("numeric");

                    b.Property<int>("TypeOfSale")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("UpdatedAt")
                        .HasColumnType("date");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("OBMCShopApp.Models.Shelf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("ShelfDescription")
                        .HasColumnType("text");

                    b.Property<string>("ShelfNumber")
                        .HasColumnType("text");

                    b.Property<DateOnly>("UpdatedAt")
                        .HasColumnType("date");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Shelves");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "1",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "2",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "3",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "4",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "5",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "6",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "7",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "8",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "9",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "10",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "11",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "12",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "13",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "14",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "15",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "16",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "17",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "18",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "19",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 20,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "20",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 21,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "21",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 22,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "22",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 23,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "23",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 24,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "24",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 25,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "25",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 26,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "26",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 27,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "27",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 28,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "28",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 29,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "29",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 30,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "30",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 31,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "31",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 32,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "32",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 33,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "33",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 34,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "34",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 35,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "35",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 36,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "36",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 37,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "37",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 38,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "38",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 39,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "39",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 40,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "40",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 41,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "41",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        },
                        new
                        {
                            Id = 42,
                            CreatedAt = new DateOnly(2022, 2, 9),
                            IsDeleted = false,
                            ShelfDescription = "Has the following products",
                            ShelfNumber = "42",
                            UpdatedAt = new DateOnly(2022, 2, 9)
                        });
                });

            modelBuilder.Entity("OBMCShopApp.Models.ApplicationRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("ApplicationRole");
                });

            modelBuilder.Entity("OBMCShopApp.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OBMCShopApp.Models.Product", b =>
                {
                    b.HasOne("OBMCShopApp.Models.Shelf", "ProductShelf")
                        .WithMany("Products")
                        .HasForeignKey("ShelfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductShelf");
                });

            modelBuilder.Entity("OBMCShopApp.Models.ProductSold", b =>
                {
                    b.HasOne("OBMCShopApp.Models.Sale", null)
                        .WithMany("ItemsSold")
                        .HasForeignKey("SaleId");
                });

            modelBuilder.Entity("OBMCShopApp.Models.Sale", b =>
                {
                    b.Navigation("ItemsSold");
                });

            modelBuilder.Entity("OBMCShopApp.Models.Shelf", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}