﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sample_ecommerce_website.Models.DAL;

namespace sample_ecommerce_website.Migrations
{
    [DbContext(typeof(ProductDBContext))]
    [Migration("20220102214046_ProductStock")]
    partial class ProductStock
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("sample_ecommerce_website.Models.Image", b =>
                {
                    b.Property<string>("ImageID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ImageID");

                    b.HasIndex("ProductID");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ImageID = "asdasdwe",
                            ImageURL = "https://www.shutterstock.com/image-photo/wooden-baseball-bat-isolated-on-white-378948592",
                            ProductID = "asdfasdgafgdg"
                        },
                        new
                        {
                            ImageID = "jkpafas",
                            ImageURL = "https://www.shutterstock.com/image-vector/black-realistic-tshirt-front-view-isolated-1925573966",
                            ProductID = "basdafgagasd"
                        },
                        new
                        {
                            ImageID = "ahnfkdh",
                            ImageURL = "https://www.shutterstock.com/image-photo/new-tennis-racket-isolated-on-white-471436889",
                            ProductID = "asdwrwdrwerew"
                        },
                        new
                        {
                            ImageID = "iurheiu",
                            ImageURL = "https://www.shutterstock.com/image-photo/tennis-racket-on-white-background-760686820",
                            ProductID = "asdwrwdrwerew"
                        },
                        new
                        {
                            ImageID = "sdyiueki",
                            ImageURL = "https://www.shutterstock.com/image-vector/tennis-racket-silhouette-1075969826",
                            ProductID = "asdwrwdrwerew"
                        },
                        new
                        {
                            ImageID = "zljshxdl",
                            ImageURL = "https://www.shutterstock.com/image-photo/blue-blank-t-shirt-template-isolated-690352057",
                            ProductID = "sdfsdsgsssaa"
                        },
                        new
                        {
                            ImageID = "dfkjndsf",
                            ImageURL = "https://www.shutterstock.com/image-photo/soccer-ball-isolated-on-white-129557066",
                            ProductID = "opiljuppoiop"
                        },
                        new
                        {
                            ImageID = "gflsdhe",
                            ImageURL = "https://www.shutterstock.com/image-photo/red-tshirt-clothes-on-isolated-white-618080519",
                            ProductID = "nnlhjhjhiy"
                        },
                        new
                        {
                            ImageID = "asjkfnd",
                            ImageURL = "https://www.shutterstock.com/image-photo/vintage-red-shoes-on-white-background-92008067",
                            ProductID = "jhahasja"
                        },
                        new
                        {
                            ImageID = "eqnasfdw",
                            ImageURL = "https://www.shutterstock.com/image-photo/professional-wireless-game-mouse-on-dark-750226153",
                            ProductID = "asdjioasdos"
                        });
                });

            modelBuilder.Entity("sample_ecommerce_website.Models.Product", b =>
                {
                    b.Property<string>("ProductID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiscountID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = "asdfasdgafgdg",
                            Category = "Sports Equipment",
                            Description = "Baseball Bat",
                            Name = "BaseBall Bat",
                            Price = 15.119999999999999,
                            Stock = 4
                        },
                        new
                        {
                            ProductID = "basdafgagasd",
                            Category = "t-shirts",
                            Description = "Trendy T shirt",
                            DiscountID = "IASDAFFASD",
                            Name = "Trendy T shirt",
                            Price = 1123.1099999999999,
                            Stock = 10
                        },
                        new
                        {
                            ProductID = "asdwrwdrwerew",
                            Category = "Sports Equipment",
                            Description = "Tennis Racket",
                            Name = "Tennis Racket",
                            Price = 15.119999999999999,
                            Stock = 3
                        },
                        new
                        {
                            ProductID = "sdfsdsgsssaa",
                            Category = "t-shirts",
                            Description = "Blue T shirt",
                            DiscountID = "wqeqwrewtewtw",
                            Name = "Blue T shirt",
                            Price = 13.109999999999999,
                            Stock = 0
                        },
                        new
                        {
                            ProductID = "opiljuppoiop",
                            Category = "Sports Equipment",
                            Description = "Soccer Ball",
                            Name = "Soccer Ball",
                            Price = 15.119999999999999,
                            Stock = 7
                        },
                        new
                        {
                            ProductID = "nnlhjhjhiy",
                            Category = "t-shirts",
                            Description = "Red T shirt",
                            DiscountID = "nasdsajj",
                            Name = "Red T shirt",
                            Price = 12.109999999999999,
                            Stock = 9
                        },
                        new
                        {
                            ProductID = "jhahasja",
                            Category = "Shoes",
                            Description = "A red shoe",
                            Name = "Red Shoe",
                            Price = 15.119999999999999,
                            Stock = 2
                        },
                        new
                        {
                            ProductID = "asdjioasdos",
                            Category = "computer equipment",
                            Description = "Gaming Mouse",
                            Name = "Gaming Mouse",
                            Price = 89.989999999999995,
                            Stock = 100
                        });
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

            modelBuilder.Entity("sample_ecommerce_website.Models.Image", b =>
                {
                    b.HasOne("sample_ecommerce_website.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductID");
                });
#pragma warning restore 612, 618
        }
    }
}